using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp9.DAO;
using WindowsFormsApp9.DTO;

namespace WindowsFormsApp9
{
    public partial class Admin : Form
    {
        BindingSource foodList = new BindingSource();
        BindingSource tableList = new BindingSource();
        BindingSource catgoryList = new BindingSource();
        BindingSource accountList = new BindingSource();
        public Account loginAccount;
        public Admin()
        {
            InitializeComponent();
            Load();
        }
        #region methods
        void Load()
        {
            dtgvfood.DataSource = foodList;
            dtgvtable.DataSource = tableList;
            dtgvCategory.DataSource = catgoryList;
            dtgvAccount.DataSource = accountList;
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkfromdate.Value, dtpkToDate.Value);
            LoadListFood();
            LoadAccount();
            LoadcategoryIntoCombobox(cbfoodcategory);
            LoadListCategory();
            LoadListTable();
            AddFoodBinding();
            AddCategoryBinding();
            AddTableBinding();
            AddAccoutnBinding();
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkfromdate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkfromdate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkin, DateTime checkout)
        {
            dtgvbill.DataSource = BillDAO.Instance.GetBillListByDate(checkin, checkout);
        }
        void AddFoodBinding()
        {
            txtfoodname.DataBindings.Add(new Binding("Text", dtgvfood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtfoodid.DataBindings.Add(new Binding("Text", dtgvfood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmfoodprice.DataBindings.Add(new Binding("Value", dtgvfood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        void AddAccoutnBinding()
        {
            txtusename.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UseName", true, DataSourceUpdateMode.Never));
            txtdisplayname.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisPlayName", true, DataSourceUpdateMode.Never));
            numericUpDown1.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        void LoadcategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        void LoadListFood()
        {
            foodList.DataSource = foodDAO.Instance.GetListFood();
        }
        void LoadListCategory()
        {
            catgoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }
        void LoadListTable()
        {
            tableList.DataSource = TableDAO.Instance.GetListTable();
        }
        void AddTableBinding()
        {
            txttablename.DataBindings.Add(new Binding("Text", dtgvtable.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txttableid.DataBindings.Add(new Binding("Text", dtgvtable.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtstatus.DataBindings.Add(new Binding("Text", dtgvtable.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }
        void AddCategoryBinding()
        {
            txtCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtCategoryid.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        List<food> SeachFoodByName(string name)
        {
            List<food> listFood = foodDAO.Instance.SearchFoodByName(name);
            return listFood;
        }
        void AddAccount(string usename, string displayname, int type)
        {
            try
            {
                if (AccountDAO.Instance.InsertAccount(usename, displayname, type))
                {
                    MessageBox.Show("Thêm tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại");
                }
                LoadAccount();
            }
            catch
            {
                MessageBox.Show("Tài khoản đã tồn tại");
            }
        }
        void EditAccount(string usename, string displayname, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(usename, displayname, type))
            {
                MessageBox.Show("Sửa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Sửa tài khoản thất bại");
            }
            LoadAccount();
        }
        void DeleteAccount(string usename)
        {
            if (loginAccount.Usename.Equals(usename))
            {
                MessageBox.Show("Bạn đang xóa tài khoản mà bạn đang đăng nhập?");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(usename))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
            LoadAccount();
        }
        void ResetPass(string usename)
        {
            if (AccountDAO.Instance.ResetPassWord(usename))
            {
                MessageBox.Show("Đặt mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt mật khẩu thất bại");
            }

        }
        #endregion

        #region Event

        private void btnviewbill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkfromdate.Value, dtpkToDate.Value);
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void txtfoodid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvfood.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvfood.SelectedCells[0].OwningRow.Cells["categoryID"].Value;
                    Category category = CategoryDAO.Instance.GetCategoryByID(id);
                    cbfoodcategory.SelectedItem = category;
                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbfoodcategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbfoodcategory.SelectedIndex = index;
                }
            }
            catch 
            {
                MessageBox.Show("Không thể tìm thấy món ăn!"); 
            }
        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            string name = txtfoodname.Text;
            int categoryID = (cbfoodcategory.SelectedItem as Category).ID;
            float price = (float)nmfoodprice.Value;
            if (foodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm đồ uống thành công");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm đồ uống");
            }

        }


        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }
        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }
        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }


        private void btnsua_Click(object sender, EventArgs e)
        {
            string name = txtfoodname.Text;
            int categoryID = (cbfoodcategory.SelectedItem as Category).ID;
            float price = (float)nmfoodprice.Value;
            int id = Convert.ToInt32(txtfoodid.Text);
            if (foodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa đồ uống thành công");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa đồ uống ");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtfoodid.Text);
            if (foodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa đồ uống thành công");
                LoadListFood();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa đồ uống");
            }
        }


        #endregion

        private void btnshow_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }

        private void btnshowtable_Click(object sender, EventArgs e)
        {
            LoadListTable();

        }
        private event EventHandler insertCategory;
        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }
        private event EventHandler deleteCategory;
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }
        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string name = txtCategory.Text;

            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm danh mục thành công");
                LoadListCategory();
                if (insertCategory != null)
                    insertCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm danh mục");
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string name = txtCategory.Text;
            int id = Convert.ToInt32(txtCategoryid.Text);
            if (CategoryDAO.Instance.UpdateCategory(name, id))
            {
                MessageBox.Show("Sửa danh mục thành công");
                LoadListCategory();
                if (updateCategory != null)
                    updateCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa danh mục ");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtCategoryid.Text);
                if (CategoryDAO.Instance.DeleteCategory(id))
                {
                    MessageBox.Show("Xóa danh mục thành công");
                    LoadListCategory();
                    if (deleteCategory != null)
                        deleteCategory(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Không thể xóa danh mục ");
                }
            }
            catch { MessageBox.Show("Xóa danh mục thất bại!"); }
        }
        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }
        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }
        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }

        private void btnaddtable_Click(object sender, EventArgs e)
        {
            string name = txttablename.Text;
            string status = txtstatus.Text;

            if (TableDAO.Instance.InsertTable(name, status))
            {
                MessageBox.Show("Thêm bàn thành công");
                LoadListTable();
                if (insertTable != null)
                    insertTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm bàn");
            }
        }

        private void btndeletetable_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txttableid.Text);
                if (TableDAO.Instance.DeleteTable(id))
                {
                    MessageBox.Show("Xóa bàn thành công");
                    LoadListTable();
                    if (deleteTable != null)
                        deleteTable(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa bàn");
                }
            }
            catch { MessageBox.Show("Xóa bàn thất bại!"); }
        }

        private void btnedittable_Click(object sender, EventArgs e)
        {
            string name = txttablename.Text;
            string status = txtstatus.Text;
            int id = Convert.ToInt32(txttableid.Text);
            if (TableDAO.Instance.UpdateTable(name, status, id))
            {
                MessageBox.Show("Sửa bàn thành công");
                LoadListTable();
                if (updateTable != null)
                    updateTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa bàn ");
            }
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SeachFoodByName(txtsearchfoodname.Text);
        }

        private void btnshowaccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnaddaccount_Click(object sender, EventArgs e)
        {
            string usename = txtusename.Text;
            string displayname = txtdisplayname.Text;
            int type = (int)numericUpDown1.Value;

            AddAccount(usename, displayname, type);
        }

        private void btneditaccount_Click(object sender, EventArgs e)
        {
            string usename = txtusename.Text;
            string displayname = txtdisplayname.Text;
            int type = (int)numericUpDown1.Value;

            EditAccount(usename, displayname, type);
        }

        private void btndeleteaccount_Click(object sender, EventArgs e)
        {
            string usename = txtusename.Text;

            DeleteAccount(usename);
        }

        private void btnresetpw_Click(object sender, EventArgs e)
        {
            string usename = txtusename.Text;

            ResetPass(usename);

        }
    }
}

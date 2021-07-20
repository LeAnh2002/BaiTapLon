using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp9.DAO;
using WindowsFormsApp9.DTO;
using static WindowsFormsApp9.ThongTinCaNhan;

namespace WindowsFormsApp9
{
    public partial class TableManeger : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public TableManeger(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadTable();
            LoadCategory();
        }
        #region Method

        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + LoginAccount.Displayname + ")";
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbcategory.DataSource = listCategory;
            cbcategory.DisplayMember = "Name";

        }
        void LoadFoodListByCategoryID(int id)
        {
            List<food> listfood = foodDAO.Instance.GetFoodByCategoryID(id);
            cbfood.DataSource = listfood;
            cbfood.DisplayMember = "Name";
        }


        void LoadTable()
        {
            flptable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button()
                { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case"Trống":
                        btn.BackColor = Color.Beige;
                        break;
                    default:
                        btn.BackColor = Color.LightGreen;
                        break;
                }
                flptable.Controls.Add(btn);
            }
        }



        void ShowBill(int id)
        {
            lsvbill.Items.Clear();
            List<WindowsFormsApp9.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalprice = 0;
            foreach (WindowsFormsApp9.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Foodname.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Totalprice.ToString());
                totalprice += item.Totalprice;
                lsvbill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            txtTotalPrice.Text = totalprice.ToString("c");

        }
        #endregion

        #region Event
        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvbill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
     
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ThongTinCaNhan f = new ThongTinCaNhan(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();

        }
        void f_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.Displayname + ")";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            f.loginAccount = LoginAccount;
            f.InsertFood += f_InsertFood;
            f.DeleteFood += f_DeleteFood;
            f.UpdateFood += f_UpdateFood;
            f.ShowDialog();
        }
        private void f_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbcategory.SelectedItem as Category).ID);
            if (lsvbill.Tag != null)
                ShowBill((lsvbill.Tag as Table).ID);
        }

        private void f_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbcategory.SelectedItem as Category).ID);
            if (lsvbill.Tag != null)
                ShowBill((lsvbill.Tag as Table).ID);

        }

        private void f_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbcategory.SelectedItem as Category).ID);
            if (lsvbill.Tag != null)
                ShowBill((lsvbill.Tag as Table).ID);
            LoadTable();
        }

        private void cbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }

        private void btnaddfood_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lsvbill.Tag as Table;
                if (table == null)
                {
                    MessageBox.Show("Hãy chọn bàn");
                    return;
                }
                int idbill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);

                int foodid = (cbfood.SelectedItem as food).ID;

                int count = (int)nmfoodcount.Value;

                if (idbill == -1)
                {
                    BillDAO.Instance.InsertBill(table.ID);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodid, count);
                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(idbill, foodid, count);
                }
                ShowBill(table.ID);
                LoadTable();
            }
            catch
            {
                MessageBox.Show("Thêm món thất bại!");
            }
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            Table table = lsvbill.Tag as Table;
            int idbill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nmgiamgia.Value;

            double totalprice = Convert.ToDouble(txtTotalPrice.Text.Split(',')[0]);
            double finaltotalprice = totalprice - (totalprice / 100) * discount;
            if (idbill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc muốn thanh toán hóa đơn cho {0}\n Tổng tiền -(Tổng tiền/100) x Giảm giá => \n {1} - {1} / 100 x {2} = {3}", table.Name, totalprice, discount, finaltotalprice), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idbill, discount, (float)finaltotalprice);
                    ShowBill(table.ID);
                    LoadTable();
                }

            }
        }
        #endregion

    }
}

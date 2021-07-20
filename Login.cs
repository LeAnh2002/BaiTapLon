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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình không ?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dr == DialogResult.Yes) Application.Exit();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string usename = txtusename.Text;
            string passwork = txtpasswork.Text;
            if (login(usename, passwork))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUseName(usename);
                TableManeger f = new TableManeger(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }

        bool login(string usename, string passwork)
        {

            return AccountDAO.Instance.Login(usename, passwork); ;
        }
    }
}

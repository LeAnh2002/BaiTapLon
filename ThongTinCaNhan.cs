﻿using System;
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
    public partial class ThongTinCaNhan : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public ThongTinCaNhan(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }
        void ChangeAccount(Account acc)
        {
            txtusename.Text = LoginAccount.Usename;
            txttenhienthi.Text = LoginAccount.Displayname;

        }
        void UpdateAccountInfo()
        {
            string displayname = txttenhienthi.Text;
            string passwork = txtpasswork.Text;
            string newpasswork = txtmkmoi.Text;
            string reenterpass = txtremkm.Text;
            string usename = txtusename.Text;
            if (!newpasswork.Equals(reenterpass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(usename, displayname, passwork, newpasswork))
                {
                    MessageBox.Show("Cập nhập thành công!");
                    if (updateAccount != null)
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUseName(usename)));
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu ");
                }
            }
        }
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        public class AccountEvent : EventArgs
        {
            private Account acc;
            public Account Acc { get => acc; set => acc = value; }
            public AccountEvent(Account acc)
            {
                this.Acc = acc;
            }
        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

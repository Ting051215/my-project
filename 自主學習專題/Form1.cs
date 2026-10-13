using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 自主學習專題
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "登入";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                // 假設登入成功，進入點餐頁
                Form4_Order orderForm = new Form4_Order();
                orderForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("請輸入帳號與密碼");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form3_Register registerForm = new Form3_Register();
            registerForm.Show();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            Form4_Order orderForm = new Form4_Order();
            orderForm.Show();
        }

        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnTogglePassword.Text = "隱藏密碼";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnTogglePassword.Text = "顯示密碼";
            }
        }
    }
}

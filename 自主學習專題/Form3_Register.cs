using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace 自主學習專題
{
    public partial class Form3_Register : Form
    {
        public Form3_Register()
        {
            
            InitializeComponent();
            this.Text = "註冊";
            // 一進來就提示帳密格式規則（方案1）
            string tips = "帳號規則：只能包含英文字母與數字\n" +
                          "密碼規則：長度需為 8~20 字元，且必須包含英文字、數字與標點符號";
            MessageBox.Show(tips, "註冊格式提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 預設隱藏密碼
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("請輸入帳號與密碼，並再次確認密碼");
                return;
            }

            if (!Regex.IsMatch(username, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("帳號只能包含英文字母與數字", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 8 || password.Length > 20)
            {
                MessageBox.Show("密碼長度必須為 8 到 20 字元", "密碼長度錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>/?]).+$"))
            {
                MessageBox.Show("密碼必須包含英文字、數字與標點符號", "密碼格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("兩次輸入的密碼不一致，請重新確認", "密碼不一致", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("註冊成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form4_Order orderForm = new Form4_Order();
            orderForm.Show();
            this.Hide();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            Form4_Order orderForm = new Form4_Order();
            orderForm.Show();
            this.Hide();
        }

        private void btnTogglePassword1_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            btnTogglePassword1.Text = txtPassword.UseSystemPasswordChar ? "顯示密碼" : "隱藏密碼";
        }

        private void btnToggleConfirmPassword_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = !txtConfirmPassword.UseSystemPasswordChar;
            btnToggleConfirmPassword.Text = txtConfirmPassword.UseSystemPasswordChar ? "顯示密碼" : "隱藏密碼";
        }
    }
}





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace _727CoffeeShop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        AccountBUS loginBus = new AccountBUS();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUserName.Text.Trim();
            string pass = txtPassWord.Text;
            bool b = false;
            try
            {
                AccountDTO acc = new AccountDTO(user, pass);
                b = loginBus.Login(acc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại\n" + ex.Message, "Login");
            }
            if (b)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn nhập sai tên hoặc mật khẩu", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                    Application.Exit();
                else
                {
                    txtPassWord.Text = "";
                    txtUserName.Focus();
                }
            }
        }
    }
}

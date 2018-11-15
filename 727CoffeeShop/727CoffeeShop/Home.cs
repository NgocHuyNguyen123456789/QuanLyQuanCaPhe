using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _727CoffeeShop
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Enabled = false;

            Login frm = new Login();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Enabled = true;
                lblText.Text = "WELCOME";
            }
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product frm = new Product();
            frm.ShowDialog();
        }
    }
}

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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // List<ProductDTO> list = new ProductBUS().GetProduct();
           // dgvProduct.DataSource = list;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            List<ProductDTO> list = new ProductBUS().GetProduct();
            dgvProduct.DataSource = list;
        }
    }
}

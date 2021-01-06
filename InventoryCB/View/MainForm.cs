using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryCB.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void img_Invent_Click(object sender, EventArgs e)
        {
            ProductsList producListForm = new ProductsList();
            producListForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProductsEditViewDialog productsEditForm = new ProductsEditViewDialog();
            productsEditForm.Show();
        }
    }
}
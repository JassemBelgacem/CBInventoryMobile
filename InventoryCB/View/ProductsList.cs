using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InventoryCB.Business.Service.Abstract;
using InventoryCB.Business.Service.Concret;
using InventoryCB.Model;

namespace InventoryCB.View
{
    public partial class ProductsList : Form
    {       

        public ProductsList()
        {            
            InitializeComponent();
        }

        private void ProductsList_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'inventoryDBDataSet.Products' table. You can move, or remove it, as needed.
           
            this.productsTableAdapter.Fill(this.inventoryDBDataSet.Products);

        }

        private void newMenuItemMenuItem_Click(object sender, EventArgs e)
        {
            productsBindingSource.AddNew();
            InventoryCB.ProductsEditViewDialog productsEditViewDialog = InventoryCB.ProductsEditViewDialog.Instance(this.productsBindingSource);
            productsEditViewDialog.ShowDialog();

        }

        private void dataGrid1_Click(object sender, EventArgs e)
        {
            InventoryCB.ProductsSummaryViewDialog productsSummaryViewDialog = InventoryCB.ProductsSummaryViewDialog.Instance(this.productsBindingSource);
            productsSummaryViewDialog.ShowDialog();

        }

        private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
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

namespace InventoryCB
{
    public partial class ProductsEditViewDialog : Form
    {
        IProductService _productService;

        public ProductsEditViewDialog()
        {
            this._productService = new ProductService();
            InitializeComponent();
        }

        private void ProductsEditViewDialog_Closing(object sender, CancelEventArgs e)
        {
            this.productsBindingSource.EndEdit();

        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            //Check if the product exist in Database
            Product product = _productService.FindProductByReference(referenceTextBox.Text);

            if (product == null) //The product don't exist
            {
                //Get product informations from world openfoodfacts API
                product = _productService.GetProductInfo(referenceTextBox.Text, ExpiryDateTimePicker.Value);
                _productService.AddProduct(product);
                if (product != null)
                {                    
                    _productService.AddProduct(product);
                    MessageBox.Show("Refrence added!");
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Unable to read product informations!");
                    referenceTextBox.Text = "";
                    referenceTextBox.Focus();
                }
            }
            else
            {
                //if the product exist we compare Expiry date 
                if (product.expiryDate > ExpiryDateTimePicker.Value)
                {
                 //Update if the new expiryDate < expiryDate stored in dataBase
                _productService.UpdateExipryDate(referenceTextBox.Text, ExpiryDateTimePicker.Value);
                MessageBox.Show ("Expiry date updated!");
                this.Close();
                this.Dispose();
                }
 
            }
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
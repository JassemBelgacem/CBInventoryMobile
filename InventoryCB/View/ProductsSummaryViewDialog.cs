using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace InventoryCB
{
    public partial class ProductsSummaryViewDialog : Form
    {
        public ProductsSummaryViewDialog()
        {
            InitializeComponent();
           
            // Attach event handlers to auto-hide controls.
            this.AttachVisibilityBindings(this.Controls);
           
        }

        /// <summary>
        /// Fuction to Convert URL on Bitmap picture
        /// </summary>
        /// <param name="sURL">URL</param>
        /// <returns>BitmapImage</returns>
        public Bitmap getImageFromURL(String sURL)
        {
            HttpWebResponse myResponse = null ;          
            Bitmap bmp = null;
            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(sURL);
                myRequest.Method = "GET";
                myResponse = (HttpWebResponse)myRequest.GetResponse();
                bmp= new System.Drawing.Bitmap(myResponse.GetResponseStream());
                myResponse.Close();
            }
            catch (Exception ex)
            {
            }           

            return bmp;
        }

        private void editMenuItemMenuItem_Click(object sender, EventArgs e)
        {
            InventoryCB.ProductsEditViewDialog productsEditViewDialog = InventoryCB.ProductsEditViewDialog.Instance(this.productsBindingSource);
            productsEditViewDialog.ShowDialog();
            this.Close();

        }

        private void ProductsSummaryViewDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                this.AutoScrollPosition = new System.Drawing.Point(0, ((0 - this.AutoScrollPosition.Y)
                                - 16));
                e.Handled = true;
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                this.AutoScrollPosition = new System.Drawing.Point(0, ((0 - this.AutoScrollPosition.Y)
                                + 16));
                e.Handled = true;
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        private void menuItem1_Click(object sender, EventArgs e)
        {

           
        }

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = getImageFromURL(pictureLabel1.Text);
            if (bmp == null)
            {
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox1.Image = bmp;
                pictureBox1.Visible = true;
            }
        }
    }
}
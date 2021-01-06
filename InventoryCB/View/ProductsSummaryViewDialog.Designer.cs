namespace InventoryCB
{
    partial class ProductsSummaryViewDialog
    {
        public void AttachVisibilityBindings(ControlCollection controls)
        {
            for (int i = 0; (i < controls.Count); i = (i + 1))
            {
                if ((controls[i].DataBindings["Visible"] != null))
                {
                    // Attach event handlers to auto-hide controls.
                    controls[i].DataBindings["Visible"].Format += new System.Windows.Forms.ConvertEventHandler(this.Visibility_Format);
                    controls[i].DataBindings["Visible"].DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
                }
            }

        }
    
        public void Visibility_Format(object sender, System.Windows.Forms.ConvertEventArgs e)
        {
            if ((e.Value == System.DBNull.Value))
            {
                e.Value = false;
            }
            else
            {
                e.Value = true;
            }

        }
    
        public static ProductsSummaryViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new InventoryCB.ProductsSummaryViewDialog();
                defaultInstance.productsBindingSource.DataSource = bindingSource;
            }
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.productsBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static ProductsSummaryViewDialog defaultInstance;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label referenceLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label pictureLabel;
            System.Windows.Forms.Label ExpiryDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsSummaryViewDialog));
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.editMenuItemMenuItem = new System.Windows.Forms.MenuItem();
            this.referenceLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.pictureLabel1 = new System.Windows.Forms.Label();
            this.ExpiryDateLabel1 = new System.Windows.Forms.Label();
            this.topBorderPanel = new System.Windows.Forms.Panel();
            this.leftBorderPanel = new System.Windows.Forms.Panel();
            this.rightBorderPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            referenceLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            pictureLabel = new System.Windows.Forms.Label();
            ExpiryDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // referenceLabel
            // 
            referenceLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.productsBindingSource, "Reference", true));
            referenceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            referenceLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            referenceLabel.Location = new System.Drawing.Point(4, 2);
            referenceLabel.Name = "referenceLabel";
            referenceLabel.Size = new System.Drawing.Size(232, 21);
            referenceLabel.Text = "Reference:";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = typeof(InventoryCB.InventoryDBDataSet);
            // 
            // nameLabel
            // 
            nameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.productsBindingSource, "Name", true));
            nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            nameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            nameLabel.Location = new System.Drawing.Point(4, 43);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(232, 21);
            nameLabel.Text = "Name:";
            // 
            // pictureLabel
            // 
            pictureLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.productsBindingSource, "Picture", true));
            pictureLabel.Dock = System.Windows.Forms.DockStyle.Top;
            pictureLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            pictureLabel.Location = new System.Drawing.Point(4, 84);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new System.Drawing.Size(232, 21);
            pictureLabel.Text = "Picture:";
            // 
            // ExpiryDateLabel
            // 
            ExpiryDateLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.productsBindingSource, "ExpiryDate", true));
            ExpiryDateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            ExpiryDateLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            ExpiryDateLabel.Location = new System.Drawing.Point(4, 126);
            ExpiryDateLabel.Name = "ExpiryDateLabel";
            ExpiryDateLabel.Size = new System.Drawing.Size(232, 21);
            ExpiryDateLabel.Text = "Expiry Dare:";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.editMenuItemMenuItem);
            // 
            // editMenuItemMenuItem
            // 
            this.editMenuItemMenuItem.Text = "Edit";
            this.editMenuItemMenuItem.Click += new System.EventHandler(this.editMenuItemMenuItem_Click);
            // 
            // referenceLabel1
            // 
            this.referenceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Reference", true));
            this.referenceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.productsBindingSource, "Reference", true));
            this.referenceLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.referenceLabel1.Location = new System.Drawing.Point(4, 23);
            this.referenceLabel1.Name = "referenceLabel1";
            this.referenceLabel1.Size = new System.Drawing.Size(232, 20);
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Name", true));
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.productsBindingSource, "Name", true));
            this.nameLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel1.Location = new System.Drawing.Point(4, 64);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(232, 20);
            // 
            // pictureLabel1
            // 
            this.pictureLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Picture", true));
            this.pictureLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureLabel1.Location = new System.Drawing.Point(4, 105);
            this.pictureLabel1.Name = "pictureLabel1";
            this.pictureLabel1.Size = new System.Drawing.Size(232, 21);
            this.pictureLabel1.Visible = false;
            // 
            // ExpiryDateLabel1
            // 
            this.ExpiryDateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ExpiryDate", true));
            this.ExpiryDateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.productsBindingSource, "ExpiryDate", true));
            this.ExpiryDateLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExpiryDateLabel1.Location = new System.Drawing.Point(4, 147);
            this.ExpiryDateLabel1.Name = "ExpiryDateLabel1";
            this.ExpiryDateLabel1.Size = new System.Drawing.Size(232, 20);
            this.ExpiryDateLabel1.Text = "+";
            // 
            // topBorderPanel
            // 
            this.topBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBorderPanel.Location = new System.Drawing.Point(4, 0);
            this.topBorderPanel.Name = "topBorderPanel";
            this.topBorderPanel.Size = new System.Drawing.Size(232, 2);
            // 
            // leftBorderPanel
            // 
            this.leftBorderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.leftBorderPanel.Name = "leftBorderPanel";
            this.leftBorderPanel.Size = new System.Drawing.Size(4, 268);
            // 
            // rightBorderPanel
            // 
            this.rightBorderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorderPanel.Location = new System.Drawing.Point(236, 0);
            this.rightBorderPanel.Name = "rightBorderPanel";
            this.rightBorderPanel.Size = new System.Drawing.Size(4, 268);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(43, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 105);
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(58, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(76, 84);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ProductsSummaryViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExpiryDateLabel1);
            this.Controls.Add(ExpiryDateLabel);
            this.Controls.Add(this.pictureLabel1);
            this.Controls.Add(pictureLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.referenceLabel1);
            this.Controls.Add(referenceLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "ProductsSummaryViewDialog";
            this.Text = "ProductsSummaryViewDialog";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductsSummaryViewDialog_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem editMenuItemMenuItem;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.Label referenceLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label pictureLabel1;
        private System.Windows.Forms.Label ExpiryDateLabel1;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
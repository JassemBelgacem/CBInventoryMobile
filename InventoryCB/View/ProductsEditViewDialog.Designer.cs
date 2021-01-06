namespace InventoryCB
{
    partial class ProductsEditViewDialog
    {
        public static ProductsEditViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new InventoryCB.ProductsEditViewDialog();
                defaultInstance.productsBindingSource.DataSource = bindingSource;
            }
            defaultInstance.referenceTextBox.Focus();
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.productsBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static ProductsEditViewDialog defaultInstance;
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
            System.Windows.Forms.Label ExpiryDateLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.referenceTextBox = new System.Windows.Forms.TextBox();
            this.topBorderPanel = new System.Windows.Forms.Panel();
            this.leftBorderPanel = new System.Windows.Forms.Panel();
            this.rightBorderPanel = new System.Windows.Forms.Panel();
            this.ExpiryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            referenceLabel = new System.Windows.Forms.Label();
            ExpiryDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // referenceLabel
            // 
            referenceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            referenceLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            referenceLabel.Location = new System.Drawing.Point(4, 2);
            referenceLabel.Name = "referenceLabel";
            referenceLabel.Size = new System.Drawing.Size(232, 21);
            referenceLabel.Text = "Reference:";
            // 
            // ExpiryDateLabel
            // 
            ExpiryDateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            ExpiryDateLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            ExpiryDateLabel.Location = new System.Drawing.Point(4, 44);
            ExpiryDateLabel.Name = "ExpiryDateLabel";
            ExpiryDateLabel.Size = new System.Drawing.Size(232, 21);
            ExpiryDateLabel.Text = "Expiry Dare:";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "OK";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Cancel";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = typeof(InventoryCB.InventoryDBDataSet);
            // 
            // referenceTextBox
            // 
            this.referenceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Reference", true));
            this.referenceTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.referenceTextBox.Location = new System.Drawing.Point(4, 23);
            this.referenceTextBox.Name = "referenceTextBox";
            this.referenceTextBox.Size = new System.Drawing.Size(232, 21);
            this.referenceTextBox.TabIndex = 1;
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
            // ExpiryDateTimePicker
            // 
            this.ExpiryDateTimePicker.Location = new System.Drawing.Point(3, 68);
            this.ExpiryDateTimePicker.Name = "ExpiryDateTimePicker";
            this.ExpiryDateTimePicker.Size = new System.Drawing.Size(233, 22);
            this.ExpiryDateTimePicker.TabIndex = 13;
            // 
            // ProductsEditViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.ControlBox = false;
            this.Controls.Add(this.ExpiryDateTimePicker);
            this.Controls.Add(ExpiryDateLabel);
            this.Controls.Add(this.referenceTextBox);
            this.Controls.Add(referenceLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "ProductsEditViewDialog";
            this.Text = "Add / Update Produt";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ProductsEditViewDialog_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.TextBox referenceTextBox;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.DateTimePicker ExpiryDateTimePicker;
    }
}
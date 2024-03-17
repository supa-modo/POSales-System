namespace POS_System_Demo
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.panelSlide = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelSubSetting = new System.Windows.Forms.Panel();
            this.buttonStore = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panelSubRecord = new System.Windows.Forms.Panel();
            this.buttonPOSRecord = new System.Windows.Forms.Button();
            this.buttonSaleHistory = new System.Windows.Forms.Button();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.buttonSupplier = new System.Windows.Forms.Button();
            this.panelSubStock = new System.Windows.Forms.Panel();
            this.buttonStockAdjustment = new System.Windows.Forms.Button();
            this.buttonStockEntry = new System.Windows.Forms.Button();
            this.buttonInStock = new System.Windows.Forms.Button();
            this.panelSubProduct = new System.Windows.Forms.Panel();
            this.buttonBrand = new System.Windows.Forms.Button();
            this.buttonCategory = new System.Windows.Forms.Button();
            this.buttonProductList = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelEdit = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSlide.SuspendLayout();
            this.panelSubSetting.SuspendLayout();
            this.panelSubRecord.SuspendLayout();
            this.panelSubStock.SuspendLayout();
            this.panelSubProduct.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSlide
            // 
            this.panelSlide.AutoScroll = true;
            this.panelSlide.BackColor = System.Drawing.Color.Teal;
            this.panelSlide.Controls.Add(this.buttonLogout);
            this.panelSlide.Controls.Add(this.panelSubSetting);
            this.panelSlide.Controls.Add(this.buttonSettings);
            this.panelSlide.Controls.Add(this.panelSubRecord);
            this.panelSlide.Controls.Add(this.buttonRecord);
            this.panelSlide.Controls.Add(this.buttonSupplier);
            this.panelSlide.Controls.Add(this.panelSubStock);
            this.panelSlide.Controls.Add(this.buttonInStock);
            this.panelSlide.Controls.Add(this.panelSubProduct);
            this.panelSlide.Controls.Add(this.buttonProduct);
            this.panelSlide.Controls.Add(this.buttonDashboard);
            this.panelSlide.Controls.Add(this.panelLogo);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSlide.Location = new System.Drawing.Point(0, 0);
            this.panelSlide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(217, 929);
            this.panelSlide.TabIndex = 0;
            this.panelSlide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSlide_Paint);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.buttonLogout.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonLogout.Location = new System.Drawing.Point(0, 1072);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.buttonLogout.Size = new System.Drawing.Size(200, 55);
            this.buttonLogout.TabIndex = 9;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panelSubSetting
            // 
            this.panelSubSetting.BackColor = System.Drawing.Color.CadetBlue;
            this.panelSubSetting.Controls.Add(this.buttonStore);
            this.panelSubSetting.Controls.Add(this.buttonUser);
            this.panelSubSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubSetting.Location = new System.Drawing.Point(0, 962);
            this.panelSubSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSubSetting.Name = "panelSubSetting";
            this.panelSubSetting.Size = new System.Drawing.Size(200, 110);
            this.panelSubSetting.TabIndex = 8;
            // 
            // buttonStore
            // 
            this.buttonStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStore.FlatAppearance.BorderSize = 0;
            this.buttonStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStore.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.buttonStore.ForeColor = System.Drawing.Color.White;
            this.buttonStore.Location = new System.Drawing.Point(0, 55);
            this.buttonStore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.buttonStore.Size = new System.Drawing.Size(200, 55);
            this.buttonStore.TabIndex = 5;
            this.buttonStore.Text = "Store";
            this.buttonStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStore.UseVisualStyleBackColor = true;
            this.buttonStore.Click += new System.EventHandler(this.buttonStore_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.buttonUser.ForeColor = System.Drawing.Color.White;
            this.buttonUser.Location = new System.Drawing.Point(0, 0);
            this.buttonUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.buttonUser.Size = new System.Drawing.Size(200, 55);
            this.buttonUser.TabIndex = 4;
            this.buttonUser.Text = "User";
            this.buttonUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Location = new System.Drawing.Point(0, 907);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.buttonSettings.Size = new System.Drawing.Size(200, 55);
            this.buttonSettings.TabIndex = 7;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // panelSubRecord
            // 
            this.panelSubRecord.BackColor = System.Drawing.Color.CadetBlue;
            this.panelSubRecord.Controls.Add(this.buttonPOSRecord);
            this.panelSubRecord.Controls.Add(this.buttonSaleHistory);
            this.panelSubRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubRecord.Location = new System.Drawing.Point(0, 797);
            this.panelSubRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSubRecord.Name = "panelSubRecord";
            this.panelSubRecord.Size = new System.Drawing.Size(200, 110);
            this.panelSubRecord.TabIndex = 6;
            // 
            // buttonPOSRecord
            // 
            this.buttonPOSRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPOSRecord.FlatAppearance.BorderSize = 0;
            this.buttonPOSRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPOSRecord.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.buttonPOSRecord.ForeColor = System.Drawing.Color.White;
            this.buttonPOSRecord.Location = new System.Drawing.Point(0, 55);
            this.buttonPOSRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPOSRecord.Name = "buttonPOSRecord";
            this.buttonPOSRecord.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.buttonPOSRecord.Size = new System.Drawing.Size(200, 55);
            this.buttonPOSRecord.TabIndex = 5;
            this.buttonPOSRecord.Text = "POS Record";
            this.buttonPOSRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPOSRecord.UseVisualStyleBackColor = true;
            this.buttonPOSRecord.Click += new System.EventHandler(this.buttonPOSRecord_Click);
            // 
            // buttonSaleHistory
            // 
            this.buttonSaleHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSaleHistory.FlatAppearance.BorderSize = 0;
            this.buttonSaleHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaleHistory.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.buttonSaleHistory.ForeColor = System.Drawing.Color.White;
            this.buttonSaleHistory.Location = new System.Drawing.Point(0, 0);
            this.buttonSaleHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSaleHistory.Name = "buttonSaleHistory";
            this.buttonSaleHistory.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.buttonSaleHistory.Size = new System.Drawing.Size(200, 55);
            this.buttonSaleHistory.TabIndex = 4;
            this.buttonSaleHistory.Text = "Sale History";
            this.buttonSaleHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaleHistory.UseVisualStyleBackColor = true;
            this.buttonSaleHistory.Click += new System.EventHandler(this.buttonSaleHistory_Click);
            // 
            // buttonRecord
            // 
            this.buttonRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRecord.FlatAppearance.BorderSize = 0;
            this.buttonRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecord.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.buttonRecord.ForeColor = System.Drawing.Color.White;
            this.buttonRecord.Location = new System.Drawing.Point(0, 742);
            this.buttonRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.buttonRecord.Size = new System.Drawing.Size(200, 55);
            this.buttonRecord.TabIndex = 5;
            this.buttonRecord.Text = "Record";
            this.buttonRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // buttonSupplier
            // 
            this.buttonSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSupplier.FlatAppearance.BorderSize = 0;
            this.buttonSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupplier.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.buttonSupplier.ForeColor = System.Drawing.Color.White;
            this.buttonSupplier.Location = new System.Drawing.Point(0, 687);
            this.buttonSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSupplier.Name = "buttonSupplier";
            this.buttonSupplier.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.buttonSupplier.Size = new System.Drawing.Size(200, 55);
            this.buttonSupplier.TabIndex = 4;
            this.buttonSupplier.Text = "Supplier";
            this.buttonSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupplier.UseVisualStyleBackColor = true;
            this.buttonSupplier.Click += new System.EventHandler(this.buttonSupplier_Click);
            // 
            // panelSubStock
            // 
            this.panelSubStock.BackColor = System.Drawing.Color.CadetBlue;
            this.panelSubStock.Controls.Add(this.buttonStockAdjustment);
            this.panelSubStock.Controls.Add(this.buttonStockEntry);
            this.panelSubStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubStock.Location = new System.Drawing.Point(0, 577);
            this.panelSubStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSubStock.Name = "panelSubStock";
            this.panelSubStock.Size = new System.Drawing.Size(200, 110);
            this.panelSubStock.TabIndex = 0;
            // 
            // buttonStockAdjustment
            // 
            this.buttonStockAdjustment.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStockAdjustment.FlatAppearance.BorderSize = 0;
            this.buttonStockAdjustment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStockAdjustment.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.buttonStockAdjustment.ForeColor = System.Drawing.Color.White;
            this.buttonStockAdjustment.Location = new System.Drawing.Point(0, 55);
            this.buttonStockAdjustment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStockAdjustment.Name = "buttonStockAdjustment";
            this.buttonStockAdjustment.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.buttonStockAdjustment.Size = new System.Drawing.Size(200, 55);
            this.buttonStockAdjustment.TabIndex = 5;
            this.buttonStockAdjustment.Text = "Stock Adjustment";
            this.buttonStockAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStockAdjustment.UseVisualStyleBackColor = true;
            this.buttonStockAdjustment.Click += new System.EventHandler(this.buttonStockAdjustment_Click);
            // 
            // buttonStockEntry
            // 
            this.buttonStockEntry.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonStockEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStockEntry.FlatAppearance.BorderSize = 0;
            this.buttonStockEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStockEntry.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.buttonStockEntry.ForeColor = System.Drawing.Color.White;
            this.buttonStockEntry.Location = new System.Drawing.Point(0, 0);
            this.buttonStockEntry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStockEntry.Name = "buttonStockEntry";
            this.buttonStockEntry.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.buttonStockEntry.Size = new System.Drawing.Size(200, 55);
            this.buttonStockEntry.TabIndex = 4;
            this.buttonStockEntry.Text = "Stock Entry";
            this.buttonStockEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStockEntry.UseVisualStyleBackColor = false;
            this.buttonStockEntry.Click += new System.EventHandler(this.buttonStockEntry_Click);
            // 
            // buttonInStock
            // 
            this.buttonInStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInStock.FlatAppearance.BorderSize = 0;
            this.buttonInStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInStock.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.buttonInStock.ForeColor = System.Drawing.Color.White;
            this.buttonInStock.Location = new System.Drawing.Point(0, 522);
            this.buttonInStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonInStock.Name = "buttonInStock";
            this.buttonInStock.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.buttonInStock.Size = new System.Drawing.Size(200, 55);
            this.buttonInStock.TabIndex = 3;
            this.buttonInStock.Text = "In Stock";
            this.buttonInStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInStock.UseVisualStyleBackColor = true;
            this.buttonInStock.Click += new System.EventHandler(this.buttonInStock_Click);
            // 
            // panelSubProduct
            // 
            this.panelSubProduct.BackColor = System.Drawing.Color.CadetBlue;
            this.panelSubProduct.Controls.Add(this.buttonBrand);
            this.panelSubProduct.Controls.Add(this.buttonCategory);
            this.panelSubProduct.Controls.Add(this.buttonProductList);
            this.panelSubProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubProduct.Location = new System.Drawing.Point(0, 357);
            this.panelSubProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSubProduct.Name = "panelSubProduct";
            this.panelSubProduct.Size = new System.Drawing.Size(200, 165);
            this.panelSubProduct.TabIndex = 0;
            // 
            // buttonBrand
            // 
            this.buttonBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBrand.FlatAppearance.BorderSize = 0;
            this.buttonBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrand.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.buttonBrand.ForeColor = System.Drawing.Color.White;
            this.buttonBrand.Location = new System.Drawing.Point(0, 110);
            this.buttonBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBrand.Name = "buttonBrand";
            this.buttonBrand.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.buttonBrand.Size = new System.Drawing.Size(200, 55);
            this.buttonBrand.TabIndex = 6;
            this.buttonBrand.Text = "Brand";
            this.buttonBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBrand.UseVisualStyleBackColor = true;
            this.buttonBrand.Click += new System.EventHandler(this.buttonBrand_Click);
            // 
            // buttonCategory
            // 
            this.buttonCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCategory.FlatAppearance.BorderSize = 0;
            this.buttonCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategory.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.buttonCategory.ForeColor = System.Drawing.Color.White;
            this.buttonCategory.Location = new System.Drawing.Point(0, 55);
            this.buttonCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.buttonCategory.Size = new System.Drawing.Size(200, 55);
            this.buttonCategory.TabIndex = 4;
            this.buttonCategory.Text = "Category";
            this.buttonCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCategory.UseVisualStyleBackColor = true;
            this.buttonCategory.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonProductList
            // 
            this.buttonProductList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProductList.FlatAppearance.BorderSize = 0;
            this.buttonProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductList.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.buttonProductList.ForeColor = System.Drawing.Color.White;
            this.buttonProductList.Location = new System.Drawing.Point(0, 0);
            this.buttonProductList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonProductList.Name = "buttonProductList";
            this.buttonProductList.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.buttonProductList.Size = new System.Drawing.Size(200, 55);
            this.buttonProductList.TabIndex = 3;
            this.buttonProductList.Text = "Product List";
            this.buttonProductList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProductList.UseVisualStyleBackColor = true;
            this.buttonProductList.Click += new System.EventHandler(this.buttonProductList_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProduct.FlatAppearance.BorderSize = 0;
            this.buttonProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduct.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.buttonProduct.ForeColor = System.Drawing.Color.White;
            this.buttonProduct.Location = new System.Drawing.Point(0, 302);
            this.buttonProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.buttonProduct.Size = new System.Drawing.Size(200, 55);
            this.buttonProduct.TabIndex = 2;
            this.buttonProduct.Text = "Product";
            this.buttonProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 247);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.buttonDashboard.Size = new System.Drawing.Size(200, 55);
            this.buttonDashboard.TabIndex = 0;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.labelEdit);
            this.panelLogo.Controls.Add(this.labelUsername);
            this.panelLogo.Controls.Add(this.labelRole);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 247);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Cocon-Regular", 12F);
            this.labelEdit.ForeColor = System.Drawing.Color.White;
            this.labelEdit.Location = new System.Drawing.Point(3, 143);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(28, 22);
            this.labelEdit.TabIndex = 0;
            this.labelEdit.Text = "Ln";
            this.labelEdit.Visible = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(44, 160);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(98, 25);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "UserName";
            this.labelUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.labelRole.ForeColor = System.Drawing.Color.White;
            this.labelRole.Location = new System.Drawing.Point(32, 196);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(131, 25);
            this.labelRole.TabIndex = 0;
            this.labelRole.Text = "Administrator";
            this.labelRole.Click += new System.EventHandler(this.labelRole_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 98);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Teal;
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle.Location = new System.Drawing.Point(217, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1133, 49);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(314, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(491, 38);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Title Name";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.GhostWhite;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(217, 49);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1133, 880);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1350, 929);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelSlide);
            this.Font = new System.Drawing.Font("Cocon-Regular", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1366, 968);
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSlide.ResumeLayout(false);
            this.panelSubSetting.ResumeLayout(false);
            this.panelSubRecord.ResumeLayout(false);
            this.panelSubStock.ResumeLayout(false);
            this.panelSubProduct.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panelSubProduct;
        private System.Windows.Forms.Button buttonBrand;
        private System.Windows.Forms.Button buttonCategory;
        private System.Windows.Forms.Button buttonProductList;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Panel panelSubStock;
        private System.Windows.Forms.Button buttonInStock;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Button buttonSupplier;
        private System.Windows.Forms.Button buttonStockAdjustment;
        private System.Windows.Forms.Button buttonStockEntry;
        private System.Windows.Forms.Panel panelSubRecord;
        private System.Windows.Forms.Button buttonPOSRecord;
        private System.Windows.Forms.Button buttonSaleHistory;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panelSubSetting;
        private System.Windows.Forms.Button buttonStore;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Label labelTitle;
    }
}


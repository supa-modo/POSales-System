namespace POS_System_Demo
{
    partial class Cashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChngPwd = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNewTrans = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelsl = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelTimer = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelVatable = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelSalesTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTransactionNo = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Increase = new System.Windows.Forms.DataGridViewImageColumn();
            this.Reduce = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelsl.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnChngPwd);
            this.panel1.Controls.Add(this.btnSales);
            this.panel1.Controls.Add(this.btnClearCart);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.btnDiscount);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnNewTrans);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 681);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(0, 631);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChngPwd
            // 
            this.btnChngPwd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChngPwd.FlatAppearance.BorderSize = 0;
            this.btnChngPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChngPwd.ForeColor = System.Drawing.Color.White;
            this.btnChngPwd.Image = ((System.Drawing.Image)(resources.GetObject("btnChngPwd.Image")));
            this.btnChngPwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChngPwd.Location = new System.Drawing.Point(0, 480);
            this.btnChngPwd.Name = "btnChngPwd";
            this.btnChngPwd.Size = new System.Drawing.Size(200, 50);
            this.btnChngPwd.TabIndex = 7;
            this.btnChngPwd.Text = "Change Password";
            this.btnChngPwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChngPwd.UseVisualStyleBackColor = true;
            this.btnChngPwd.Click += new System.EventHandler(this.btnChngPwd_Click);
            // 
            // btnSales
            // 
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(0, 430);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(200, 50);
            this.btnSales.TabIndex = 6;
            this.btnSales.Text = "Daily Sales";
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClearCart.FlatAppearance.BorderSize = 0;
            this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCart.ForeColor = System.Drawing.Color.White;
            this.btnClearCart.Image = ((System.Drawing.Image)(resources.GetObject("btnClearCart.Image")));
            this.btnClearCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearCart.Location = new System.Drawing.Point(0, 380);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(200, 50);
            this.btnClearCart.TabIndex = 5;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnPay
            // 
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(0, 330);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(200, 50);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Settle Payment";
            this.btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiscount.FlatAppearance.BorderSize = 0;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscount.Image")));
            this.btnDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscount.Location = new System.Drawing.Point(0, 280);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(200, 50);
            this.btnDiscount.TabIndex = 3;
            this.btnDiscount.Text = "Add Discount";
            this.btnDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 230);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 50);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search Product";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNewTrans
            // 
            this.btnNewTrans.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewTrans.FlatAppearance.BorderSize = 0;
            this.btnNewTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTrans.ForeColor = System.Drawing.Color.White;
            this.btnNewTrans.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTrans.Image")));
            this.btnNewTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewTrans.Location = new System.Drawing.Point(0, 180);
            this.btnNewTrans.Name = "btnNewTrans";
            this.btnNewTrans.Size = new System.Drawing.Size(200, 50);
            this.btnNewTrans.TabIndex = 1;
            this.btnNewTrans.Text = "New transaction";
            this.btnNewTrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewTrans.UseVisualStyleBackColor = true;
            this.btnNewTrans.Click += new System.EventHandler(this.btnNewTrans_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelUsername);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 180);
            this.panel2.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(49, 146);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(86, 22);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelsl
            // 
            this.panelsl.BackColor = System.Drawing.Color.Teal;
            this.panelsl.Controls.Add(this.panelSlide);
            this.panelsl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsl.Location = new System.Drawing.Point(200, 0);
            this.panelsl.Name = "panelsl";
            this.panelsl.Size = new System.Drawing.Size(8, 681);
            this.panelsl.TabIndex = 1;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.ForeColor = System.Drawing.SystemColors.Control;
            this.panelSlide.Location = new System.Drawing.Point(2, 180);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(5, 50);
            this.panelSlide.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.labelTimer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(208, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1056, 50);
            this.panel4.TabIndex = 2;
            // 
            // labelTimer
            // 
            this.labelTimer.BackColor = System.Drawing.Color.Teal;
            this.labelTimer.Font = new System.Drawing.Font("Cocon-Regular", 21F);
            this.labelTimer.Location = new System.Drawing.Point(809, 3);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(235, 47);
            this.labelTimer.TabIndex = 14;
            this.labelTimer.Text = "00 : 00 : 00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTimer.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.labelVatable);
            this.panel5.Controls.Add(this.labelTax);
            this.panel5.Controls.Add(this.labelDiscount);
            this.panel5.Controls.Add(this.labelSalesTotal);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.labelTransactionNo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1017, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(247, 631);
            this.panel5.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cocon-Regular", 13F, System.Drawing.FontStyle.Underline);
            this.label10.Location = new System.Drawing.Point(10, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Totals";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 42);
            this.label1.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.BackColor = System.Drawing.Color.Sienna;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Cocon-Regular", 17F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label9.Location = new System.Drawing.Point(0, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 50);
            this.label9.TabIndex = 15;
            this.label9.Text = "1234567890.00";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVatable
            // 
            this.labelVatable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelVatable.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.labelVatable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelVatable.Location = new System.Drawing.Point(113, 399);
            this.labelVatable.Name = "labelVatable";
            this.labelVatable.Size = new System.Drawing.Size(122, 22);
            this.labelVatable.TabIndex = 13;
            this.labelVatable.Text = "0.00";
            this.labelVatable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTax
            // 
            this.labelTax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTax.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.labelTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTax.Location = new System.Drawing.Point(113, 373);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(122, 22);
            this.labelTax.TabIndex = 12;
            this.labelTax.Text = "0.00";
            this.labelTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDiscount
            // 
            this.labelDiscount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelDiscount.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.labelDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelDiscount.Location = new System.Drawing.Point(113, 347);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(122, 22);
            this.labelDiscount.TabIndex = 11;
            this.labelDiscount.Text = "0.00";
            this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSalesTotal
            // 
            this.labelSalesTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelSalesTotal.Font = new System.Drawing.Font("Cocon-Regular", 13F);
            this.labelSalesTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelSalesTotal.Location = new System.Drawing.Point(113, 321);
            this.labelSalesTotal.Name = "labelSalesTotal";
            this.labelSalesTotal.Size = new System.Drawing.Size(122, 22);
            this.labelSalesTotal.TabIndex = 10;
            this.labelSalesTotal.Text = "0.00";
            this.labelSalesTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "VATable :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Discount : ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tax :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sales Total : ";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(15, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 29);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cocon-Regular", 12F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(14, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Barcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cocon-Regular", 12F, System.Drawing.FontStyle.Underline);
            this.label5.Location = new System.Drawing.Point(17, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Transaction No";
            // 
            // labelTransactionNo
            // 
            this.labelTransactionNo.AutoSize = true;
            this.labelTransactionNo.Location = new System.Drawing.Point(17, 80);
            this.labelTransactionNo.Name = "labelTransactionNo";
            this.labelTransactionNo.Size = new System.Drawing.Size(125, 22);
            this.labelTransactionNo.TabIndex = 2;
            this.labelTransactionNo.Text = "0000123456789";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Cocon-Regular", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvProducts.ColumnHeadersHeight = 40;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Increase,
            this.Reduce,
            this.Delete});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Location = new System.Drawing.Point(208, 50);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.Size = new System.Drawing.Size(809, 631);
            this.dgvProducts.TabIndex = 4;
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Width = 54;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Width = 47;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Product Code";
            this.Column2.Name = "Column2";
            this.Column2.Width = 135;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column5.HeaderText = "Qty";
            this.Column5.Name = "Column5";
            this.Column5.Width = 59;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column6.HeaderText = "Discount";
            this.Column6.Name = "Column6";
            this.Column6.Width = 101;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column7.HeaderText = "Total";
            this.Column7.Name = "Column7";
            this.Column7.Width = 71;
            // 
            // Increase
            // 
            this.Increase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Increase.HeaderText = "";
            this.Increase.Image = ((System.Drawing.Image)(resources.GetObject("Increase.Image")));
            this.Increase.Name = "Increase";
            this.Increase.Width = 5;
            // 
            // Reduce
            // 
            this.Reduce.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Reduce.HeaderText = "";
            this.Reduce.Image = ((System.Drawing.Image)(resources.GetObject("Reduce.Image")));
            this.Reduce.Name = "Reduce";
            this.Reduce.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelsl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cocon-Regular", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelsl.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelsl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnNewTrans;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChngPwd;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Increase;
        private System.Windows.Forms.DataGridViewImageColumn Reduce;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTransactionNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelSalesTotal;
        private System.Windows.Forms.Label labelVatable;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
    }
}
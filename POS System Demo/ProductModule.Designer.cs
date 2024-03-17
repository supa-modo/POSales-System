using System;

namespace POS_System_Demo
{
    partial class ProductModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelPcode = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.labelReorder = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelBarCode = new System.Windows.Forms.Label();
            this.comboBxBrand = new System.Windows.Forms.ComboBox();
            this.comboBxCategory = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.numericUpDnReorder = new System.Windows.Forms.NumericUpDown();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDnReorder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 40);
            this.panel1.TabIndex = 7;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(688, 1);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(33, 37);
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cocon-Regular", 13F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Module";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Cocon Light", 11.5F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(466, 355);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 34);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Cocon Light", 11.5F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(555, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 34);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelPcode
            // 
            this.labelPcode.AutoSize = true;
            this.labelPcode.Font = new System.Drawing.Font("Cocon-Regular", 12.5F);
            this.labelPcode.Location = new System.Drawing.Point(47, 91);
            this.labelPcode.Name = "labelPcode";
            this.labelPcode.Size = new System.Drawing.Size(126, 23);
            this.labelPcode.TabIndex = 10;
            this.labelPcode.Text = "Product Code :";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Cocon Light", 11.5F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(378, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 34);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtProductCode
            // 
            this.txtProductCode.Font = new System.Drawing.Font("Cocon-Regular", 12.5F);
            this.txtProductCode.Location = new System.Drawing.Point(176, 87);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(186, 30);
            this.txtProductCode.TabIndex = 8;
            // 
            // labelReorder
            // 
            this.labelReorder.AutoSize = true;
            this.labelReorder.Font = new System.Drawing.Font("Cocon-Regular", 12.5F);
            this.labelReorder.Location = new System.Drawing.Point(382, 289);
            this.labelReorder.Name = "labelReorder";
            this.labelReorder.Size = new System.Drawing.Size(136, 23);
            this.labelReorder.TabIndex = 14;
            this.labelReorder.Text = "Re-Order Level :";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Cocon-Regular", 12.5F);
            this.labelPrice.Location = new System.Drawing.Point(47, 289);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(61, 23);
            this.labelPrice.TabIndex = 15;
            this.labelPrice.Text = "Price :";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Cocon-Regular", 12.5F);
            this.labelCategory.Location = new System.Drawing.Point(47, 238);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(91, 23);
            this.labelCategory.TabIndex = 16;
            this.labelCategory.Text = "Category :";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Cocon-Regular", 12.5F);
            this.labelBrand.Location = new System.Drawing.Point(47, 188);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(66, 23);
            this.labelBrand.TabIndex = 17;
            this.labelBrand.Text = "Brand :";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Cocon-Regular", 12.5F);
            this.labelDescription.Location = new System.Drawing.Point(47, 140);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(114, 23);
            this.labelDescription.TabIndex = 18;
            this.labelDescription.Text = "Description :";
            // 
            // labelBarCode
            // 
            this.labelBarCode.AutoSize = true;
            this.labelBarCode.Font = new System.Drawing.Font("Cocon-Regular", 12.5F);
            this.labelBarCode.Location = new System.Drawing.Point(382, 91);
            this.labelBarCode.Name = "labelBarCode";
            this.labelBarCode.Size = new System.Drawing.Size(85, 23);
            this.labelBarCode.TabIndex = 19;
            this.labelBarCode.Text = "BarCode :";
            // 
            // comboBxBrand
            // 
            this.comboBxBrand.Font = new System.Drawing.Font("Cocon-Regular", 12.5F);
            this.comboBxBrand.FormattingEnabled = true;
            this.comboBxBrand.Location = new System.Drawing.Point(176, 184);
            this.comboBxBrand.Name = "comboBxBrand";
            this.comboBxBrand.Size = new System.Drawing.Size(476, 31);
            this.comboBxBrand.TabIndex = 20;
            // 
            // comboBxCategory
            // 
            this.comboBxCategory.Font = new System.Drawing.Font("Cocon-Regular", 12.5F);
            this.comboBxCategory.FormattingEnabled = true;
            this.comboBxCategory.Location = new System.Drawing.Point(176, 233);
            this.comboBxCategory.Name = "comboBxCategory";
            this.comboBxCategory.Size = new System.Drawing.Size(476, 31);
            this.comboBxCategory.TabIndex = 21;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Cocon-Regular", 12.5F);
            this.txtDescription.Location = new System.Drawing.Point(176, 135);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(476, 30);
            this.txtDescription.TabIndex = 22;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Font = new System.Drawing.Font("Cocon-Regular", 12.5F);
            this.txtBoxPrice.Location = new System.Drawing.Point(176, 285);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(186, 30);
            this.txtBoxPrice.TabIndex = 24;
            // 
            // numericUpDnReorder
            // 
            this.numericUpDnReorder.Font = new System.Drawing.Font("Cocon-Regular", 12.5F);
            this.numericUpDnReorder.Location = new System.Drawing.Point(517, 285);
            this.numericUpDnReorder.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDnReorder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDnReorder.Name = "numericUpDnReorder";
            this.numericUpDnReorder.Size = new System.Drawing.Size(135, 30);
            this.numericUpDnReorder.TabIndex = 25;
            this.numericUpDnReorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDnReorder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtBarCode
            // 
            this.txtBarCode.Font = new System.Drawing.Font("Cocon-Regular", 12.5F);
            this.txtBarCode.Location = new System.Drawing.Point(466, 87);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(186, 30);
            this.txtBarCode.TabIndex = 26;
            // 
            // ProductModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 403);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.numericUpDnReorder);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.comboBxCategory);
            this.Controls.Add(this.comboBxBrand);
            this.Controls.Add(this.labelBarCode);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelReorder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelPcode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtProductCode);
            this.Font = new System.Drawing.Font("Cocon-Regular", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductModule";
            this.Load += new System.EventHandler(this.ProductModule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDnReorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ProductModule_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelPcode;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label labelReorder;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelBarCode;
        private System.Windows.Forms.ComboBox comboBxBrand;
        private System.Windows.Forms.ComboBox comboBxCategory;
        public System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.NumericUpDown numericUpDnReorder;
        public System.Windows.Forms.TextBox txtBarCode;
    }
}
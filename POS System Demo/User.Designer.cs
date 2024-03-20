namespace POS_System_Demo
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelManageProducts = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.createUserPage = new MetroFramework.Controls.MetroTabPage();
            this.btnAccCancel = new System.Windows.Forms.Button();
            this.btnAccSave = new System.Windows.Forms.Button();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.changePasswordPage = new MetroFramework.Controls.MetroTabPage();
            this.btnChngCancel = new System.Windows.Forms.Button();
            this.btnChngSave = new System.Windows.Forms.Button();
            this.txtCurrentPwd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConfirmNewPwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserNChng = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.enableAccountPage = new MetroFramework.Controls.MetroTabPage();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.createUserPage.SuspendLayout();
            this.changePasswordPage.SuspendLayout();
            this.enableAccountPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.labelManageProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 563);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 78);
            this.panel1.TabIndex = 3;
            // 
            // labelManageProducts
            // 
            this.labelManageProducts.Font = new System.Drawing.Font("Cocon-Regular", 12F, System.Drawing.FontStyle.Underline);
            this.labelManageProducts.ForeColor = System.Drawing.Color.White;
            this.labelManageProducts.Image = ((System.Drawing.Image)(resources.GetObject("labelManageProducts.Image")));
            this.labelManageProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelManageProducts.Location = new System.Drawing.Point(9, 13);
            this.labelManageProducts.Name = "labelManageProducts";
            this.labelManageProducts.Size = new System.Drawing.Size(112, 56);
            this.labelManageProducts.TabIndex = 0;
            this.labelManageProducts.Text = "User   Settings";
            this.labelManageProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.createUserPage);
            this.metroTabControl1.Controls.Add(this.changePasswordPage);
            this.metroTabControl1.Controls.Add(this.enableAccountPage);
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.Location = new System.Drawing.Point(106, 81);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(886, 438);
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.UseSelectable = true;
            // 
            // createUserPage
            // 
            this.createUserPage.Controls.Add(this.btnAccCancel);
            this.createUserPage.Controls.Add(this.btnAccSave);
            this.createUserPage.Controls.Add(this.comboRole);
            this.createUserPage.Controls.Add(this.label4);
            this.createUserPage.Controls.Add(this.txtFullName);
            this.createUserPage.Controls.Add(this.label3);
            this.createUserPage.Controls.Add(this.txtPassword);
            this.createUserPage.Controls.Add(this.label2);
            this.createUserPage.Controls.Add(this.txtConfirmPwd);
            this.createUserPage.Controls.Add(this.label1);
            this.createUserPage.Controls.Add(this.txtUsername);
            this.createUserPage.Controls.Add(this.labelUsername);
            this.createUserPage.HorizontalScrollbarBarColor = true;
            this.createUserPage.HorizontalScrollbarHighlightOnWheel = false;
            this.createUserPage.HorizontalScrollbarSize = 2;
            this.createUserPage.Location = new System.Drawing.Point(4, 38);
            this.createUserPage.Name = "createUserPage";
            this.createUserPage.Size = new System.Drawing.Size(878, 396);
            this.createUserPage.TabIndex = 0;
            this.createUserPage.Text = "Create New User Account";
            this.createUserPage.VerticalScrollbarBarColor = true;
            this.createUserPage.VerticalScrollbarHighlightOnWheel = false;
            this.createUserPage.VerticalScrollbarSize = 3;
            // 
            // btnAccCancel
            // 
            this.btnAccCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAccCancel.FlatAppearance.BorderSize = 0;
            this.btnAccCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccCancel.Font = new System.Drawing.Font("Cocon Light", 11.5F);
            this.btnAccCancel.ForeColor = System.Drawing.Color.Black;
            this.btnAccCancel.Location = new System.Drawing.Point(456, 336);
            this.btnAccCancel.Name = "btnAccCancel";
            this.btnAccCancel.Size = new System.Drawing.Size(83, 34);
            this.btnAccCancel.TabIndex = 34;
            this.btnAccCancel.Text = "Cancel";
            this.btnAccCancel.UseVisualStyleBackColor = false;
            this.btnAccCancel.Click += new System.EventHandler(this.btnAccCancel_Click);
            // 
            // btnAccSave
            // 
            this.btnAccSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccSave.BackColor = System.Drawing.Color.Teal;
            this.btnAccSave.FlatAppearance.BorderSize = 0;
            this.btnAccSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccSave.Font = new System.Drawing.Font("Cocon Light", 11.5F);
            this.btnAccSave.ForeColor = System.Drawing.Color.White;
            this.btnAccSave.Location = new System.Drawing.Point(354, 336);
            this.btnAccSave.Name = "btnAccSave";
            this.btnAccSave.Size = new System.Drawing.Size(83, 34);
            this.btnAccSave.TabIndex = 33;
            this.btnAccSave.Text = "Save";
            this.btnAccSave.UseVisualStyleBackColor = false;
            this.btnAccSave.Click += new System.EventHandler(this.btnAccSave_Click);
            // 
            // comboRole
            // 
            this.comboRole.BackColor = System.Drawing.Color.White;
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Items.AddRange(new object[] {
            "Administrator",
            "Cashier",
            "Store Owner"});
            this.comboRole.Location = new System.Drawing.Point(272, 263);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(226, 30);
            this.comboRole.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(110, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Role : ";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.White;
            this.txtFullName.Location = new System.Drawing.Point(272, 105);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(466, 29);
            this.txtFullName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(110, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Full Name : ";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(272, 158);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(466, 29);
            this.txtPassword.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password : ";
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.BackColor = System.Drawing.Color.White;
            this.txtConfirmPwd.Location = new System.Drawing.Point(272, 211);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.Size = new System.Drawing.Size(466, 29);
            this.txtConfirmPwd.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Confirm Password : ";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(272, 52);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(466, 29);
            this.txtUsername.TabIndex = 3;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(110, 55);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(99, 22);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username : ";
            // 
            // changePasswordPage
            // 
            this.changePasswordPage.Controls.Add(this.btnChngCancel);
            this.changePasswordPage.Controls.Add(this.btnChngSave);
            this.changePasswordPage.Controls.Add(this.txtCurrentPwd);
            this.changePasswordPage.Controls.Add(this.label8);
            this.changePasswordPage.Controls.Add(this.txtNewPwd);
            this.changePasswordPage.Controls.Add(this.label7);
            this.changePasswordPage.Controls.Add(this.txtConfirmNewPwd);
            this.changePasswordPage.Controls.Add(this.label6);
            this.changePasswordPage.Controls.Add(this.txtUserNChng);
            this.changePasswordPage.Controls.Add(this.label5);
            this.changePasswordPage.HorizontalScrollbarBarColor = true;
            this.changePasswordPage.HorizontalScrollbarHighlightOnWheel = false;
            this.changePasswordPage.HorizontalScrollbarSize = 2;
            this.changePasswordPage.Location = new System.Drawing.Point(4, 38);
            this.changePasswordPage.Name = "changePasswordPage";
            this.changePasswordPage.Size = new System.Drawing.Size(878, 396);
            this.changePasswordPage.TabIndex = 1;
            this.changePasswordPage.Text = "Change Password";
            this.changePasswordPage.VerticalScrollbarBarColor = true;
            this.changePasswordPage.VerticalScrollbarHighlightOnWheel = false;
            this.changePasswordPage.VerticalScrollbarSize = 3;
            // 
            // btnChngCancel
            // 
            this.btnChngCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChngCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnChngCancel.FlatAppearance.BorderSize = 0;
            this.btnChngCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChngCancel.Font = new System.Drawing.Font("Cocon Light", 11.5F);
            this.btnChngCancel.ForeColor = System.Drawing.Color.Black;
            this.btnChngCancel.Location = new System.Drawing.Point(604, 293);
            this.btnChngCancel.Name = "btnChngCancel";
            this.btnChngCancel.Size = new System.Drawing.Size(83, 34);
            this.btnChngCancel.TabIndex = 36;
            this.btnChngCancel.Text = "Cancel";
            this.btnChngCancel.UseVisualStyleBackColor = false;
            // 
            // btnChngSave
            // 
            this.btnChngSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChngSave.BackColor = System.Drawing.Color.Teal;
            this.btnChngSave.FlatAppearance.BorderSize = 0;
            this.btnChngSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChngSave.Font = new System.Drawing.Font("Cocon Light", 11.5F);
            this.btnChngSave.ForeColor = System.Drawing.Color.White;
            this.btnChngSave.Location = new System.Drawing.Point(502, 293);
            this.btnChngSave.Name = "btnChngSave";
            this.btnChngSave.Size = new System.Drawing.Size(83, 34);
            this.btnChngSave.TabIndex = 35;
            this.btnChngSave.Text = "Save";
            this.btnChngSave.UseVisualStyleBackColor = false;
            // 
            // txtCurrentPwd
            // 
            this.txtCurrentPwd.BackColor = System.Drawing.Color.White;
            this.txtCurrentPwd.Location = new System.Drawing.Point(273, 128);
            this.txtCurrentPwd.Name = "txtCurrentPwd";
            this.txtCurrentPwd.Size = new System.Drawing.Size(466, 29);
            this.txtCurrentPwd.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(111, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Current Password :";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.BackColor = System.Drawing.Color.White;
            this.txtNewPwd.Location = new System.Drawing.Point(273, 179);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(466, 29);
            this.txtNewPwd.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(111, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "New Password : ";
            // 
            // txtConfirmNewPwd
            // 
            this.txtConfirmNewPwd.BackColor = System.Drawing.Color.White;
            this.txtConfirmNewPwd.Location = new System.Drawing.Point(273, 230);
            this.txtConfirmNewPwd.Name = "txtConfirmNewPwd";
            this.txtConfirmNewPwd.Size = new System.Drawing.Size(466, 29);
            this.txtConfirmNewPwd.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(111, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Confirm Password : ";
            // 
            // txtUserNChng
            // 
            this.txtUserNChng.BackColor = System.Drawing.Color.White;
            this.txtUserNChng.Location = new System.Drawing.Point(275, 77);
            this.txtUserNChng.Name = "txtUserNChng";
            this.txtUserNChng.Size = new System.Drawing.Size(466, 29);
            this.txtUserNChng.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(113, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Username : ";
            // 
            // enableAccountPage
            // 
            this.enableAccountPage.BackColor = System.Drawing.Color.White;
            this.enableAccountPage.Controls.Add(this.dgvUser);
            this.enableAccountPage.HorizontalScrollbarBarColor = true;
            this.enableAccountPage.HorizontalScrollbarHighlightOnWheel = false;
            this.enableAccountPage.HorizontalScrollbarSize = 2;
            this.enableAccountPage.Location = new System.Drawing.Point(4, 38);
            this.enableAccountPage.Name = "enableAccountPage";
            this.enableAccountPage.Size = new System.Drawing.Size(878, 396);
            this.enableAccountPage.TabIndex = 2;
            this.enableAccountPage.Text = "Enable/Disable Account";
            this.enableAccountPage.VerticalScrollbarBarColor = true;
            this.enableAccountPage.VerticalScrollbarHighlightOnWheel = false;
            this.enableAccountPage.VerticalScrollbarSize = 3;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cocon-Regular", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUser.ColumnHeadersHeight = 30;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Edit,
            this.Delete});
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.EnableHeadersVisualStyles = false;
            this.dgvUser.Location = new System.Drawing.Point(0, 0);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.Size = new System.Drawing.Size(878, 396);
            this.dgvUser.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Username";
            this.Column1.Name = "Column1";
            this.Column1.Width = 109;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Fullname";
            this.Column2.Name = "Column2";
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1117, 641);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cocon-Regular", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Account";
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.createUserPage.ResumeLayout(false);
            this.createUserPage.PerformLayout();
            this.changePasswordPage.ResumeLayout(false);
            this.changePasswordPage.PerformLayout();
            this.enableAccountPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelManageProducts;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage createUserPage;
        private MetroFramework.Controls.MetroTabPage changePasswordPage;
        private MetroFramework.Controls.MetroTabPage enableAccountPage;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboRole;
        public System.Windows.Forms.Button btnAccCancel;
        public System.Windows.Forms.Button btnAccSave;
        private System.Windows.Forms.TextBox txtCurrentPwd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConfirmNewPwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserNChng;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnChngCancel;
        public System.Windows.Forms.Button btnChngSave;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
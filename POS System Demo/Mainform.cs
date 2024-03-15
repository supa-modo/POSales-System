using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;

namespace POS_System_Demo
{
    public partial class Mainform : Form
    {

        NpgsqlConnection cn = new NpgsqlConnection();
        NpgsqlCommand cm = new NpgsqlCommand();
        DBConnect dbcon = new DBConnect();
        public Mainform()
        {
            InitializeComponent();
            customizeDesign();
            cn = new NpgsqlConnection(dbcon.myConnection());
            cn.Open();
            MessageBox.Show("Database is Connected");
        }

        #region panelSlide
        private void customizeDesign()
        {
            panelSubProduct.Visible = false;
            panelSubRecord.Visible = false; 
            panelSubSetting.Visible = false;
            panelSubStock.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubProduct.Visible==true)
            {
                panelSubProduct.Visible = false;
            }
            if (panelSubRecord.Visible == true)
            {
                panelSubRecord.Visible = false;
            }
            if (panelSubSetting.Visible == true)
            {
                panelSubSetting.Visible = false;
            }
            if (panelSubStock.Visible == true)
            {
                panelSubStock.Visible = false;
            }
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }

            #endregion panelSlide
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSlide_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelRole_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            labelTitle.Text = childForm.Text;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {

        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubProduct);
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonBrand_Click(object sender, EventArgs e)
        {
            openChildForm(new Brand());
            hideSubMenu();
        }

        private void buttonProductList_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonInStock_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubStock);
        }

        private void buttonStockAdjustment_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonStockEntry_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubSetting);
        }

        private void buttonStore_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubRecord);
        }

        private void buttonPOSRecord_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonSaleHistory_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
 

        private void buttonLogout_Click(object sender, EventArgs e)
        {

        }
    }
}

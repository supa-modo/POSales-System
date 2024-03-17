using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_Demo
{
    public partial class BrandModule : Form
    {
        NpgsqlConnection cn = new NpgsqlConnection();
        NpgsqlCommand cm = new NpgsqlCommand();
        DBConnect dbcon = new DBConnect();
        Brand brand;
        public BrandModule(Brand br)
        {
            InitializeComponent();
            cn = new NpgsqlConnection(dbcon.myConnection());
            brand = br;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Inserting new brand to the brand table in the database
            try {

                if (MessageBox.Show("Are you sure you want to save this brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new NpgsqlCommand("INSERT INTO tbbrand(brand)VALUES(@brand)", cn);
                    cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been saved successfully.", "POS"); 
                    Clear();
                    brand.LoadBrand();
                }
            } 
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //Clearing the txtBrand field and resetting buttons
        public void Clear()
        {
            txtBrand.Clear();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            txtBrand.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //updating brand name
            if (MessageBox.Show("Confirm brand update", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new NpgsqlCommand("UPDATE tbbrand SET brand = @brand WHERE id ='" + labelId.Text + "'", cn);
                cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Brand has been updated successfully", "POS");
                Clear();
                this.Dispose();
            }
        }

        private void BrandModule_Load(object sender, EventArgs e)
        {

        }
    }
}

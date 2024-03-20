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
    public partial class SupplierModule : Form
    {
        NpgsqlConnection cn = new NpgsqlConnection();
        NpgsqlCommand cm = new NpgsqlCommand();
        DBConnect dbcon = new DBConnect();
        string sTitle = "Point of Sale_D";
        Supplier supplier;

        public SupplierModule(Supplier sp)
        {
            InitializeComponent();
            cn = new NpgsqlConnection(dbcon.myConnection());
            supplier = sp;
        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            txtSupplierName.Clear();
            txtAddress.Clear();
            txtContactPerson.Clear();
            txtPhone.Clear();
            txtphone2.Clear();
            txtEmail.Clear();
            

            txtSupplierName.Focus();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {// Saving to the Suppliers' table
                if (MessageBox.Show("Save this supplier?", "New Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new NpgsqlCommand("INSERT INTO tbsuppliers(supplier, address, contactPerson, telephone1, telephone2, email)VALUES (@supplier, @address, @contactPerson, @telephone1, @telephone2, @email)", cn);
                    cm.Parameters.AddWithValue("@supplier", txtSupplierName.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@contactPerson", txtContactPerson.Text);
                    cm.Parameters.AddWithValue("@telephone1", txtPhone.Text);
                    cm.Parameters.AddWithValue("@telephone2", txtphone2.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Supplier has been added successfully", sTitle);
                    Clear();
                    supplier.LoadSupplier();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, sTitle);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //Updating existing suppliers records
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirm product Update?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new NpgsqlCommand("UPDATE tbsuppliers SET supplier=@supplier, address=@address, contactPerson=@contactPerson, telephone1=@telephone1, telephone2=@telephone2 WHERE id = '" + labelId.Text +"'", cn);
                    cm.Parameters.AddWithValue("@id", labelId.Text);
                    cm.Parameters.AddWithValue("@supplier", txtSupplierName.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@contactPerson", txtContactPerson.Text);
                    cm.Parameters.AddWithValue("@telephone1", txtPhone.Text);
                    cm.Parameters.AddWithValue("@telephone2", txtphone2.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Supplier has been updated successfully", sTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, sTitle);
            }
        }
    }
}

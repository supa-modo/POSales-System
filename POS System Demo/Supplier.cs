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
    public partial class Supplier : Form
    {
        NpgsqlConnection cn = new NpgsqlConnection();
        NpgsqlCommand cm = new NpgsqlCommand();
        DBConnect dbcon = new DBConnect();
        NpgsqlDataReader dr;
        public Supplier()
        {
            InitializeComponent();
            cn = new NpgsqlConnection(dbcon.myConnection());
            LoadSupplier();
        }

        public void LoadSupplier()
        {
            int i = 0;
            dgvSupplier.Rows.Clear();
            cn.Open();
            cm = new NpgsqlCommand("SELECT * FROM tbsuppliers ", cn);
            
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvSupplier.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SupplierModule supplierForm = new SupplierModule(this);
            supplierForm.ShowDialog();

        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Editing and deleting products from the tbproducts table
            string colName = dgvSupplier.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                SupplierModule supplierModule = new SupplierModule(this);
                supplierModule.labelId.Text = dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
                supplierModule.txtSupplierName.Text = dgvSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
                supplierModule.txtAddress.Text = dgvSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
                supplierModule.txtContactPerson.Text = dgvSupplier.Rows[e.RowIndex].Cells[4].Value.ToString();
                supplierModule.txtPhone.Text = dgvSupplier.Rows[e.RowIndex].Cells[5].Value.ToString();
                supplierModule.txtphone2.Text = dgvSupplier.Rows[e.RowIndex].Cells[6].Value.ToString();
                supplierModule.txtEmail.Text = dgvSupplier.Rows[e.RowIndex].Cells[7].Value.ToString();

                supplierModule.btnSave.Enabled = false;
                supplierModule.btnUpdate.Enabled = true;
                supplierModule.ShowDialog();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Delete this supplier record?", "Delete Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new NpgsqlCommand("DELETE FROM tbsuppliers WHERE id = '" + dgvSupplier.Rows[e.RowIndex].Cells[1].Value + "'", cn);
                    dr = cm.ExecuteReader();
                    cn.Close();
                    MessageBox.Show("Supplier has been successfully removed.", "Point of Sale_D", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            LoadSupplier();
        }
    }
}

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
    public partial class Brand : Form
    {
        NpgsqlConnection cn = new NpgsqlConnection();
        NpgsqlCommand cm = new NpgsqlCommand();
        DBConnect dbcon = new DBConnect();
        NpgsqlDataReader dr;
        public Brand()
        {
            InitializeComponent();
            cn = new NpgsqlConnection(dbcon.myConnection());
            LoadBrand();
        }

        //Retrieving data from tbbrand to dgvbrand 
        public void LoadBrand()
        {
            int i = 0;
            dgvBrand.Rows.Clear();
            cn.Open();
            cm = new NpgsqlCommand("SELECT * FROM tbbrand ORDER BY brand", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvBrand.Rows.Add(i, dr["id"].ToString(), dr["brand"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void Brand_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            BrandModule moduleForm = new BrandModule(this);
            moduleForm.ShowDialog();
        }

        private void dgvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Updating and Deleting column records
            string columnName = dgvBrand.Columns[e.ColumnIndex].Name;
            if (columnName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new NpgsqlCommand("DELETE FROM tbbrand WHERE id LIKE '"+ dgvBrand[1, e.RowIndex].Value.ToString() + "'", cn);
                    cn.Close() ;
                    MessageBox.Show("Brand has been successfully deleted.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //Parameterized Approach
                //if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //{
                //    // Assuming cn is your NpgsqlConnection object
                //    cn.Open();

                //    // Create a parameterized query to delete the record
                //    string sql = "DELETE FROM tbbrand WHERE id = @id";

                //    // Assuming dgvBrand is your DataGridView object
                //    NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);

                //    // Assuming e.RowIndex is the index of the row you want to delete
                //    cmd.Parameters.AddWithValue("@id", dgvBrand[1, e.RowIndex].Value);

                //    // Execute the query
                //    cmd.ExecuteNonQuery();

                //    // Close the connection
                //    cn.Close();
                //}

            }
            else if (columnName == "Edit")
            {
                BrandModule brandModule = new BrandModule(this);
                brandModule.labelId.Text = dgvBrand[1, e.RowIndex].Value.ToString();
                brandModule.txtBrand.Text = dgvBrand[2, e.RowIndex].Value.ToString();
                brandModule.btnSave.Enabled = false;
                brandModule.btnUpdate.Enabled = true;
                brandModule.ShowDialog();
            }
            LoadBrand();
        }
    }
}

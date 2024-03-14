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
            if (columnName == "Edit")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new NpgsqlCommand("DELETE FROM tbbrand WHERE id LIKE '"+ dgvBrand[1, e.RowIndex].Value.ToString() + "'", cn);
                    cn.Close() ;
                }
            }
        }
    }
}

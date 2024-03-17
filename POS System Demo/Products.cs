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
    public partial class Products : Form
    {
        NpgsqlConnection cn = new NpgsqlConnection();
        NpgsqlCommand cm = new NpgsqlCommand();
        DBConnect dbcon = new DBConnect();
        NpgsqlDataReader dr;
        public Products()
        {
            InitializeComponent();
            cn = new NpgsqlConnection(dbcon.myConnection());
            LoadProducts();
        }

        public void LoadProducts()
        {
            int i = 0;
            dgvProducts.Rows.Clear();
            cm = new NpgsqlCommand("SELECT p.productcode, p.barcode, p.pdescription, b.brand, c.category, p.price, p.reorder FROM tbproducts AS p INNER JOIN tbbrand AS b ON b.id = p.bid INNER JOIN tbcategory AS c ON c.id = p.cid ", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProducts.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductModule productModule = new ProductModule(this);

            productModule.ShowDialog();
        }
    }
}

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
            NpgsqlParameter txtSearchParam = new NpgsqlParameter("@txtSearch", txtSearch.Text);

            cm = new NpgsqlCommand("SELECT p.productcode, p.barcode, p.pdescription, b.brand, c.category, p.price, p.reorder FROM tbproducts AS p INNER JOIN tbbrand AS b ON b.id = p.bid INNER JOIN tbcategory AS c ON c.id = p.cid WHERE (p.pdescription ILIKE '%'|| @txtSearch ||'%') OR (b.brand ILIKE '%'|| @txtSearch ||'%') OR (c.category ILIKE '%'|| @txtSearch ||'%');", cn);

            cm.Parameters.Add(txtSearchParam);

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

        /*        public void LoadProducts()
                {
                    int i = 0;
                    dgvProducts.Rows.Clear();

                    // Assuming txtSearch.Text contains the search query entered by the user
                    string searchQuery = "%" + txtSearch.Text + "%";

                    using (NpgsqlConnection cn = new NpgsqlConnection(dbcon.myConnection()))
                    {
                        using (NpgsqlCommand cm = new NpgsqlCommand("SELECT p.productcode, p.barcode, p.pdescription, b.brand, c.category, p.price, p.reorder FROM tbproducts AS p INNER JOIN tbbrand AS b ON b.id = p.bid INNER JOIN tbcategory AS c ON c.id = p.cid WHERE CONCAT(p.pdescription, b.brand, c.category) ILIKE @searchQuery", cn))
                        {
                            cm.Parameters.AddWithValue("@searchQuery", searchQuery);

                            cn.Open();

                            using (NpgsqlDataReader dr = cm.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    i++;
                                    dgvProducts.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
                                }
                            }
                        }
                    }
                }*/


        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductModule productModule = new ProductModule(this);

            productModule.ShowDialog();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Editing and deleting products from the tbproducts table
            string colName = dgvProducts.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ProductModule product = new ProductModule(this);
                product.txtProductCode.Text = dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                product.txtBarCode.Text = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                product.txtDescription.Text = dgvProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
                product.comboBxBrand.Text = dgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
                product.comboBxCategory.Text = dgvProducts.Rows[e.RowIndex].Cells[5].Value.ToString();
                product.txtBoxPrice.Text = dgvProducts.Rows[e.RowIndex].Cells[6].Value.ToString(); 
                product.numericUpDnReorder.Value = int.Parse(dgvProducts.Rows[e.RowIndex].Cells[7].Value.ToString());

                product.txtProductCode.Enabled = false;
                product.btnSave.Enabled = false;
                product.btnUpdate.Enabled = true;
                product.ShowDialog();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Delete this record?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new NpgsqlCommand("DELETE FROM tbproducts WHERE productcode LIKE '" + dgvProducts[1, e.RowIndex].Value + "'", cn);
                    dr = cm.ExecuteReader();
                    cn.Close();
                    MessageBox.Show("Product has been successfully deleted.", "Point of Sale_D", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            LoadProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}

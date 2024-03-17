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
    public partial class ProductModule : Form
    {
        NpgsqlConnection cn = new NpgsqlConnection();
        NpgsqlCommand cm = new NpgsqlCommand();
        DBConnect dbcon = new DBConnect();
        String sTitle = "Point of Sale_D";
        Products product;

        public ProductModule(Products pd)
        {
            InitializeComponent();
            cn = new NpgsqlConnection(dbcon.myConnection());
            LoadBrand();
            LoadCategory();
            product = pd;
        }

        public void LoadCategory()
        {
            comboBxCategory.Items.Clear();
            comboBxCategory.DataSource = dbcon.getTable("SELECT * FROM tbcategory");
            comboBxCategory.DisplayMember = "category";
            comboBxCategory.ValueMember = "id";
        }

        public void LoadBrand()
        {
            comboBxBrand.Items.Clear();
            comboBxBrand.DataSource = dbcon.getTable("SELECT * FROM tbbrand");
            comboBxBrand.DisplayMember = "brand";
            comboBxBrand.ValueMember = "id";
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear() {
            txtBarCode.Clear();
            txtBoxPrice.Clear();
            txtDescription.Clear();
            txtProductCode.Clear();
            comboBxBrand.SelectedIndex = 0;
            comboBxCategory.SelectedIndex = 0;
            numericUpDnReorder.Value = 1;

            txtProductCode.Focus();
            txtProductCode.Enabled = true;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;

        }


        //Saving new product to database product table when save is clicked
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {// Saving to the product table
                if (MessageBox.Show("Are you sure you want to save this product?", "Save Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new NpgsqlCommand("INSERT INTO tbproducts(productcode, barcode, pdescription, bid, cid, price, reorder)VALUES (@productcode, @barcode, @pdescription, @bid, @cid, @price, @reorder)", cn);
                    cm.Parameters.AddWithValue("@productcode", txtProductCode.Text);
                    cm.Parameters.AddWithValue("@barcode", txtBarCode.Text);
                    cm.Parameters.AddWithValue("@pdescription", txtDescription.Text);
                    cm.Parameters.AddWithValue("@bid", comboBxBrand.SelectedValue);
                    cm.Parameters.AddWithValue("@cid", comboBxCategory.SelectedValue);
                    cm.Parameters.AddWithValue("@price", double.Parse(txtBoxPrice.Text));
                    cm.Parameters.AddWithValue("@reorder", numericUpDnReorder.Value);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been added successfully", sTitle);
                    Clear();
                    product.LoadProducts();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirm product Update?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new NpgsqlCommand("UPDATE tbproducts SET barcode=@barcode, pdescription=@pdescription, bid=@bid, cid=@cid, price=@price, reorder=@reorder WHERE productcode LIKE @productcode", cn);
                    cm.Parameters.AddWithValue("@productcode", txtProductCode.Text);
                    cm.Parameters.AddWithValue("@barcode", txtBarCode.Text);
                    cm.Parameters.AddWithValue("@pdescription", txtDescription.Text);
                    cm.Parameters.AddWithValue("@bid", comboBxBrand.SelectedValue);
                    cm.Parameters.AddWithValue("@cid", comboBxCategory.SelectedValue);
                    cm.Parameters.AddWithValue("@price", double.Parse(txtBoxPrice.Text));
                    cm.Parameters.AddWithValue("@reorder", numericUpDnReorder.Value);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been updated successfully", sTitle);
                    Clear();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

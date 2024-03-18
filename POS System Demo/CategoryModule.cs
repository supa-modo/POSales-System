using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_Demo
{
    public partial class CategoryModule : Form
    {
        NpgsqlConnection cn = new NpgsqlConnection();
        NpgsqlCommand cm = new NpgsqlCommand();
        DBConnect dbcon = new DBConnect();
        Category category;
        
        public CategoryModule(Category ct)
        {
            InitializeComponent();
            cn = new NpgsqlConnection(dbcon.myConnection());
            category = ct;
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Inserting new category to the category table in the database
            try
            {
                if (MessageBox.Show("Add new category?", "New Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new NpgsqlCommand("INSERT INTO tbcategory(category)VALUES(@category)", cn);
                    cm.Parameters.AddWithValue("category", txtCategory.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category has been added successfully.", "POS");
                    Clear();
                    category.LoadCategory();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Clearing the txtCategory and resetting buttons
        public void Clear()
        {
            txtCategory.Clear();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            txtCategory.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Updating a category name
            if(MessageBox.Show("Confirm Category update", "Update Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new NpgsqlCommand("UPDATE tbCategory SET category = @category WHERE id = '" + labelId.Text +"'", cn);
                cm.Parameters.AddWithValue("@category", txtCategory.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Category has been updated successfully", "POS");
                Clear();
                this.Dispose();
            }
        }

        
    }
}


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
    public partial class User : Form
    {
        NpgsqlConnection cn = new NpgsqlConnection();
        NpgsqlCommand cm = new NpgsqlCommand();
        DBConnect dbcon = new DBConnect();
        string sTitle = "Point of Sale_D";

        public User()
        {
            InitializeComponent();
            cn =new NpgsqlConnection(dbcon.myConnection());
        }

        public void Clear()
        {
            txtUsername.Clear();
            txtFullName.Clear();
            txtPassword.Clear();   
            txtConfirmPwd.Clear();
            comboRole.Text = "";
            txtUsername.Focus();
        }

        private void btnAccSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != txtConfirmPwd.Text)
                {
                    MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cn.Open();
                cm = new NpgsqlCommand("INSERT INTO tbusers(username, fullname, password, role)VALUES(@username, @fullname, @password, @role)", cn);
                cm.Parameters.AddWithValue("@username", txtUsername.Text); 
                cm.Parameters.AddWithValue("@fullname", txtFullName.Text);
                cm.Parameters.AddWithValue("@password", txtPassword.Text);
                cm.Parameters.AddWithValue("@role", comboRole.Text);
                
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("User Account has been created successfully", "New User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Warning");
                
            }
        }

        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            Clear();
            cn.Close();
        }
    }
}

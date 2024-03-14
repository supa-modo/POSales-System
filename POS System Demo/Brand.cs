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
        public Brand()
        {
            InitializeComponent();
            cn = new NpgsqlConnection(dbcon.myConnection());
        }

        private void Brand_Load(object sender, EventArgs e)
        {

        }
    }
}

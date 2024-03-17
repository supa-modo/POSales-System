using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace POS_System_Demo
{
    public class DBConnect
    {
        NpgsqlConnection cn = new NpgsqlConnection();
        NpgsqlCommand cm = new NpgsqlCommand();

        private string connString;
        public string myConnection()
        {
            connString = @"Host=localhost;Username=postgres;Password=spmod@24;Database=posale_db;Persist Security Info=True";
            return connString;
        }

        public DataTable getTable(String query)
        {
            cn.ConnectionString = myConnection();
            cm = new NpgsqlCommand(query, cn);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cm);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace POS_System_Demo
{
    public class DBConnect
    {
              
        private string connString;
        public string myConnection()
        {
            connString = @"Host=localhost;Username=postgres;Password=spmod@24;Database=posale_db;Persist Security Info=True";
            return connString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_Demo
{
    internal class DBConnect
    {
        private string connString;
        public string myConnection()
        {
            connString = @"Host=localhost;Username=postgres;Password=***********;Database=posale_db;Persist Security Info=True";
            return connString;
        }
    }
}

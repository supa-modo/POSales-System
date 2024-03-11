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
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Administrator\Documents\Sql Databases\POSale_DB.mdf"";Integrated Security=True;Connect Timeout=30";
            return connString;
        }
    }
}

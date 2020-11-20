using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using classLibary;

namespace classLibary
{
    public class connection_class
    {
        public MySqlConnection connectdb;
        public connection_class()
        {
            string connection_string = "Server=127.0.0.1;Port=3306;Database=geldautomaat;Uid=root;Pwd=;";
            connectdb = new MySqlConnection(connection_string);
        }

    }
}

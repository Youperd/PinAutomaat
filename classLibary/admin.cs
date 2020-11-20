using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using classLibary;

namespace classLibary
{
    public class admin : connection_class
    {

        public bool updateUser(string sql)
        {
            connectdb.Open();
            MySqlCommand cmd;
            cmd = new MySqlCommand(sql, connectdb);
            cmd.ExecuteNonQuery();
            connectdb.Close();
            return true;
        }

        public DataTable selectData(string sql)
        {
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            connectdb.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter(sql, connectdb);
            adapt.Fill(dt);
            connectdb.Close();

            return dt;
        }

        public bool blockUser(string sql)
        {
            connectdb.Open();
            MySqlCommand cmd;
            cmd = new MySqlCommand(sql, connectdb);
            cmd.ExecuteNonQuery();
            connectdb.Close();
            return true;
        }
    }
}

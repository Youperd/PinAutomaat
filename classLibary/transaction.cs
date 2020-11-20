using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;
using MySql.Data.MySqlClient;
using classLibary;

namespace classLibary
{
    public class transaction : connection_class
    {
        public string rekeningNummer { set; get; }
        public string transactions { set; get; }

        public void lastThreeTransactions(string rekeningnummer)
        {
            string datetime;
            string description;
            string quantity;
            connectdb.Open();
            MySqlDataReader rd;
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM transaction WHERE rekening_nummer=@rn ORDER BY datetime DESC LIMIT 3";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@rn", MySqlDbType.VarChar).Value = rekeningnummer;

                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    datetime = rd.GetDateTime("datetime").ToString();
                    description = rd.GetString("description");
                    if (rd.GetBoolean("plus_min") == true)
                    {
                        quantity = "€ +" + rd.GetDouble("quantity").ToString() + ",-";
                    }
                    else
                    {
                        quantity = "€ -" + rd.GetDouble("quantity").ToString() + ",-";
                    }

                    transactions = transactions + datetime + " " + description + " " + quantity + "\r\n";

                }
                connectdb.Close();
            }
        }

        public bool checkTransaction(string rekeningnummer)
        {
            Boolean check = false;
            connectdb.Open();
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT COUNT(*) FROM transaction WHERE rekening_nummer=@user AND plus_min=0 AND DATE(datetime) = CURDATE()";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = rekeningnummer;

                int countRows = Convert.ToInt32(cmd.ExecuteScalar());
                if (countRows < 3) check = true;
            }

            connectdb.Close();
            return check;
        }
    }
}

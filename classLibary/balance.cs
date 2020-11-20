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
    public class balance : connection_class
    {
        public string rekeningNummer { set; get; }
        public double balanceUser { set; get; }
        public string transactions { set; get; }

        public void returnBalance(string rekeningNummer)
        {
            connectdb.Open();
            MySqlDataReader rd;
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM balance WHERE rekening_nummer=@user";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = rekeningNummer;

                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    balanceUser = double.Parse(rd.GetString("balance"));
                }
                connectdb.Close();
            }            
        }

        public void addBalance(double oldBalance, double value, string rekeningnummer)
        {
            connectdb.Open();
            MySqlDataReader rd;
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE balance set balance=@newBalance where rekening_nummer=@rn";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@newBalance", MySqlDbType.VarChar).Value = oldBalance + value;
                cmd.Parameters.Add("@rn", MySqlDbType.VarChar).Value = rekeningnummer;

                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    balanceUser = double.Parse(rd.GetString("balance"));
                }
            }
            connectdb.Close();

            connectdb.Open();
            string query = "INSERT INTO transaction(rekening_nummer, description, quantity, plus_min) values(@us, @dc, @qu, @pm)";
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@us", MySqlDbType.VarChar).Value = rekeningnummer.ToString();
                cmd.Parameters.Add("@dc", MySqlDbType.VarChar).Value = "Geld gestort";
                cmd.Parameters.Add("@qu", MySqlDbType.VarChar).Value = value;
                cmd.Parameters.Add("@pm", MySqlDbType.VarChar).Value = 1;

                cmd.ExecuteNonQuery();
            }


            connectdb.Close();
        }

        public void withdrawBalance(double oldBalance, double value, string rekeningnummer) 
        {
            connectdb.Open();
            MySqlDataReader rd;
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE balance set balance=@newBalance where rekening_nummer=@rn";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@newBalance", MySqlDbType.VarChar).Value = oldBalance - value;
                cmd.Parameters.Add("@rn", MySqlDbType.VarChar).Value = rekeningnummer;

                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    balanceUser = double.Parse(rd.GetString("balance"));
                }
            }
            connectdb.Close();

            connectdb.Open();
            string query = "INSERT INTO transaction(rekening_nummer, description, quantity, plus_min) values(@us, @dc, @qu, @pm)";
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@us", MySqlDbType.VarChar).Value = rekeningnummer.ToString();
                cmd.Parameters.Add("@dc", MySqlDbType.VarChar).Value = "Geld opgenomen";
                cmd.Parameters.Add("@qu", MySqlDbType.VarChar).Value = value;
                cmd.Parameters.Add("@pm", MySqlDbType.VarChar).Value = 0;

                cmd.ExecuteNonQuery();
            }
            connectdb.Close();
        }

        public int checkBalance(double oldBalance)
        {
            int number = 0;

            if (oldBalance < 5)
            {
                number = 1;
            } else if (oldBalance < 10)
            {
                number = 2;
            } else if (oldBalance < 20)
            {
                number = 3;
            } else if (oldBalance < 50)
            {
                number = 4;
            } else if (oldBalance < 100)
            {
                number = 5;
            } else if (oldBalance < 200)
            {
                number = 6;
            } else if (oldBalance < 500)
            {
                number = 7;
            }
            return number;
        }
    }
}

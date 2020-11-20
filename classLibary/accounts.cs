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
    public class accounts : connection_class
    {
        public string rekeningNummer { set; get; }
        public string user_password { set; get; }
        public string user_fullname { set; get; }
        public bool is_admin { set; get; }
        public bool check_user { set; get; }

        public bool checkPassword()
        {
            // controleerd of de pincode juist is ingevoerd
            bool check = false;
            is_admin = false;
            
            connectdb.Open();
            MySqlDataReader rd;
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM account WHERE rekeningnummer=@rekening AND password=@pass AND blocked = false";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@rekening", MySqlDbType.VarChar).Value = rekeningNummer;
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = user_password.GetHashCode();
                cmd.Parameters.Add("@admin", MySqlDbType.VarChar).Value = true;
                


                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    check = true;
                    user_fullname = rd.GetString("name");
                    is_admin = rd.GetBoolean("admin");
                }
                connectdb.Close();
            }
            
            return check;
        }

        public void insertNewUser(string rekening, string pass, string name, string adres, string woonplaats, string email)
        {
            // controleerd eerst of de gebruiker al bestaat
            if (checkIfUserExcist(rekening, 0))
            {
                connectdb.Open();
                // hier wordt de gebruiker toegevoegd in de database
                string query = "INSERT INTO account(rekeningnummer, password, name, adres, woonplaats, email) values(@rn, @ps, @fn, @ad, @wp, @em)";
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connectdb;

                    cmd.Parameters.Add("@rn", MySqlDbType.VarChar).Value = rekening;
                    cmd.Parameters.Add("@ps", MySqlDbType.VarChar).Value = pass.GetHashCode();
                    cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@ad", MySqlDbType.VarChar).Value = adres;
                    cmd.Parameters.Add("@wp", MySqlDbType.VarChar).Value = woonplaats;
                    cmd.Parameters.Add("@em", MySqlDbType.VarChar).Value = email;
                    cmd.ExecuteNonQuery();
                }

                // maakt een rekening aan met als startbedrag 0 euro
                string queryBalance = "INSERT INTO balance(rekening_nummer, balance) values(@rn, 0)";
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = queryBalance;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connectdb;

                    cmd.Parameters.Add("@rn", MySqlDbType.VarChar).Value = rekening;

                    cmd.ExecuteNonQuery();
                }
                check_user = true;
                connectdb.Close();
            } else
            {
                check_user = false;
            }
        }

        public bool checkIfUserExcist(string newRekeningNummer, int accountId)
        {
            bool retVal = true;
            connectdb.Open();
            MySqlDataReader rd;
            using (var cmdCommand = new MySqlCommand())
            {
                cmdCommand.CommandText = "SELECT * FROM account WHERE rekeningnummer=@rekening";
                cmdCommand.CommandType = CommandType.Text;
                cmdCommand.Connection = connectdb;

                cmdCommand.Parameters.Add("@rekening", MySqlDbType.VarChar).Value = newRekeningNummer;

                rd = cmdCommand.ExecuteReader();
                while (rd.Read())
                {
                    if (rd.GetInt16("user_id") == accountId)
                    {
                        retVal = true;
                    } else
                    {
                        retVal = false;
                    }
                }
                rd.Close();
            }
            connectdb.Close();
            return retVal;
        }
    }
}

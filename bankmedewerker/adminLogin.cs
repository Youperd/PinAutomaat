using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using classLibary;

namespace bankmedewerker
{
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            accounts acct = new accounts();
            acct.rekeningNummer = txbRekeningNummer.Text;
            string pincode = txbPincode.Text;
            acct.user_password = pincode;
            bool verify = acct.checkPassword();

            if (verify)
            {
                if (acct.is_admin == true)
                {
                    this.Hide();
                    changeUser adminPage = new changeUser();
                    adminPage.ShowDialog();
                }
                else
                {
                    MessageBox.Show("U heeft niet de rechten om als admin in te mogen loggen!");
                }
            }
            else
            {
                MessageBox.Show("Uw pincode en/of rekeningnummer zijn onjuist!");
            }
        }

        private void txbPincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // hier mogen alleen cijfers in komen te staan
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}

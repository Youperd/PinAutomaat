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

namespace geldautomaat
{
    public partial class Login : Form
    {
        accounts acct = new accounts();

        public Login()
        {
            InitializeComponent();
            
        }


        private void btnInloggen_Click(object sender, EventArgs e)
        {
            // controleerd het rekeningnummer en pincode
            acct.rekeningNummer = txbRekeningNummer.Text;
            string pincode = txbPincode.Text;
            acct.user_password = pincode;
            bool verify = acct.checkPassword();
            

            // als de gegevens goed zijn gaat hij naar home.cs anders krijgt de gebruiker een melding dat de inloggegevens onjuist zijn
            if (verify)
            {
                this.Hide();
                home goToHome = new home(txbRekeningNummer.Text);
                goToHome.ShowDialog();
            } else
            {
                MessageBox.Show("De combinatie tussen uw rekeningnummer en pincode is onjuist! Of uw account is geblokkeerd");
            }
        }

        private void txbPincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // alleen cijfers in deze textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void lblTextInloggen_Click(object sender, EventArgs e)
        {

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void pnlCenter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

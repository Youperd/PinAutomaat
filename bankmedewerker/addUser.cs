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
    public partial class addUser : Form
    {
        accounts acct = new accounts();
        public addUser()
        {
            InitializeComponent();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            // checkt of de 2 wachtwoorden hetzelfde zijn
            if (txbNewPincode.Text == txbRePincode.Text)
            {
                // roept functie aan om nieuwe gebruiker toe te voegen
                acct.insertNewUser(txbNewRekeningNummer.Text, txbNewPincode.Text, txbNewName.Text, txbAdres.Text, txbWoonplaats.Text, txbEmail.Text);
                if (acct.check_user == true)
                {
                    MessageBox.Show("Gebruiker " + txbNewName.Text + " is aangemeld!");
                    adminHome home = new adminHome();
                    this.Hide();
                    home.Show();
                } else
                {
                    MessageBox.Show("De rekeningnummer die u ingevuld heeft is al gebruikt probeer het nog eens!");
                }
            }
            else
            {
                MessageBox.Show("De 2 ingevulde wachtwoorden komen niet overeen");
            }
        }

        private void txbRePincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // alleen cijfers in deze textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txbNewPincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // alleen cijfers in deze textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnGoToHome_Click(object sender, EventArgs e)
        {
            // gaat naar home pagina van de admins
            this.Hide();
            changeUser goToHome = new changeUser();
            goToHome.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitleNewUser_Click(object sender, EventArgs e)
        {

        }
    }
}
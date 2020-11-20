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
    public partial class depoMoney : Form
    {
        balance bal = new balance();
        string rekeningnummer;
        double oldBal;

        public depoMoney(string rekeningNummer, double oldBalance)
        {
            InitializeComponent();
            rekeningnummer = rekeningNummer;
            oldBal = oldBalance;
           
        }

        private void txbDepoMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnDepoMoney_Click(object sender, EventArgs e)
        {
            bal.addBalance(oldBal, double.Parse(txbDepoMoney.Text), rekeningnummer);
            this.Hide();
            home goToHome = new home(rekeningnummer);
            goToHome.ShowDialog();
        }

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            home goToHome = new home(rekeningnummer);
            goToHome.ShowDialog();
        }

        private void lblTextCenter_Click(object sender, EventArgs e)
        {

        }
    }
}

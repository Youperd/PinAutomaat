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
    public partial class withMoney : Form
    {
        balance bal = new balance();

        public string rekeningnummer;
        public double oldBalance;
        public double newBalance;

        public withMoney(string rekeningNummer, double old_balance)
        {
            InitializeComponent();
            rekeningnummer = rekeningNummer;
            oldBalance = old_balance;
            bal.checkBalance(oldBalance);
            switchBalance();
        }

        private void backToHome()
        {
            this.Hide();
            home goToHome = new home(rekeningnummer);
            goToHome.ShowDialog();
            
        }

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            backToHome();
        }

        private void btnFiveEuro_Click(object sender, EventArgs e)
        {
            bal.withdrawBalance(oldBalance, 5, rekeningnummer);
            backToHome();
        }

        private void btnTenEuro_Click(object sender, EventArgs e)
        {
            bal.withdrawBalance(oldBalance, 10, rekeningnummer);
            backToHome();
        }

        private void btnTwentyEuro_Click(object sender, EventArgs e)
        {
            bal.withdrawBalance(oldBalance, 20, rekeningnummer);
            backToHome();
        }

        private void btnFiftyEuro_Click(object sender, EventArgs e)
        {
            bal.withdrawBalance(oldBalance, 50, rekeningnummer);
            backToHome();
        }

        private void btnHundredEuro_Click(object sender, EventArgs e)
        {
            bal.withdrawBalance(oldBalance, 100, rekeningnummer);
            backToHome();
        }

        private void btnTwohundredEuro_Click(object sender, EventArgs e)
        {
            bal.withdrawBalance(oldBalance, 200, rekeningnummer);
            backToHome();
        }

        private void btnFivehundredEuro_Click(object sender, EventArgs e)
        {
            bal.withdrawBalance(oldBalance, 500, rekeningnummer);
            backToHome();
        }

        private void switchBalance() {
            switch (bal.checkBalance(oldBalance))
            {
                case 2:
                    btnFiveEuro.Enabled = true;
                    break;
                case 3:
                    btnFiveEuro.Enabled = true;
                    btnTenEuro.Enabled = true;
                    break;
                case 4:
                    btnFiveEuro.Enabled = true;
                    btnTenEuro.Enabled = true;
                    btnTwentyEuro.Enabled = true;
                    break;
                case 5:
                    btnFiveEuro.Enabled = true;
                    btnTenEuro.Enabled = true;
                    btnTwentyEuro.Enabled = true;
                    btnFiftyEuro.Enabled = true;
                    break;
                case 6:
                    btnFiveEuro.Enabled = true;
                    btnTenEuro.Enabled = true;
                    btnTwentyEuro.Enabled = true;
                    btnFiftyEuro.Enabled = true;
                    btnHundredEuro.Enabled = true;
                    break;
                case 7:
                    btnFiveEuro.Enabled = true;
                    btnTenEuro.Enabled = true;
                    btnTwentyEuro.Enabled = true;
                    btnFiftyEuro.Enabled = true;
                    btnHundredEuro.Enabled = true;
                    btnTwohundredEuro.Enabled = true;
                    break;
                default:
                    btnFiveEuro.Enabled = true;
                    btnTenEuro.Enabled = true;
                    btnTwentyEuro.Enabled = true;
                    btnFiftyEuro.Enabled = true;
                    btnHundredEuro.Enabled = true;
                    btnTwohundredEuro.Enabled = true;
                    btnFivehundredEuro.Enabled = true;
                    break;
            }
        }

        private void withMoney_Load(object sender, EventArgs e)
        {

        }

        private void lblEuro100_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

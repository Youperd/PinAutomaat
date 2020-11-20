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
    public partial class home : Form
    {
        balance bal = new balance();
        transaction tr = new transaction();
        
        public string rekeningNummer;

        public home(string rekening_nummer)
        {
            InitializeComponent();
            rekeningNummer = rekening_nummer;
        
        }

        private void home_Load(object sender, EventArgs e)
        {
            bal.returnBalance(rekeningNummer);
            lblShowBalance.Text = "Uw saldo: € " + bal.balanceUser;
            if (tr.checkTransaction(rekeningNummer))
            {
                btnWithdrawBalance.Enabled = true;
            }
            else
            {
                btnWithdrawBalance.Enabled = false;
            }
            tr.lastThreeTransactions(rekeningNummer);
            lblLastThreeTransaction.Text = "Uw laatste 3 transacties:\r\n" + tr.transactions;
        }

        private void btnDepositMoney_Click(object sender, EventArgs e)
        {
            this.Hide();
            depoMoney depositMoney = new depoMoney(rekeningNummer, bal.balanceUser);
            depositMoney.ShowDialog();
        }

        private void btnWithdrawBalance_Click(object sender, EventArgs e)
        {
            this.Hide();
            withMoney withdrawMoney = new withMoney(rekeningNummer, bal.balanceUser);
            withdrawMoney.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login goToLogin = new Login();
            goToLogin.ShowDialog();
        }
    }
}

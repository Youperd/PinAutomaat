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
    public partial class changeUser : Form
    {
        admin adminFunction = new admin();
        accounts acct = new accounts();
        connection_class con = new connection_class();
        public int account_id;

        public changeUser()
        {
            InitializeComponent();
            showData();

            // zet de knoppen automatisch uit
            btnDeleteUser.Enabled = false;
            btnUpdateUser.Enabled = false;
        }

        private void dgvAllUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDeleteUser.Enabled = true;
            btnUpdateUser.Enabled = true;

            insertDataGrid(sender, e);
        }
        
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            //con.connectdb.Close();
            if (acct.checkIfUserExcist(txbRekeningNummer.Text, account_id) == true)
            {
                int adminValue = 0;
                int geblokkeerd = 0;
                if (cbAdmin.Checked == true) adminValue = 1;
                if (cbBlocked.Checked == true) geblokkeerd = 1;

                if (adminFunction.updateUser("UPDATE account SET rekeningnummer='" + txbRekeningNummer.Text + "', admin='" + adminValue + "', name='" + txbName.Text + "', adres='" + txbAdres.Text + "', woonplaats='" + txbWoonplaats.Text + "', email='" + txbEmail.Text + "', blocked='" + geblokkeerd + "' WHERE user_id='" + account_id.ToString() + "'"))
                {
                    showData();
                    clearTextBox();
                    MessageBox.Show("De gegevens van " + txbName.Text + " is succesvol gewijzigd");
                }
            }
            else
            {
                MessageBox.Show("De rekeningnummer die u ingevuld heeft is al gebruikt probeer een ander rekeningnummer!");
            }
        }

        private void showData()
        {
            dgvAllUsers.DataSource = adminFunction.selectData("SELECT * FROM account");
        }

        private void clearTextBox()
        {
            txbRekeningNummer.Text = "";
            txbName.Text = "";
            cbAdmin.Checked = false;
            txbAdres.Text = "";
            txbWoonplaats.Text = "";
            txbEmail.Text = "";
        }

        private void insertDataGrid(object sender, DataGridViewCellMouseEventArgs e)
        {
            account_id = int.Parse(dgvAllUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
            txbRekeningNummer.Text = dgvAllUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
            txbName.Text = dgvAllUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbAdmin.Checked = bool.Parse(dgvAllUsers.Rows[e.RowIndex].Cells[4].Value.ToString());
            cbBlocked.Checked = bool.Parse(dgvAllUsers.Rows[e.RowIndex].Cells[9].Value.ToString());
            txbAdres.Text = dgvAllUsers.Rows[e.RowIndex].Cells[5].Value.ToString();
            txbWoonplaats.Text = dgvAllUsers.Rows[e.RowIndex].Cells[6].Value.ToString();
            txbEmail.Text = dgvAllUsers.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvAllUsers.DataSource = adminFunction.selectData("SELECT * FROM `account` WHERE `rekeningnummer` OR `name` LIKE '%" + txbSearchOnName.Text + "%'");
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            adminFunction.blockUser("UPDATE account SET blocked = true WHERE user_id = " + account_id.ToString());
            dgvAllUsers.DataSource = adminFunction.selectData("SELECT * FROM account");
            clearTextBox();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            addUser add = new addUser();
            this.Hide();
            add.ShowDialog();
        }

        private void changeUser_Load(object sender, EventArgs e)
        {

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblWoonplaats_Click(object sender, EventArgs e)
        {

        }

        private void lblAdres_Click(object sender, EventArgs e)
        {

        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {

        }

        private void lblNaam_Click(object sender, EventArgs e)
        {

        }

        private void lblRekeningnummer_Click(object sender, EventArgs e)
        {

        }

        private void cbAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txbWoonplaats_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbRekeningNummer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
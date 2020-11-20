using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankmedewerker
{
    public partial class adminHome : Form
    {
        public adminHome()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // gaat naar pagina waar gebruikers kunnen worden toegevoegd
            addUser add = new addUser();
            this.Hide();
            add.ShowDialog();
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            // gaat naar pagina waar gebruikers gegevens aangepast kunnen worden
            this.Hide();
            changeUser change_user = new changeUser();
            change_user.ShowDialog();
        }
    }
}

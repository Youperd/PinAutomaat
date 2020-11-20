namespace bankmedewerker
{
    partial class changeUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAllUsers = new System.Windows.Forms.DataGridView();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.txbRekeningNummer = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbAdres = new System.Windows.Forms.TextBox();
            this.txbWoonplaats = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.lblRekeningnummer = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblWoonplaats = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbSearchOnName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblBlocked = new System.Windows.Forms.Label();
            this.cbBlocked = new System.Windows.Forms.CheckBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllUsers.Location = new System.Drawing.Point(485, 155);
            this.dgvAllUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.RowHeadersWidth = 51;
            this.dgvAllUsers.Size = new System.Drawing.Size(1477, 323);
            this.dgvAllUsers.TabIndex = 0;
            this.dgvAllUsers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAllUsers_RowHeaderMouseClick);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.Location = new System.Drawing.Point(1679, 494);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(241, 92);
            this.btnUpdateUser.TabIndex = 2;
            this.btnUpdateUser.Text = "Gegevens bijwerken";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(1721, 1066);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(241, 92);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Gebruiker blokkeren\r\n";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // txbRekeningNummer
            // 
            this.txbRekeningNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRekeningNummer.Location = new System.Drawing.Point(923, 486);
            this.txbRekeningNummer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbRekeningNummer.Name = "txbRekeningNummer";
            this.txbRekeningNummer.Size = new System.Drawing.Size(713, 55);
            this.txbRekeningNummer.TabIndex = 4;
            this.txbRekeningNummer.TextChanged += new System.EventHandler(this.txbRekeningNummer_TextChanged);
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(923, 571);
            this.txbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(713, 55);
            this.txbName.TabIndex = 5;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            // 
            // txbAdres
            // 
            this.txbAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAdres.Location = new System.Drawing.Point(923, 750);
            this.txbAdres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbAdres.Name = "txbAdres";
            this.txbAdres.Size = new System.Drawing.Size(713, 55);
            this.txbAdres.TabIndex = 7;
            this.txbAdres.TextChanged += new System.EventHandler(this.txbAdres_TextChanged);
            // 
            // txbWoonplaats
            // 
            this.txbWoonplaats.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbWoonplaats.Location = new System.Drawing.Point(923, 831);
            this.txbWoonplaats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbWoonplaats.Name = "txbWoonplaats";
            this.txbWoonplaats.Size = new System.Drawing.Size(713, 55);
            this.txbWoonplaats.TabIndex = 8;
            this.txbWoonplaats.TextChanged += new System.EventHandler(this.txbWoonplaats_TextChanged);
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(923, 911);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(713, 55);
            this.txbEmail.TabIndex = 9;
            this.txbEmail.TextChanged += new System.EventHandler(this.txbEmail_TextChanged);
            // 
            // cbAdmin
            // 
            this.cbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdmin.Location = new System.Drawing.Point(923, 656);
            this.cbAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(80, 76);
            this.cbAdmin.TabIndex = 10;
            this.cbAdmin.UseVisualStyleBackColor = true;
            this.cbAdmin.CheckedChanged += new System.EventHandler(this.cbAdmin_CheckedChanged);
            // 
            // lblRekeningnummer
            // 
            this.lblRekeningnummer.AutoSize = true;
            this.lblRekeningnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRekeningnummer.Location = new System.Drawing.Point(476, 494);
            this.lblRekeningnummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRekeningnummer.Name = "lblRekeningnummer";
            this.lblRekeningnummer.Size = new System.Drawing.Size(349, 48);
            this.lblRekeningnummer.TabIndex = 11;
            this.lblRekeningnummer.Text = "Rekeningnummer";
            this.lblRekeningnummer.Click += new System.EventHandler(this.lblRekeningnummer_Click);
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(476, 575);
            this.lblNaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(131, 48);
            this.lblNaam.TabIndex = 12;
            this.lblNaam.Text = "Naam";
            this.lblNaam.Click += new System.EventHandler(this.lblNaam_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(476, 665);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(139, 48);
            this.lblAdmin.TabIndex = 13;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdres.Location = new System.Drawing.Point(476, 753);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(129, 48);
            this.lblAdres.TabIndex = 14;
            this.lblAdres.Text = "Adres";
            this.lblAdres.Click += new System.EventHandler(this.lblAdres_Click);
            // 
            // lblWoonplaats
            // 
            this.lblWoonplaats.AutoSize = true;
            this.lblWoonplaats.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWoonplaats.Location = new System.Drawing.Point(476, 834);
            this.lblWoonplaats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWoonplaats.Name = "lblWoonplaats";
            this.lblWoonplaats.Size = new System.Drawing.Size(241, 48);
            this.lblWoonplaats.TabIndex = 15;
            this.lblWoonplaats.Text = "Woonplaats";
            this.lblWoonplaats.Click += new System.EventHandler(this.lblWoonplaats_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(476, 914);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(241, 48);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email adres";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txbSearchOnName
            // 
            this.txbSearchOnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchOnName.Location = new System.Drawing.Point(485, 41);
            this.txbSearchOnName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSearchOnName.Name = "txbSearchOnName";
            this.txbSearchOnName.Size = new System.Drawing.Size(1092, 92);
            this.txbSearchOnName.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1613, 41);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(349, 92);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Zoeken op naam of rekeningnummer";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblBlocked
            // 
            this.lblBlocked.AutoSize = true;
            this.lblBlocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlocked.Location = new System.Drawing.Point(1291, 665);
            this.lblBlocked.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlocked.Name = "lblBlocked";
            this.lblBlocked.Size = new System.Drawing.Size(257, 48);
            this.lblBlocked.TabIndex = 20;
            this.lblBlocked.Text = "Geblokkeerd";
            // 
            // cbBlocked
            // 
            this.cbBlocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBlocked.Location = new System.Drawing.Point(1613, 656);
            this.cbBlocked.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBlocked.Name = "cbBlocked";
            this.cbBlocked.Size = new System.Drawing.Size(80, 76);
            this.cbBlocked.TabIndex = 19;
            this.cbBlocked.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(72, 41);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(329, 92);
            this.btnAddUser.TabIndex = 21;
            this.btnAddUser.Text = "Gebruiker toevoegen";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // changeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblBlocked);
            this.Controls.Add(this.cbBlocked);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbSearchOnName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblWoonplaats);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblRekeningnummer);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbWoonplaats);
            this.Controls.Add(this.txbAdres);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbRekeningNummer);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.dgvAllUsers);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "changeUser";
            this.Text = "changeUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.changeUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllUsers;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TextBox txbRekeningNummer;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbAdres;
        private System.Windows.Forms.TextBox txbWoonplaats;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.Label lblRekeningnummer;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblWoonplaats;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbSearchOnName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBlocked;
        private System.Windows.Forms.CheckBox cbBlocked;
        private System.Windows.Forms.Button btnAddUser;
    }
}
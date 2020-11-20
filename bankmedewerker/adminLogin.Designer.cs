namespace bankmedewerker
{
    partial class adminLogin
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
            this.btnInloggen = new System.Windows.Forms.Button();
            this.txbRekeningNummer = new System.Windows.Forms.TextBox();
            this.txbPincode = new System.Windows.Forms.TextBox();
            this.lblPincode = new System.Windows.Forms.Label();
            this.lblRekeningNummer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInloggen
            // 
            this.btnInloggen.Location = new System.Drawing.Point(1007, 574);
            this.btnInloggen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(359, 85);
            this.btnInloggen.TabIndex = 0;
            this.btnInloggen.Text = "Inloggen";
            this.btnInloggen.UseVisualStyleBackColor = true;
            this.btnInloggen.Click += new System.EventHandler(this.btnInloggen_Click);
            // 
            // txbRekeningNummer
            // 
            this.txbRekeningNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRekeningNummer.Location = new System.Drawing.Point(925, 256);
            this.txbRekeningNummer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbRekeningNummer.Name = "txbRekeningNummer";
            this.txbRekeningNummer.Size = new System.Drawing.Size(567, 64);
            this.txbRekeningNummer.TabIndex = 2;
            // 
            // txbPincode
            // 
            this.txbPincode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPincode.Location = new System.Drawing.Point(1007, 458);
            this.txbPincode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPincode.MaxLength = 4;
            this.txbPincode.Multiline = true;
            this.txbPincode.Name = "txbPincode";
            this.txbPincode.PasswordChar = '•';
            this.txbPincode.Size = new System.Drawing.Size(357, 70);
            this.txbPincode.TabIndex = 4;
            this.txbPincode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPincode_KeyPress);
            // 
            // lblPincode
            // 
            this.lblPincode.AutoSize = true;
            this.lblPincode.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPincode.Location = new System.Drawing.Point(1031, 373);
            this.lblPincode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPincode.Name = "lblPincode";
            this.lblPincode.Size = new System.Drawing.Size(286, 58);
            this.lblPincode.TabIndex = 5;
            this.lblPincode.Text = "Uw pincode";
            // 
            // lblRekeningNummer
            // 
            this.lblRekeningNummer.AutoSize = true;
            this.lblRekeningNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRekeningNummer.Location = new System.Drawing.Point(940, 177);
            this.lblRekeningNummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRekeningNummer.Name = "lblRekeningNummer";
            this.lblRekeningNummer.Size = new System.Drawing.Size(507, 58);
            this.lblRekeningNummer.TabIndex = 6;
            this.lblRekeningNummer.Text = "Uw Rekeningnummer";
            // 
            // adminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.lblRekeningNummer);
            this.Controls.Add(this.lblPincode);
            this.Controls.Add(this.txbPincode);
            this.Controls.Add(this.txbRekeningNummer);
            this.Controls.Add(this.btnInloggen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "adminLogin";
            this.Text = "Admin inloggen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInloggen;
        private System.Windows.Forms.TextBox txbRekeningNummer;
        private System.Windows.Forms.TextBox txbPincode;
        private System.Windows.Forms.Label lblPincode;
        private System.Windows.Forms.Label lblRekeningNummer;
    }
}
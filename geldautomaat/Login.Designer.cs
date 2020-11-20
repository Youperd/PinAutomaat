namespace geldautomaat
{
    partial class Login
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
            this.lblRekening = new System.Windows.Forms.Label();
            this.lblPincode = new System.Windows.Forms.Label();
            this.txbRekeningNummer = new System.Windows.Forms.TextBox();
            this.txbPincode = new System.Windows.Forms.TextBox();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.btnNotAFunction5 = new System.Windows.Forms.Button();
            this.btnNotAFunction6 = new System.Windows.Forms.Button();
            this.btnNotAFunction7 = new System.Windows.Forms.Button();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRekening
            // 
            this.lblRekening.AutoSize = true;
            this.lblRekening.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRekening.ForeColor = System.Drawing.Color.White;
            this.lblRekening.Location = new System.Drawing.Point(534, 204);
            this.lblRekening.Name = "lblRekening";
            this.lblRekening.Size = new System.Drawing.Size(518, 69);
            this.lblRekening.TabIndex = 0;
            this.lblRekening.Text = "Rekeningnummer:";
            // 
            // lblPincode
            // 
            this.lblPincode.AutoSize = true;
            this.lblPincode.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPincode.ForeColor = System.Drawing.Color.White;
            this.lblPincode.Location = new System.Drawing.Point(672, 497);
            this.lblPincode.Name = "lblPincode";
            this.lblPincode.Size = new System.Drawing.Size(263, 69);
            this.lblPincode.TabIndex = 1;
            this.lblPincode.Text = "Pincode:";
            // 
            // txbRekeningNummer
            // 
            this.txbRekeningNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRekeningNummer.Location = new System.Drawing.Point(382, 362);
            this.txbRekeningNummer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbRekeningNummer.Multiline = true;
            this.txbRekeningNummer.Name = "txbRekeningNummer";
            this.txbRekeningNummer.Size = new System.Drawing.Size(799, 48);
            this.txbRekeningNummer.TabIndex = 2;
            // 
            // txbPincode
            // 
            this.txbPincode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPincode.Location = new System.Drawing.Point(670, 626);
            this.txbPincode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPincode.MaxLength = 4;
            this.txbPincode.Multiline = true;
            this.txbPincode.Name = "txbPincode";
            this.txbPincode.PasswordChar = '•';
            this.txbPincode.Size = new System.Drawing.Size(265, 48);
            this.txbPincode.TabIndex = 3;
            this.txbPincode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPincode_KeyPress);
            // 
            // btnInloggen
            // 
            this.btnInloggen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(181)))), ((int)(((byte)(10)))));
            this.btnInloggen.FlatAppearance.BorderSize = 0;
            this.btnInloggen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInloggen.Location = new System.Drawing.Point(670, 726);
            this.btnInloggen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(265, 77);
            this.btnInloggen.TabIndex = 4;
            this.btnInloggen.Text = "Inloggen";
            this.btnInloggen.UseVisualStyleBackColor = false;
            this.btnInloggen.Click += new System.EventHandler(this.btnInloggen_Click);
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(102)))));
            this.pnlCenter.Controls.Add(this.lblRekening);
            this.pnlCenter.Controls.Add(this.lblPincode);
            this.pnlCenter.Controls.Add(this.txbRekeningNummer);
            this.pnlCenter.Controls.Add(this.txbPincode);
            this.pnlCenter.Controls.Add(this.btnInloggen);
            this.pnlCenter.Location = new System.Drawing.Point(20, 20);
            this.pnlCenter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1800, 900);
            this.pnlCenter.TabIndex = 8;
            this.pnlCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCenter_Paint);
            // 
            // btnNotAFunction5
            // 
            this.btnNotAFunction5.Enabled = false;
            this.btnNotAFunction5.FlatAppearance.BorderSize = 0;
            this.btnNotAFunction5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotAFunction5.Location = new System.Drawing.Point(2165, 470);
            this.btnNotAFunction5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNotAFunction5.Name = "btnNotAFunction5";
            this.btnNotAFunction5.Size = new System.Drawing.Size(160, 148);
            this.btnNotAFunction5.TabIndex = 14;
            this.btnNotAFunction5.UseVisualStyleBackColor = true;
            // 
            // btnNotAFunction6
            // 
            this.btnNotAFunction6.Enabled = false;
            this.btnNotAFunction6.FlatAppearance.BorderSize = 0;
            this.btnNotAFunction6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotAFunction6.Location = new System.Drawing.Point(2165, 716);
            this.btnNotAFunction6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNotAFunction6.Name = "btnNotAFunction6";
            this.btnNotAFunction6.Size = new System.Drawing.Size(160, 148);
            this.btnNotAFunction6.TabIndex = 13;
            this.btnNotAFunction6.UseVisualStyleBackColor = true;
            // 
            // btnNotAFunction7
            // 
            this.btnNotAFunction7.Enabled = false;
            this.btnNotAFunction7.FlatAppearance.BorderSize = 0;
            this.btnNotAFunction7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotAFunction7.Location = new System.Drawing.Point(2165, 962);
            this.btnNotAFunction7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNotAFunction7.Name = "btnNotAFunction7";
            this.btnNotAFunction7.Size = new System.Drawing.Size(160, 148);
            this.btnNotAFunction7.TabIndex = 12;
            this.btnNotAFunction7.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.btnNotAFunction5);
            this.Controls.Add(this.btnNotAFunction6);
            this.Controls.Add(this.btnNotAFunction7);
            this.Controls.Add(this.pnlCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Inloggen ABN";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRekening;
        private System.Windows.Forms.Label lblPincode;
        private System.Windows.Forms.TextBox txbRekeningNummer;
        private System.Windows.Forms.TextBox txbPincode;
        private System.Windows.Forms.Button btnInloggen;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Button btnNotAFunction5;
        private System.Windows.Forms.Button btnNotAFunction6;
        private System.Windows.Forms.Button btnNotAFunction7;
    }
}


namespace geldautomaat
{
    partial class home
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
            this.lblShowBalance = new System.Windows.Forms.Label();
            this.btnDepositMoney = new System.Windows.Forms.Button();
            this.btnWithdrawBalance = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblLastThreeTransaction = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.btnNotAFunction1 = new System.Windows.Forms.Button();
            this.btnNotAFunction2 = new System.Windows.Forms.Button();
            this.btnNotAFunction3 = new System.Windows.Forms.Button();
            this.btnNotAFunction4 = new System.Windows.Forms.Button();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblShowBalance
            // 
            this.lblShowBalance.AutoSize = true;
            this.lblShowBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowBalance.ForeColor = System.Drawing.Color.White;
            this.lblShowBalance.Location = new System.Drawing.Point(595, 46);
            this.lblShowBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShowBalance.Name = "lblShowBalance";
            this.lblShowBalance.Size = new System.Drawing.Size(288, 52);
            this.lblShowBalance.TabIndex = 0;
            this.lblShowBalance.Text = "Huidig saldo:";
            // 
            // btnDepositMoney
            // 
            this.btnDepositMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(181)))), ((int)(((byte)(10)))));
            this.btnDepositMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnDepositMoney.Location = new System.Drawing.Point(480, 533);
            this.btnDepositMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDepositMoney.Name = "btnDepositMoney";
            this.btnDepositMoney.Size = new System.Drawing.Size(529, 100);
            this.btnDepositMoney.TabIndex = 1;
            this.btnDepositMoney.Text = "Geld storten";
            this.btnDepositMoney.UseVisualStyleBackColor = false;
            this.btnDepositMoney.Click += new System.EventHandler(this.btnDepositMoney_Click);
            // 
            // btnWithdrawBalance
            // 
            this.btnWithdrawBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(181)))), ((int)(((byte)(10)))));
            this.btnWithdrawBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnWithdrawBalance.Location = new System.Drawing.Point(480, 404);
            this.btnWithdrawBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWithdrawBalance.Name = "btnWithdrawBalance";
            this.btnWithdrawBalance.Size = new System.Drawing.Size(529, 100);
            this.btnWithdrawBalance.TabIndex = 2;
            this.btnWithdrawBalance.Text = "Geld opnemen";
            this.btnWithdrawBalance.UseVisualStyleBackColor = false;
            this.btnWithdrawBalance.Click += new System.EventHandler(this.btnWithdrawBalance_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(181)))), ((int)(((byte)(10)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnLogout.Location = new System.Drawing.Point(480, 665);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(529, 100);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Afmelden";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblLastThreeTransaction
            // 
            this.lblLastThreeTransaction.AutoSize = true;
            this.lblLastThreeTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastThreeTransaction.ForeColor = System.Drawing.Color.White;
            this.lblLastThreeTransaction.Location = new System.Drawing.Point(524, 183);
            this.lblLastThreeTransaction.Name = "lblLastThreeTransaction";
            this.lblLastThreeTransaction.Size = new System.Drawing.Size(445, 52);
            this.lblLastThreeTransaction.TabIndex = 4;
            this.lblLastThreeTransaction.Text = "Laatste 3 transacties";
            this.lblLastThreeTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(102)))));
            this.pnlCenter.Controls.Add(this.lblLastThreeTransaction);
            this.pnlCenter.Controls.Add(this.lblShowBalance);
            this.pnlCenter.Controls.Add(this.btnWithdrawBalance);
            this.pnlCenter.Controls.Add(this.btnLogout);
            this.pnlCenter.Controls.Add(this.btnDepositMoney);
            this.pnlCenter.Location = new System.Drawing.Point(20, 20);
            this.pnlCenter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1600, 985);
            this.pnlCenter.TabIndex = 9;
            // 
            // btnNotAFunction1
            // 
            this.btnNotAFunction1.Enabled = false;
            this.btnNotAFunction1.FlatAppearance.BorderSize = 0;
            this.btnNotAFunction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotAFunction1.Location = new System.Drawing.Point(2165, 224);
            this.btnNotAFunction1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNotAFunction1.Name = "btnNotAFunction1";
            this.btnNotAFunction1.Size = new System.Drawing.Size(160, 148);
            this.btnNotAFunction1.TabIndex = 19;
            this.btnNotAFunction1.UseVisualStyleBackColor = true;
            // 
            // btnNotAFunction2
            // 
            this.btnNotAFunction2.Enabled = false;
            this.btnNotAFunction2.FlatAppearance.BorderSize = 0;
            this.btnNotAFunction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotAFunction2.Location = new System.Drawing.Point(2165, 470);
            this.btnNotAFunction2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNotAFunction2.Name = "btnNotAFunction2";
            this.btnNotAFunction2.Size = new System.Drawing.Size(160, 148);
            this.btnNotAFunction2.TabIndex = 18;
            this.btnNotAFunction2.UseVisualStyleBackColor = true;
            // 
            // btnNotAFunction3
            // 
            this.btnNotAFunction3.Enabled = false;
            this.btnNotAFunction3.FlatAppearance.BorderSize = 0;
            this.btnNotAFunction3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotAFunction3.Location = new System.Drawing.Point(2165, 716);
            this.btnNotAFunction3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNotAFunction3.Name = "btnNotAFunction3";
            this.btnNotAFunction3.Size = new System.Drawing.Size(160, 148);
            this.btnNotAFunction3.TabIndex = 17;
            this.btnNotAFunction3.UseVisualStyleBackColor = true;
            // 
            // btnNotAFunction4
            // 
            this.btnNotAFunction4.Enabled = false;
            this.btnNotAFunction4.FlatAppearance.BorderSize = 0;
            this.btnNotAFunction4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotAFunction4.Location = new System.Drawing.Point(2165, 962);
            this.btnNotAFunction4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNotAFunction4.Name = "btnNotAFunction4";
            this.btnNotAFunction4.Size = new System.Drawing.Size(160, 148);
            this.btnNotAFunction4.TabIndex = 16;
            this.btnNotAFunction4.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.btnNotAFunction1);
            this.Controls.Add(this.btnNotAFunction2);
            this.Controls.Add(this.btnNotAFunction3);
            this.Controls.Add(this.btnNotAFunction4);
            this.Controls.Add(this.pnlCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "home";
            this.Text = "Homescreen";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.home_Load);
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblShowBalance;
        private System.Windows.Forms.Button btnDepositMoney;
        private System.Windows.Forms.Button btnWithdrawBalance;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblLastThreeTransaction;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Button btnNotAFunction1;
        private System.Windows.Forms.Button btnNotAFunction2;
        private System.Windows.Forms.Button btnNotAFunction3;
        private System.Windows.Forms.Button btnNotAFunction4;
    }
}
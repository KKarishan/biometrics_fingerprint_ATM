namespace ATM
{
    partial class transfer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transfer));
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.buttonTConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTQuickScan = new System.Windows.Forms.Button();
            this.buttonTHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTAccount = new System.Windows.Forms.Button();
            this.textBoxTID = new System.Windows.Forms.TextBox();
            this.comboBoxTACNo = new System.Windows.Forms.ComboBox();
            this.textBoxTBalance = new System.Windows.Forms.TextBox();
            this.textBoxTTransferACNo = new System.Windows.Forms.TextBox();
            this.textBoxTTransferAmount = new System.Windows.Forms.TextBox();
            this.serialPortTransfer = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.label5.Location = new System.Drawing.Point(342, 417);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 32);
            this.label5.TabIndex = 44;
            this.label5.Text = "Transfer Amount";
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(1)))), ((int)(((byte)(107)))));
            this.buttonTransfer.FlatAppearance.BorderSize = 0;
            this.buttonTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransfer.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransfer.ForeColor = System.Drawing.Color.White;
            this.buttonTransfer.Location = new System.Drawing.Point(348, 558);
            this.buttonTransfer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(352, 55);
            this.buttonTransfer.TabIndex = 41;
            this.buttonTransfer.Text = "Transfer          >";
            this.buttonTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTransfer.UseVisualStyleBackColor = false;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // buttonTConfirm
            // 
            this.buttonTConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(1)))), ((int)(((byte)(107)))));
            this.buttonTConfirm.FlatAppearance.BorderSize = 0;
            this.buttonTConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTConfirm.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonTConfirm.Location = new System.Drawing.Point(72, 539);
            this.buttonTConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTConfirm.Name = "buttonTConfirm";
            this.buttonTConfirm.Size = new System.Drawing.Size(176, 45);
            this.buttonTConfirm.TabIndex = 39;
            this.buttonTConfirm.Text = "Confirm";
            this.buttonTConfirm.UseVisualStyleBackColor = false;
            this.buttonTConfirm.Click += new System.EventHandler(this.buttonTConfirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.label4.Location = new System.Drawing.Point(20, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 32);
            this.label4.TabIndex = 38;
            this.label4.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(24, 428);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 32);
            this.label2.TabIndex = 36;
            this.label2.Text = "Account No";
            // 
            // buttonTQuickScan
            // 
            this.buttonTQuickScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(1)))), ((int)(((byte)(107)))));
            this.buttonTQuickScan.FlatAppearance.BorderSize = 0;
            this.buttonTQuickScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTQuickScan.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTQuickScan.ForeColor = System.Drawing.Color.White;
            this.buttonTQuickScan.Location = new System.Drawing.Point(26, 126);
            this.buttonTQuickScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTQuickScan.Name = "buttonTQuickScan";
            this.buttonTQuickScan.Size = new System.Drawing.Size(675, 55);
            this.buttonTQuickScan.TabIndex = 34;
            this.buttonTQuickScan.Text = "Quick Scan";
            this.buttonTQuickScan.UseVisualStyleBackColor = false;
            this.buttonTQuickScan.Click += new System.EventHandler(this.buttonTQuickScan_Click);
            // 
            // buttonTHome
            // 
            this.buttonTHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonTHome.FlatAppearance.BorderSize = 0;
            this.buttonTHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTHome.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTHome.ForeColor = System.Drawing.Color.White;
            this.buttonTHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonTHome.Image")));
            this.buttonTHome.Location = new System.Drawing.Point(598, 18);
            this.buttonTHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTHome.Name = "buttonTHome";
            this.buttonTHome.Size = new System.Drawing.Size(126, 69);
            this.buttonTHome.TabIndex = 29;
            this.buttonTHome.Text = "Home";
            this.buttonTHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonTHome.UseVisualStyleBackColor = false;
            this.buttonTHome.Click += new System.EventHandler(this.buttonTHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 45);
            this.label1.TabIndex = 28;
            this.label1.Text = "Transfer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.label6.Location = new System.Drawing.Point(342, 314);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 32);
            this.label6.TabIndex = 46;
            this.label6.Text = "Transfer Account No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.label3.Location = new System.Drawing.Point(342, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 32);
            this.label3.TabIndex = 47;
            this.label3.Text = "Balance";
            // 
            // buttonTAccount
            // 
            this.buttonTAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(93)))), ((int)(((byte)(192)))));
            this.buttonTAccount.FlatAppearance.BorderSize = 0;
            this.buttonTAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTAccount.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTAccount.ForeColor = System.Drawing.Color.White;
            this.buttonTAccount.Location = new System.Drawing.Point(72, 317);
            this.buttonTAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTAccount.Name = "buttonTAccount";
            this.buttonTAccount.Size = new System.Drawing.Size(176, 45);
            this.buttonTAccount.TabIndex = 49;
            this.buttonTAccount.Text = "Account";
            this.buttonTAccount.UseVisualStyleBackColor = false;
            this.buttonTAccount.Click += new System.EventHandler(this.buttonTAccount_Click);
            // 
            // textBoxTID
            // 
            this.textBoxTID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(151)))));
            this.textBoxTID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxTID.ForeColor = System.Drawing.Color.White;
            this.textBoxTID.Location = new System.Drawing.Point(26, 261);
            this.textBoxTID.Multiline = true;
            this.textBoxTID.Name = "textBoxTID";
            this.textBoxTID.Size = new System.Drawing.Size(269, 39);
            this.textBoxTID.TabIndex = 50;
            // 
            // comboBoxTACNo
            // 
            this.comboBoxTACNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(151)))));
            this.comboBoxTACNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTACNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTACNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxTACNo.ForeColor = System.Drawing.Color.White;
            this.comboBoxTACNo.FormattingEnabled = true;
            this.comboBoxTACNo.Location = new System.Drawing.Point(26, 471);
            this.comboBoxTACNo.Name = "comboBoxTACNo";
            this.comboBoxTACNo.Size = new System.Drawing.Size(256, 36);
            this.comboBoxTACNo.TabIndex = 54;
            // 
            // textBoxTBalance
            // 
            this.textBoxTBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(151)))));
            this.textBoxTBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTBalance.Enabled = false;
            this.textBoxTBalance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxTBalance.ForeColor = System.Drawing.Color.White;
            this.textBoxTBalance.Location = new System.Drawing.Point(348, 261);
            this.textBoxTBalance.Multiline = true;
            this.textBoxTBalance.Name = "textBoxTBalance";
            this.textBoxTBalance.Size = new System.Drawing.Size(310, 39);
            this.textBoxTBalance.TabIndex = 55;
            // 
            // textBoxTTransferACNo
            // 
            this.textBoxTTransferACNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxTTransferACNo.Location = new System.Drawing.Point(348, 359);
            this.textBoxTTransferACNo.Multiline = true;
            this.textBoxTTransferACNo.Name = "textBoxTTransferACNo";
            this.textBoxTTransferACNo.Size = new System.Drawing.Size(310, 39);
            this.textBoxTTransferACNo.TabIndex = 56;
            this.textBoxTTransferACNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTTransferAmount
            // 
            this.textBoxTTransferAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxTTransferAmount.Location = new System.Drawing.Point(348, 460);
            this.textBoxTTransferAmount.Multiline = true;
            this.textBoxTTransferAmount.Name = "textBoxTTransferAmount";
            this.textBoxTTransferAmount.Size = new System.Drawing.Size(310, 39);
            this.textBoxTTransferAmount.TabIndex = 57;
            this.textBoxTTransferAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTTransferAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTTransferAmount_KeyPress);
            // 
            // serialPortTransfer
            // 
            this.serialPortTransfer.PortName = "COM8";
            // 
            // transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(742, 680);
            this.Controls.Add(this.textBoxTTransferAmount);
            this.Controls.Add(this.textBoxTTransferACNo);
            this.Controls.Add(this.textBoxTBalance);
            this.Controls.Add(this.comboBoxTACNo);
            this.Controls.Add(this.textBoxTID);
            this.Controls.Add(this.buttonTAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.buttonTConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonTQuickScan);
            this.Controls.Add(this.buttonTHome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "transfer";
            this.Load += new System.EventHandler(this.transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.Button buttonTConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTQuickScan;
        private System.Windows.Forms.Button buttonTHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTAccount;
        private System.Windows.Forms.TextBox textBoxTID;
        private System.Windows.Forms.ComboBox comboBoxTACNo;
        private System.Windows.Forms.TextBox textBoxTBalance;
        private System.Windows.Forms.TextBox textBoxTTransferACNo;
        private System.Windows.Forms.TextBox textBoxTTransferAmount;
        public System.IO.Ports.SerialPort serialPortTransfer;
    }
}
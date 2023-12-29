namespace ATM
{
    partial class withdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(withdraw));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonWHome = new System.Windows.Forms.Button();
            this.button7500 = new System.Windows.Forms.Button();
            this.button10000 = new System.Windows.Forms.Button();
            this.button5000 = new System.Windows.Forms.Button();
            this.button1000 = new System.Windows.Forms.Button();
            this.buttonWQuickScan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonWConfirm = new System.Windows.Forms.Button();
            this.buttonCash = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonWAccount = new System.Windows.Forms.Button();
            this.TextboxWID = new System.Windows.Forms.TextBox();
            this.TextboxWBalance = new System.Windows.Forms.TextBox();
            this.TextboxWAmount = new System.Windows.Forms.TextBox();
            this.DropdownWACNo = new System.Windows.Forms.ComboBox();
            this.serialPortWithdraw = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "Withdraw";
            // 
            // buttonWHome
            // 
            this.buttonWHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonWHome.FlatAppearance.BorderSize = 0;
            this.buttonWHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWHome.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWHome.ForeColor = System.Drawing.Color.White;
            this.buttonWHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonWHome.Image")));
            this.buttonWHome.Location = new System.Drawing.Point(598, 18);
            this.buttonWHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonWHome.Name = "buttonWHome";
            this.buttonWHome.Size = new System.Drawing.Size(126, 69);
            this.buttonWHome.TabIndex = 9;
            this.buttonWHome.Text = "Home";
            this.buttonWHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonWHome.UseVisualStyleBackColor = false;
            this.buttonWHome.Click += new System.EventHandler(this.buttonWHome_Click);
            // 
            // button7500
            // 
            this.button7500.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(93)))), ((int)(((byte)(192)))));
            this.button7500.FlatAppearance.BorderSize = 0;
            this.button7500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7500.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7500.ForeColor = System.Drawing.Color.White;
            this.button7500.Location = new System.Drawing.Point(318, 409);
            this.button7500.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7500.Name = "button7500";
            this.button7500.Size = new System.Drawing.Size(180, 55);
            this.button7500.TabIndex = 10;
            this.button7500.Text = "Rs.7500";
            this.button7500.UseVisualStyleBackColor = false;
            this.button7500.Click += new System.EventHandler(this.button7500_Click);
            // 
            // button10000
            // 
            this.button10000.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.button10000.FlatAppearance.BorderSize = 0;
            this.button10000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10000.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10000.ForeColor = System.Drawing.Color.White;
            this.button10000.Location = new System.Drawing.Point(520, 409);
            this.button10000.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10000.Name = "button10000";
            this.button10000.Size = new System.Drawing.Size(180, 55);
            this.button10000.TabIndex = 11;
            this.button10000.Text = "Rs.10000";
            this.button10000.UseVisualStyleBackColor = false;
            this.button10000.Click += new System.EventHandler(this.button10000_Click);
            // 
            // button5000
            // 
            this.button5000.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.button5000.FlatAppearance.BorderSize = 0;
            this.button5000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5000.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5000.ForeColor = System.Drawing.Color.White;
            this.button5000.Location = new System.Drawing.Point(520, 325);
            this.button5000.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5000.Name = "button5000";
            this.button5000.Size = new System.Drawing.Size(180, 55);
            this.button5000.TabIndex = 12;
            this.button5000.Text = "Rs.5000";
            this.button5000.UseVisualStyleBackColor = false;
            this.button5000.Click += new System.EventHandler(this.button5000_Click);
            // 
            // button1000
            // 
            this.button1000.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.button1000.FlatAppearance.BorderSize = 0;
            this.button1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1000.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1000.ForeColor = System.Drawing.Color.White;
            this.button1000.Location = new System.Drawing.Point(318, 325);
            this.button1000.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1000.Name = "button1000";
            this.button1000.Size = new System.Drawing.Size(180, 55);
            this.button1000.TabIndex = 13;
            this.button1000.Text = "Rs.1000";
            this.button1000.UseVisualStyleBackColor = false;
            this.button1000.Click += new System.EventHandler(this.button1000_Click);
            // 
            // buttonWQuickScan
            // 
            this.buttonWQuickScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(1)))), ((int)(((byte)(107)))));
            this.buttonWQuickScan.FlatAppearance.BorderSize = 0;
            this.buttonWQuickScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWQuickScan.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWQuickScan.ForeColor = System.Drawing.Color.White;
            this.buttonWQuickScan.Location = new System.Drawing.Point(26, 126);
            this.buttonWQuickScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonWQuickScan.Name = "buttonWQuickScan";
            this.buttonWQuickScan.Size = new System.Drawing.Size(675, 55);
            this.buttonWQuickScan.TabIndex = 14;
            this.buttonWQuickScan.Text = "Quick Scan";
            this.buttonWQuickScan.UseVisualStyleBackColor = false;
            this.buttonWQuickScan.Click += new System.EventHandler(this.buttonWQuickScan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(24, 351);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Account No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.label3.Location = new System.Drawing.Point(20, 511);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.label4.Location = new System.Drawing.Point(20, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "ID";
            // 
            // buttonWConfirm
            // 
            this.buttonWConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(1)))), ((int)(((byte)(107)))));
            this.buttonWConfirm.FlatAppearance.BorderSize = 0;
            this.buttonWConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWConfirm.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonWConfirm.Location = new System.Drawing.Point(72, 457);
            this.buttonWConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonWConfirm.Name = "buttonWConfirm";
            this.buttonWConfirm.Size = new System.Drawing.Size(176, 45);
            this.buttonWConfirm.TabIndex = 19;
            this.buttonWConfirm.Text = "Confirm";
            this.buttonWConfirm.UseVisualStyleBackColor = false;
            this.buttonWConfirm.Click += new System.EventHandler(this.buttonWConfirm_Click);
            // 
            // buttonCash
            // 
            this.buttonCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(1)))), ((int)(((byte)(107)))));
            this.buttonCash.FlatAppearance.BorderSize = 0;
            this.buttonCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCash.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCash.ForeColor = System.Drawing.Color.White;
            this.buttonCash.Location = new System.Drawing.Point(318, 529);
            this.buttonCash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCash.Name = "buttonCash";
            this.buttonCash.Size = new System.Drawing.Size(382, 55);
            this.buttonCash.TabIndex = 22;
            this.buttonCash.Text = "Cash             >";
            this.buttonCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCash.UseVisualStyleBackColor = false;
            this.buttonCash.Click += new System.EventHandler(this.buttonCash_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.label5.Location = new System.Drawing.Point(312, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 32);
            this.label5.TabIndex = 27;
            this.label5.Text = "Enter Amount";
            // 
            // buttonWAccount
            // 
            this.buttonWAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(93)))), ((int)(((byte)(192)))));
            this.buttonWAccount.FlatAppearance.BorderSize = 0;
            this.buttonWAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWAccount.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWAccount.ForeColor = System.Drawing.Color.White;
            this.buttonWAccount.Location = new System.Drawing.Point(72, 298);
            this.buttonWAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonWAccount.Name = "buttonWAccount";
            this.buttonWAccount.Size = new System.Drawing.Size(176, 45);
            this.buttonWAccount.TabIndex = 28;
            this.buttonWAccount.Text = "Account";
            this.buttonWAccount.UseVisualStyleBackColor = false;
            this.buttonWAccount.Click += new System.EventHandler(this.buttonWAccount_Click);
            // 
            // TextboxWID
            // 
            this.TextboxWID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(151)))));
            this.TextboxWID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxWID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxWID.ForeColor = System.Drawing.Color.White;
            this.TextboxWID.Location = new System.Drawing.Point(24, 244);
            this.TextboxWID.Multiline = true;
            this.TextboxWID.Name = "TextboxWID";
            this.TextboxWID.Size = new System.Drawing.Size(262, 35);
            this.TextboxWID.TabIndex = 29;
            this.TextboxWID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextboxWBalance
            // 
            this.TextboxWBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(151)))));
            this.TextboxWBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxWBalance.Enabled = false;
            this.TextboxWBalance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxWBalance.ForeColor = System.Drawing.Color.White;
            this.TextboxWBalance.Location = new System.Drawing.Point(26, 549);
            this.TextboxWBalance.Multiline = true;
            this.TextboxWBalance.Name = "TextboxWBalance";
            this.TextboxWBalance.Size = new System.Drawing.Size(262, 35);
            this.TextboxWBalance.TabIndex = 31;
            this.TextboxWBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextboxWAmount
            // 
            this.TextboxWAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxWAmount.Location = new System.Drawing.Point(318, 254);
            this.TextboxWAmount.Multiline = true;
            this.TextboxWAmount.Name = "TextboxWAmount";
            this.TextboxWAmount.Size = new System.Drawing.Size(382, 49);
            this.TextboxWAmount.TabIndex = 32;
            this.TextboxWAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DropdownWACNo
            // 
            this.DropdownWACNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(151)))));
            this.DropdownWACNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownWACNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropdownWACNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropdownWACNo.ForeColor = System.Drawing.Color.White;
            this.DropdownWACNo.FormattingEnabled = true;
            this.DropdownWACNo.Location = new System.Drawing.Point(30, 399);
            this.DropdownWACNo.Name = "DropdownWACNo";
            this.DropdownWACNo.Size = new System.Drawing.Size(256, 36);
            this.DropdownWACNo.TabIndex = 33;
            // 
            // serialPortWithdraw
            // 
            this.serialPortWithdraw.PortName = "COM8";
            // 
            // withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(742, 680);
            this.Controls.Add(this.DropdownWACNo);
            this.Controls.Add(this.TextboxWAmount);
            this.Controls.Add(this.TextboxWBalance);
            this.Controls.Add(this.TextboxWID);
            this.Controls.Add(this.buttonWAccount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCash);
            this.Controls.Add(this.buttonWConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonWQuickScan);
            this.Controls.Add(this.button1000);
            this.Controls.Add(this.button5000);
            this.Controls.Add(this.button10000);
            this.Controls.Add(this.button7500);
            this.Controls.Add(this.buttonWHome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "withdraw";
            this.Load += new System.EventHandler(this.withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonWHome;
        private System.Windows.Forms.Button button7500;
        private System.Windows.Forms.Button button10000;
        private System.Windows.Forms.Button button5000;
        private System.Windows.Forms.Button button1000;
        private System.Windows.Forms.Button buttonWQuickScan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonWConfirm;
        private System.Windows.Forms.Button buttonCash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonWAccount;
        private System.Windows.Forms.TextBox TextboxWID;
        private System.Windows.Forms.TextBox TextboxWBalance;
        private System.Windows.Forms.TextBox TextboxWAmount;
        private System.Windows.Forms.ComboBox DropdownWACNo;
        public System.IO.Ports.SerialPort serialPortWithdraw;
    }
}
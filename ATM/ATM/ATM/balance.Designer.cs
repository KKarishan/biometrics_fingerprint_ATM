namespace ATM
{
    partial class balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(balance));
            this.buttonIAccount = new System.Windows.Forms.Button();
            this.TextboxACBalance = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextboxIFingerID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.buttonIConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonIQuickScan = new System.Windows.Forms.Button();
            this.buttonIHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPortBalance = new System.IO.Ports.SerialPort(this.components);
            this.DropdownACNumber = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonIAccount
            // 
            this.buttonIAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(93)))), ((int)(((byte)(192)))));
            this.buttonIAccount.FlatAppearance.BorderSize = 0;
            this.buttonIAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIAccount.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIAccount.ForeColor = System.Drawing.Color.White;
            this.buttonIAccount.Location = new System.Drawing.Point(75, 354);
            this.buttonIAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonIAccount.Name = "buttonIAccount";
            this.buttonIAccount.Size = new System.Drawing.Size(176, 45);
            this.buttonIAccount.TabIndex = 65;
            this.buttonIAccount.Text = "Account";
            this.buttonIAccount.UseVisualStyleBackColor = false;
            this.buttonIAccount.Click += new System.EventHandler(this.buttonIAccount_Click);
            // 
            // TextboxACBalance
            // 
            this.TextboxACBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(151)))));
            this.TextboxACBalance.BorderColorFocused = System.Drawing.Color.Blue;
            this.TextboxACBalance.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(61)))), ((int)(((byte)(145)))));
            this.TextboxACBalance.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TextboxACBalance.BorderThickness = 1;
            this.TextboxACBalance.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextboxACBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxACBalance.Enabled = false;
            this.TextboxACBalance.Font = new System.Drawing.Font("Elephant", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxACBalance.ForeColor = System.Drawing.Color.White;
            this.TextboxACBalance.isPassword = false;
            this.TextboxACBalance.Location = new System.Drawing.Point(115, 510);
            this.TextboxACBalance.Margin = new System.Windows.Forms.Padding(0);
            this.TextboxACBalance.MaxLength = 32767;
            this.TextboxACBalance.Name = "TextboxACBalance";
            this.TextboxACBalance.Size = new System.Drawing.Size(507, 48);
            this.TextboxACBalance.TabIndex = 64;
            this.TextboxACBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.label3.Location = new System.Drawing.Point(69, 455);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 32);
            this.label3.TabIndex = 63;
            this.label3.Text = "Account Balance";
            // 
            // TextboxIFingerID
            // 
            this.TextboxIFingerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(151)))));
            this.TextboxIFingerID.BorderColorFocused = System.Drawing.Color.Blue;
            this.TextboxIFingerID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(61)))), ((int)(((byte)(145)))));
            this.TextboxIFingerID.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TextboxIFingerID.BorderThickness = 1;
            this.TextboxIFingerID.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextboxIFingerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxIFingerID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxIFingerID.ForeColor = System.Drawing.Color.White;
            this.TextboxIFingerID.isPassword = false;
            this.TextboxIFingerID.Location = new System.Drawing.Point(26, 277);
            this.TextboxIFingerID.Margin = new System.Windows.Forms.Padding(0);
            this.TextboxIFingerID.MaxLength = 32767;
            this.TextboxIFingerID.Name = "TextboxIFingerID";
            this.TextboxIFingerID.Size = new System.Drawing.Size(268, 48);
            this.TextboxIFingerID.TabIndex = 58;
            this.TextboxIFingerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // buttonIConfirm
            // 
            this.buttonIConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(1)))), ((int)(((byte)(107)))));
            this.buttonIConfirm.FlatAppearance.BorderSize = 0;
            this.buttonIConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIConfirm.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonIConfirm.Location = new System.Drawing.Point(446, 354);
            this.buttonIConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonIConfirm.Name = "buttonIConfirm";
            this.buttonIConfirm.Size = new System.Drawing.Size(176, 45);
            this.buttonIConfirm.TabIndex = 56;
            this.buttonIConfirm.Text = "Confirm";
            this.buttonIConfirm.UseVisualStyleBackColor = false;
            this.buttonIConfirm.Click += new System.EventHandler(this.buttonIConfirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.label4.Location = new System.Drawing.Point(20, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 32);
            this.label4.TabIndex = 55;
            this.label4.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(370, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 32);
            this.label2.TabIndex = 54;
            this.label2.Text = "Account No";
            // 
            // buttonIQuickScan
            // 
            this.buttonIQuickScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(1)))), ((int)(((byte)(107)))));
            this.buttonIQuickScan.FlatAppearance.BorderSize = 0;
            this.buttonIQuickScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIQuickScan.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIQuickScan.ForeColor = System.Drawing.Color.White;
            this.buttonIQuickScan.Location = new System.Drawing.Point(26, 126);
            this.buttonIQuickScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonIQuickScan.Name = "buttonIQuickScan";
            this.buttonIQuickScan.Size = new System.Drawing.Size(675, 55);
            this.buttonIQuickScan.TabIndex = 52;
            this.buttonIQuickScan.Text = "Quick Scan";
            this.buttonIQuickScan.UseVisualStyleBackColor = false;
            this.buttonIQuickScan.Click += new System.EventHandler(this.buttonIQuickScan_Click);
            // 
            // buttonIHome
            // 
            this.buttonIHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonIHome.FlatAppearance.BorderSize = 0;
            this.buttonIHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIHome.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIHome.ForeColor = System.Drawing.Color.White;
            this.buttonIHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonIHome.Image")));
            this.buttonIHome.Location = new System.Drawing.Point(598, 18);
            this.buttonIHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonIHome.Name = "buttonIHome";
            this.buttonIHome.Size = new System.Drawing.Size(126, 69);
            this.buttonIHome.TabIndex = 51;
            this.buttonIHome.Text = "Home";
            this.buttonIHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonIHome.UseVisualStyleBackColor = false;
            this.buttonIHome.Click += new System.EventHandler(this.buttonIHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 45);
            this.label1.TabIndex = 50;
            this.label1.Text = "    Inquiry";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialPortBalance
            // 
            this.serialPortBalance.PortName = "COM8";
            // 
            // DropdownACNumber
            // 
            this.DropdownACNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(151)))));
            this.DropdownACNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownACNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropdownACNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropdownACNumber.ForeColor = System.Drawing.Color.White;
            this.DropdownACNumber.FormattingEnabled = true;
            this.DropdownACNumber.Location = new System.Drawing.Point(376, 288);
            this.DropdownACNumber.Name = "DropdownACNumber";
            this.DropdownACNumber.Size = new System.Drawing.Size(239, 36);
            this.DropdownACNumber.TabIndex = 66;
            // 
            // balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(742, 680);
            this.Controls.Add(this.DropdownACNumber);
            this.Controls.Add(this.buttonIAccount);
            this.Controls.Add(this.TextboxACBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextboxIFingerID);
            this.Controls.Add(this.buttonIConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonIQuickScan);
            this.Controls.Add(this.buttonIHome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "balance";
            this.Load += new System.EventHandler(this.balance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIAccount;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxACBalance;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxIFingerID;
        private System.Windows.Forms.Button buttonIConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonIQuickScan;
        private System.Windows.Forms.Button buttonIHome;
        private System.Windows.Forms.Label label1;
        public System.IO.Ports.SerialPort serialPortBalance;
        private System.Windows.Forms.ComboBox DropdownACNumber;
    }
}
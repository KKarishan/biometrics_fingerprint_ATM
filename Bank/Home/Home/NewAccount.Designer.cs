namespace Home
{
    partial class NewAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonNSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TextboxNName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxNPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxNFID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxNFund = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxNNIC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buttonNClear = new System.Windows.Forms.Button();
            this.TextboxNAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buttonNFinger = new System.Windows.Forms.Button();
            this.serialPort1newAC = new System.IO.Ports.SerialPort(this.components);
            this.TextboxNAccount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonNSave
            // 
            this.buttonNSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonNSave.FlatAppearance.BorderSize = 0;
            this.buttonNSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNSave.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNSave.ForeColor = System.Drawing.Color.White;
            this.buttonNSave.Location = new System.Drawing.Point(435, 435);
            this.buttonNSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNSave.Name = "buttonNSave";
            this.buttonNSave.Size = new System.Drawing.Size(255, 51);
            this.buttonNSave.TabIndex = 1;
            this.buttonNSave.Text = "Save";
            this.buttonNSave.UseVisualStyleBackColor = false;
            this.buttonNSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(45, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(45, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(45, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(45, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 40);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(541, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 40);
            this.label6.TabIndex = 6;
            this.label6.Text = "NIC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(541, 164);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 40);
            this.label7.TabIndex = 7;
            this.label7.Text = "FingerPrint";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(541, 227);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 40);
            this.label8.TabIndex = 8;
            this.label8.Text = "Initial Fund";
            // 
            // TextboxNName
            // 
            this.TextboxNName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextboxNName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextboxNName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextboxNName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxNName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxNName.ForeColor = System.Drawing.Color.White;
            this.TextboxNName.HintForeColor = System.Drawing.Color.White;
            this.TextboxNName.HintText = "";
            this.TextboxNName.isPassword = false;
            this.TextboxNName.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxNName.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextboxNName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxNName.LineThickness = 2;
            this.TextboxNName.Location = new System.Drawing.Point(237, 152);
            this.TextboxNName.Margin = new System.Windows.Forms.Padding(6);
            this.TextboxNName.MaxLength = 32767;
            this.TextboxNName.Name = "TextboxNName";
            this.TextboxNName.Size = new System.Drawing.Size(273, 51);
            this.TextboxNName.TabIndex = 10;
            this.TextboxNName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxNPhone
            // 
            this.TextboxNPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextboxNPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextboxNPhone.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextboxNPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxNPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxNPhone.ForeColor = System.Drawing.Color.White;
            this.TextboxNPhone.HintForeColor = System.Drawing.Color.White;
            this.TextboxNPhone.HintText = "";
            this.TextboxNPhone.isPassword = false;
            this.TextboxNPhone.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxNPhone.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextboxNPhone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxNPhone.LineThickness = 2;
            this.TextboxNPhone.Location = new System.Drawing.Point(237, 215);
            this.TextboxNPhone.Margin = new System.Windows.Forms.Padding(6);
            this.TextboxNPhone.MaxLength = 10;
            this.TextboxNPhone.Name = "TextboxNPhone";
            this.TextboxNPhone.Size = new System.Drawing.Size(273, 51);
            this.TextboxNPhone.TabIndex = 11;
            this.TextboxNPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxNPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxNPhone_KeyPress);
            // 
            // TextboxNFID
            // 
            this.TextboxNFID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextboxNFID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextboxNFID.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextboxNFID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxNFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxNFID.ForeColor = System.Drawing.Color.White;
            this.TextboxNFID.HintForeColor = System.Drawing.Color.White;
            this.TextboxNFID.HintText = "";
            this.TextboxNFID.isPassword = false;
            this.TextboxNFID.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxNFID.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextboxNFID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxNFID.LineThickness = 2;
            this.TextboxNFID.Location = new System.Drawing.Point(725, 152);
            this.TextboxNFID.Margin = new System.Windows.Forms.Padding(6);
            this.TextboxNFID.MaxLength = 32767;
            this.TextboxNFID.Name = "TextboxNFID";
            this.TextboxNFID.Size = new System.Drawing.Size(273, 51);
            this.TextboxNFID.TabIndex = 13;
            this.TextboxNFID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxNFund
            // 
            this.TextboxNFund.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextboxNFund.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextboxNFund.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextboxNFund.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxNFund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxNFund.ForeColor = System.Drawing.Color.White;
            this.TextboxNFund.HintForeColor = System.Drawing.Color.White;
            this.TextboxNFund.HintText = "";
            this.TextboxNFund.isPassword = false;
            this.TextboxNFund.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxNFund.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextboxNFund.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxNFund.LineThickness = 2;
            this.TextboxNFund.Location = new System.Drawing.Point(725, 215);
            this.TextboxNFund.Margin = new System.Windows.Forms.Padding(6);
            this.TextboxNFund.MaxLength = 32767;
            this.TextboxNFund.Name = "TextboxNFund";
            this.TextboxNFund.Size = new System.Drawing.Size(273, 51);
            this.TextboxNFund.TabIndex = 14;
            this.TextboxNFund.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxNFund.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxNFund_KeyPress);
            // 
            // TextboxNNIC
            // 
            this.TextboxNNIC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextboxNNIC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextboxNNIC.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextboxNNIC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxNNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxNNIC.ForeColor = System.Drawing.Color.White;
            this.TextboxNNIC.HintForeColor = System.Drawing.Color.White;
            this.TextboxNNIC.HintText = "";
            this.TextboxNNIC.isPassword = false;
            this.TextboxNNIC.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxNNIC.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextboxNNIC.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxNNIC.LineThickness = 2;
            this.TextboxNNIC.Location = new System.Drawing.Point(725, 89);
            this.TextboxNNIC.Margin = new System.Windows.Forms.Padding(6);
            this.TextboxNNIC.MaxLength = 32767;
            this.TextboxNNIC.Name = "TextboxNNIC";
            this.TextboxNNIC.Size = new System.Drawing.Size(273, 51);
            this.TextboxNNIC.TabIndex = 15;
            this.TextboxNNIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // buttonNClear
            // 
            this.buttonNClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonNClear.FlatAppearance.BorderSize = 0;
            this.buttonNClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNClear.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNClear.ForeColor = System.Drawing.Color.White;
            this.buttonNClear.Location = new System.Drawing.Point(699, 435);
            this.buttonNClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNClear.Name = "buttonNClear";
            this.buttonNClear.Size = new System.Drawing.Size(255, 51);
            this.buttonNClear.TabIndex = 16;
            this.buttonNClear.Text = "Clear";
            this.buttonNClear.UseVisualStyleBackColor = false;
            this.buttonNClear.Click += new System.EventHandler(this.buttonNClear_Click);
            // 
            // TextboxNAddress
            // 
            this.TextboxNAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextboxNAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextboxNAddress.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextboxNAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxNAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxNAddress.ForeColor = System.Drawing.Color.White;
            this.TextboxNAddress.HintForeColor = System.Drawing.Color.White;
            this.TextboxNAddress.HintText = "";
            this.TextboxNAddress.isPassword = false;
            this.TextboxNAddress.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxNAddress.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextboxNAddress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxNAddress.LineThickness = 2;
            this.TextboxNAddress.Location = new System.Drawing.Point(237, 291);
            this.TextboxNAddress.Margin = new System.Windows.Forms.Padding(6);
            this.TextboxNAddress.MaxLength = 32767;
            this.TextboxNAddress.Name = "TextboxNAddress";
            this.TextboxNAddress.Size = new System.Drawing.Size(480, 120);
            this.TextboxNAddress.TabIndex = 17;
            this.TextboxNAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxNAddress.OnValueChanged += new System.EventHandler(this.TextboxNAddress_OnValueChanged);
            // 
            // buttonNFinger
            // 
            this.buttonNFinger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonNFinger.FlatAppearance.BorderSize = 0;
            this.buttonNFinger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNFinger.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNFinger.ForeColor = System.Drawing.Color.White;
            this.buttonNFinger.Location = new System.Drawing.Point(171, 435);
            this.buttonNFinger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNFinger.Name = "buttonNFinger";
            this.buttonNFinger.Size = new System.Drawing.Size(255, 51);
            this.buttonNFinger.TabIndex = 37;
            this.buttonNFinger.Text = "Scan Finger";
            this.buttonNFinger.UseVisualStyleBackColor = false;
            this.buttonNFinger.Click += new System.EventHandler(this.buttonNFinger_Click);
            // 
            // serialPort1newAC
            // 
            this.serialPort1newAC.PortName = "COM8";
            // 
            // TextboxNAccount
            // 
            this.TextboxNAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.TextboxNAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxNAccount.Enabled = false;
            this.TextboxNAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextboxNAccount.ForeColor = System.Drawing.Color.White;
            this.TextboxNAccount.Location = new System.Drawing.Point(237, 100);
            this.TextboxNAccount.Multiline = true;
            this.TextboxNAccount.Name = "TextboxNAccount";
            this.TextboxNAccount.Size = new System.Drawing.Size(273, 43);
            this.TextboxNAccount.TabIndex = 38;
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.TextboxNAccount);
            this.Controls.Add(this.buttonNFinger);
            this.Controls.Add(this.TextboxNAddress);
            this.Controls.Add(this.buttonNClear);
            this.Controls.Add(this.TextboxNNIC);
            this.Controls.Add(this.TextboxNFund);
            this.Controls.Add(this.TextboxNFID);
            this.Controls.Add(this.TextboxNPhone);
            this.Controls.Add(this.TextboxNName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonNSave);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewAccount";
            this.Size = new System.Drawing.Size(1106, 634);
            this.Load += new System.EventHandler(this.NewAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxNName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxNPhone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxNFID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxNFund;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxNNIC;
        private System.Windows.Forms.Button buttonNClear;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxNAddress;
        private System.Windows.Forms.Button buttonNFinger;
        public System.IO.Ports.SerialPort serialPort1newAC;
        private System.Windows.Forms.TextBox TextboxNAccount;
    }
}

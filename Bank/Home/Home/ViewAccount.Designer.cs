namespace Home
{
    partial class ViewAccount
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
            this.TextboxVAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buttonVUpdate = new System.Windows.Forms.Button();
            this.TextboxVNIC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxVFund = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxVFID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxVPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxVName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxVAccountNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonVSearch = new System.Windows.Forms.Button();
            this.serialPortview = new System.IO.Ports.SerialPort(this.components);
            this.buttonVFinger = new System.Windows.Forms.Button();
            this.comboBoxVStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TextboxVAddress
            // 
            this.TextboxVAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextboxVAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextboxVAddress.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextboxVAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxVAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxVAddress.ForeColor = System.Drawing.Color.White;
            this.TextboxVAddress.HintForeColor = System.Drawing.Color.White;
            this.TextboxVAddress.HintText = "";
            this.TextboxVAddress.isPassword = false;
            this.TextboxVAddress.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxVAddress.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextboxVAddress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxVAddress.LineThickness = 2;
            this.TextboxVAddress.Location = new System.Drawing.Point(244, 287);
            this.TextboxVAddress.Margin = new System.Windows.Forms.Padding(6);
            this.TextboxVAddress.MaxLength = 32767;
            this.TextboxVAddress.Name = "TextboxVAddress";
            this.TextboxVAddress.Size = new System.Drawing.Size(486, 114);
            this.TextboxVAddress.TabIndex = 33;
            this.TextboxVAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // buttonVUpdate
            // 
            this.buttonVUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonVUpdate.FlatAppearance.BorderSize = 0;
            this.buttonVUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVUpdate.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonVUpdate.Location = new System.Drawing.Point(697, 428);
            this.buttonVUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVUpdate.Name = "buttonVUpdate";
            this.buttonVUpdate.Size = new System.Drawing.Size(255, 51);
            this.buttonVUpdate.TabIndex = 32;
            this.buttonVUpdate.Text = "Update";
            this.buttonVUpdate.UseVisualStyleBackColor = false;
            this.buttonVUpdate.Click += new System.EventHandler(this.buttonVUpdate_Click);
            // 
            // TextboxVNIC
            // 
            this.TextboxVNIC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextboxVNIC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextboxVNIC.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextboxVNIC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxVNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxVNIC.ForeColor = System.Drawing.Color.White;
            this.TextboxVNIC.HintForeColor = System.Drawing.Color.White;
            this.TextboxVNIC.HintText = "";
            this.TextboxVNIC.isPassword = false;
            this.TextboxVNIC.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxVNIC.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextboxVNIC.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxVNIC.LineThickness = 2;
            this.TextboxVNIC.Location = new System.Drawing.Point(740, 85);
            this.TextboxVNIC.Margin = new System.Windows.Forms.Padding(6);
            this.TextboxVNIC.MaxLength = 32767;
            this.TextboxVNIC.Name = "TextboxVNIC";
            this.TextboxVNIC.Size = new System.Drawing.Size(273, 51);
            this.TextboxVNIC.TabIndex = 31;
            this.TextboxVNIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxVFund
            // 
            this.TextboxVFund.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextboxVFund.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextboxVFund.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextboxVFund.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxVFund.Enabled = false;
            this.TextboxVFund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxVFund.ForeColor = System.Drawing.Color.White;
            this.TextboxVFund.HintForeColor = System.Drawing.Color.White;
            this.TextboxVFund.HintText = "";
            this.TextboxVFund.isPassword = false;
            this.TextboxVFund.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxVFund.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextboxVFund.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxVFund.LineThickness = 2;
            this.TextboxVFund.Location = new System.Drawing.Point(740, 211);
            this.TextboxVFund.Margin = new System.Windows.Forms.Padding(6);
            this.TextboxVFund.MaxLength = 32767;
            this.TextboxVFund.Name = "TextboxVFund";
            this.TextboxVFund.Size = new System.Drawing.Size(273, 51);
            this.TextboxVFund.TabIndex = 30;
            this.TextboxVFund.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxVFID
            // 
            this.TextboxVFID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextboxVFID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextboxVFID.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextboxVFID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxVFID.Enabled = false;
            this.TextboxVFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxVFID.ForeColor = System.Drawing.Color.White;
            this.TextboxVFID.HintForeColor = System.Drawing.Color.White;
            this.TextboxVFID.HintText = "";
            this.TextboxVFID.isPassword = false;
            this.TextboxVFID.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxVFID.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextboxVFID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxVFID.LineThickness = 2;
            this.TextboxVFID.Location = new System.Drawing.Point(740, 148);
            this.TextboxVFID.Margin = new System.Windows.Forms.Padding(6);
            this.TextboxVFID.MaxLength = 32767;
            this.TextboxVFID.Name = "TextboxVFID";
            this.TextboxVFID.Size = new System.Drawing.Size(273, 51);
            this.TextboxVFID.TabIndex = 29;
            this.TextboxVFID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxVPhone
            // 
            this.TextboxVPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextboxVPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextboxVPhone.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextboxVPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxVPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxVPhone.ForeColor = System.Drawing.Color.White;
            this.TextboxVPhone.HintForeColor = System.Drawing.Color.White;
            this.TextboxVPhone.HintText = "";
            this.TextboxVPhone.isPassword = false;
            this.TextboxVPhone.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxVPhone.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextboxVPhone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxVPhone.LineThickness = 2;
            this.TextboxVPhone.Location = new System.Drawing.Point(244, 211);
            this.TextboxVPhone.Margin = new System.Windows.Forms.Padding(6);
            this.TextboxVPhone.MaxLength = 10;
            this.TextboxVPhone.Name = "TextboxVPhone";
            this.TextboxVPhone.Size = new System.Drawing.Size(273, 51);
            this.TextboxVPhone.TabIndex = 28;
            this.TextboxVPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxVPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxVPhone_KeyPress);
            // 
            // TextboxVName
            // 
            this.TextboxVName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextboxVName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextboxVName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextboxVName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxVName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxVName.ForeColor = System.Drawing.Color.White;
            this.TextboxVName.HintForeColor = System.Drawing.Color.White;
            this.TextboxVName.HintText = "";
            this.TextboxVName.isPassword = false;
            this.TextboxVName.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxVName.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextboxVName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxVName.LineThickness = 2;
            this.TextboxVName.Location = new System.Drawing.Point(244, 148);
            this.TextboxVName.Margin = new System.Windows.Forms.Padding(6);
            this.TextboxVName.MaxLength = 32767;
            this.TextboxVName.Name = "TextboxVName";
            this.TextboxVName.Size = new System.Drawing.Size(273, 51);
            this.TextboxVName.TabIndex = 27;
            this.TextboxVName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxVAccountNo
            // 
            this.TextboxVAccountNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TextboxVAccountNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextboxVAccountNo.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextboxVAccountNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxVAccountNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxVAccountNo.ForeColor = System.Drawing.Color.White;
            this.TextboxVAccountNo.HintForeColor = System.Drawing.Color.White;
            this.TextboxVAccountNo.HintText = "";
            this.TextboxVAccountNo.isPassword = false;
            this.TextboxVAccountNo.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxVAccountNo.LineIdleColor = System.Drawing.Color.DimGray;
            this.TextboxVAccountNo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxVAccountNo.LineThickness = 2;
            this.TextboxVAccountNo.Location = new System.Drawing.Point(244, 85);
            this.TextboxVAccountNo.Margin = new System.Windows.Forms.Padding(6);
            this.TextboxVAccountNo.MaxLength = 32767;
            this.TextboxVAccountNo.Name = "TextboxVAccountNo";
            this.TextboxVAccountNo.Size = new System.Drawing.Size(273, 51);
            this.TextboxVAccountNo.TabIndex = 26;
            this.TextboxVAccountNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(556, 223);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 40);
            this.label8.TabIndex = 25;
            this.label8.Text = "Initial Fund";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(556, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 40);
            this.label7.TabIndex = 24;
            this.label7.Text = "FingerPrint";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(556, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 40);
            this.label6.TabIndex = 23;
            this.label6.Text = "NIC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(52, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 40);
            this.label5.TabIndex = 22;
            this.label5.Text = "Phone No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(52, 287);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 40);
            this.label4.TabIndex = 21;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(52, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 40);
            this.label3.TabIndex = 20;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(52, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 40);
            this.label2.TabIndex = 19;
            this.label2.Text = "Account No";
            // 
            // buttonVSearch
            // 
            this.buttonVSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonVSearch.FlatAppearance.BorderSize = 0;
            this.buttonVSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVSearch.ForeColor = System.Drawing.Color.White;
            this.buttonVSearch.Location = new System.Drawing.Point(434, 428);
            this.buttonVSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVSearch.Name = "buttonVSearch";
            this.buttonVSearch.Size = new System.Drawing.Size(255, 51);
            this.buttonVSearch.TabIndex = 18;
            this.buttonVSearch.Text = "Search";
            this.buttonVSearch.UseVisualStyleBackColor = false;
            this.buttonVSearch.Click += new System.EventHandler(this.buttonVSearch_Click);
            // 
            // serialPortview
            // 
            this.serialPortview.PortName = "COM3";
            // 
            // buttonVFinger
            // 
            this.buttonVFinger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonVFinger.FlatAppearance.BorderSize = 0;
            this.buttonVFinger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVFinger.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVFinger.ForeColor = System.Drawing.Color.White;
            this.buttonVFinger.Location = new System.Drawing.Point(171, 428);
            this.buttonVFinger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVFinger.Name = "buttonVFinger";
            this.buttonVFinger.Size = new System.Drawing.Size(255, 51);
            this.buttonVFinger.TabIndex = 38;
            this.buttonVFinger.Text = "Scan Finger";
            this.buttonVFinger.UseVisualStyleBackColor = false;
            this.buttonVFinger.Click += new System.EventHandler(this.buttonNFinger_Click);
            // 
            // comboBoxVStatus
            // 
            this.comboBoxVStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.comboBoxVStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxVStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVStatus.ForeColor = System.Drawing.Color.White;
            this.comboBoxVStatus.FormattingEnabled = true;
            this.comboBoxVStatus.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.comboBoxVStatus.Location = new System.Drawing.Point(872, 293);
            this.comboBoxVStatus.Name = "comboBoxVStatus";
            this.comboBoxVStatus.Size = new System.Drawing.Size(141, 37);
            this.comboBoxVStatus.TabIndex = 39;
            this.comboBoxVStatus.Text = "Active";
            // 
            // ViewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.comboBoxVStatus);
            this.Controls.Add(this.buttonVFinger);
            this.Controls.Add(this.TextboxVAddress);
            this.Controls.Add(this.buttonVUpdate);
            this.Controls.Add(this.TextboxVNIC);
            this.Controls.Add(this.TextboxVFund);
            this.Controls.Add(this.TextboxVFID);
            this.Controls.Add(this.TextboxVPhone);
            this.Controls.Add(this.TextboxVName);
            this.Controls.Add(this.TextboxVAccountNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonVSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewAccount";
            this.Size = new System.Drawing.Size(1106, 634);
            this.Load += new System.EventHandler(this.ViewAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxVAddress;
        private System.Windows.Forms.Button buttonVUpdate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxVNIC;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxVFund;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxVFID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxVPhone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxVName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxVAccountNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonVSearch;
        public System.IO.Ports.SerialPort serialPortview;
        private System.Windows.Forms.Button buttonVFinger;
        private System.Windows.Forms.ComboBox comboBoxVStatus;
    }
}

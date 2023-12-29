namespace Home
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSame = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonNavigation = new System.Windows.Forms.Button();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.buttonViewAccount = new System.Windows.Forms.Button();
            this.buttonNewAccount = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.sameAC1 = new Home.SameAC();
            this.viewAccount1 = new Home.ViewAccount();
            this.newAccount1 = new Home.NewAccount();
            this.homeControl1 = new Home.HomeControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.buttonSame);
            this.panel1.Controls.Add(this.buttonHelp);
            this.panel1.Controls.Add(this.buttonNavigation);
            this.panel1.Controls.Add(this.Sidepanel);
            this.panel1.Controls.Add(this.buttonViewAccount);
            this.panel1.Controls.Add(this.buttonNewAccount);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 831);
            this.panel1.TabIndex = 0;
            // 
            // buttonSame
            // 
            this.buttonSame.FlatAppearance.BorderSize = 0;
            this.buttonSame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSame.ForeColor = System.Drawing.Color.White;
            this.buttonSame.Image = ((System.Drawing.Image)(resources.GetObject("buttonSame.Image")));
            this.buttonSame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSame.Location = new System.Drawing.Point(18, 395);
            this.buttonSame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSame.Name = "buttonSame";
            this.buttonSame.Size = new System.Drawing.Size(240, 83);
            this.buttonSame.TabIndex = 18;
            this.buttonSame.Text = "   Same AC";
            this.buttonSame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSame.UseVisualStyleBackColor = true;
            this.buttonSame.Click += new System.EventHandler(this.buttonSame_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp.Image")));
            this.buttonHelp.Location = new System.Drawing.Point(15, 640);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(52, 55);
            this.buttonHelp.TabIndex = 17;
            this.buttonHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonNavigation
            // 
            this.buttonNavigation.FlatAppearance.BorderSize = 0;
            this.buttonNavigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavigation.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavigation.ForeColor = System.Drawing.Color.White;
            this.buttonNavigation.Image = ((System.Drawing.Image)(resources.GetObject("buttonNavigation.Image")));
            this.buttonNavigation.Location = new System.Drawing.Point(2, 0);
            this.buttonNavigation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNavigation.Name = "buttonNavigation";
            this.buttonNavigation.Size = new System.Drawing.Size(52, 55);
            this.buttonNavigation.TabIndex = 15;
            this.buttonNavigation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNavigation.UseVisualStyleBackColor = true;
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Sidepanel.Location = new System.Drawing.Point(2, 117);
            this.Sidepanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(15, 83);
            this.Sidepanel.TabIndex = 6;
            // 
            // buttonViewAccount
            // 
            this.buttonViewAccount.FlatAppearance.BorderSize = 0;
            this.buttonViewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewAccount.ForeColor = System.Drawing.Color.White;
            this.buttonViewAccount.Image = ((System.Drawing.Image)(resources.GetObject("buttonViewAccount.Image")));
            this.buttonViewAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonViewAccount.Location = new System.Drawing.Point(18, 302);
            this.buttonViewAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonViewAccount.Name = "buttonViewAccount";
            this.buttonViewAccount.Size = new System.Drawing.Size(240, 83);
            this.buttonViewAccount.TabIndex = 8;
            this.buttonViewAccount.Text = "   View Account";
            this.buttonViewAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonViewAccount.UseVisualStyleBackColor = true;
            this.buttonViewAccount.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonNewAccount
            // 
            this.buttonNewAccount.FlatAppearance.BorderSize = 0;
            this.buttonNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewAccount.ForeColor = System.Drawing.Color.White;
            this.buttonNewAccount.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewAccount.Image")));
            this.buttonNewAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNewAccount.Location = new System.Drawing.Point(18, 209);
            this.buttonNewAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNewAccount.Name = "buttonNewAccount";
            this.buttonNewAccount.Size = new System.Drawing.Size(240, 83);
            this.buttonNewAccount.TabIndex = 7;
            this.buttonNewAccount.Text = "   New Account";
            this.buttonNewAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNewAccount.UseVisualStyleBackColor = true;
            this.buttonNewAccount.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(18, 117);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(240, 83);
            this.buttonHome.TabIndex = 6;
            this.buttonHome.Text = "   Home";
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(258, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 38);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(348, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 180);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "AARISHK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Banking ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "C# UI Designing By AARISHK";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(1216, 48);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(52, 55);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // sameAC1
            // 
            this.sameAC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.sameAC1.Location = new System.Drawing.Point(258, 197);
            this.sameAC1.Name = "sameAC1";
            this.sameAC1.Size = new System.Drawing.Size(1106, 634);
            this.sameAC1.TabIndex = 17;
            this.sameAC1.Load += new System.EventHandler(this.sameAC1_Load);
            // 
            // viewAccount1
            // 
            this.viewAccount1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.viewAccount1.Location = new System.Drawing.Point(258, 197);
            this.viewAccount1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.viewAccount1.Name = "viewAccount1";
            this.viewAccount1.Size = new System.Drawing.Size(1125, 634);
            this.viewAccount1.TabIndex = 11;
            // 
            // newAccount1
            // 
            this.newAccount1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.newAccount1.Location = new System.Drawing.Point(268, 189);
            this.newAccount1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.newAccount1.Name = "newAccount1";
            this.newAccount1.Size = new System.Drawing.Size(1106, 634);
            this.newAccount1.TabIndex = 7;
            this.newAccount1.Load += new System.EventHandler(this.newAccount1_Load);
            // 
            // homeControl1
            // 
            this.homeControl1.Location = new System.Drawing.Point(268, 189);
            this.homeControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(1106, 634);
            this.homeControl1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1383, 831);
            this.Controls.Add(this.sameAC1);
            this.Controls.Add(this.viewAccount1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.newAccount1);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonViewAccount;
        private System.Windows.Forms.Button buttonNewAccount;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Sidepanel;
        private HomeControl homeControl1;
        private NewAccount newAccount1;
        private System.Windows.Forms.Button buttonNavigation;
        private ViewAccount viewAccount1;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSame;
        private SameAC sameAC1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


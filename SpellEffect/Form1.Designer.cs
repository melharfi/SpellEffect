namespace SpellEffect
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
            this.addNewClientVersionDirectory = new System.Windows.Forms.PictureBox();
            this.clientVersionCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.connection = new System.Windows.Forms.Button();
            this.Ip = new System.Windows.Forms.TextBox();
            this.DB = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addNewClientVersionDirectory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addNewClientVersionDirectory);
            this.panel1.Controls.Add(this.clientVersionCB);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.connection);
            this.panel1.Controls.Add(this.Ip);
            this.panel1.Controls.Add(this.DB);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 215);
            this.panel1.TabIndex = 0;
            // 
            // addNewClientVersionDirectory
            // 
            this.addNewClientVersionDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewClientVersionDirectory.Image = global::SpellEffect.Properties.Resources.addNewClientVersionSprites;
            this.addNewClientVersionDirectory.Location = new System.Drawing.Point(278, 149);
            this.addNewClientVersionDirectory.Name = "addNewClientVersionDirectory";
            this.addNewClientVersionDirectory.Size = new System.Drawing.Size(15, 14);
            this.addNewClientVersionDirectory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.addNewClientVersionDirectory.TabIndex = 13;
            this.addNewClientVersionDirectory.TabStop = false;
            this.addNewClientVersionDirectory.Click += new System.EventHandler(this.addNewClientVersionDirectory_Click);
            // 
            // clientVersionCB
            // 
            this.clientVersionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientVersionCB.FormattingEnabled = true;
            this.clientVersionCB.Items.AddRange(new object[] {
            "Par défaut (2.10)"});
            this.clientVersionCB.Location = new System.Drawing.Point(155, 142);
            this.clientVersionCB.Name = "clientVersionCB";
            this.clientVersionCB.Size = new System.Drawing.Size(112, 21);
            this.clientVersionCB.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Version client Dofus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(189, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "By : Th3-m0RpH3R";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // connection
            // 
            this.connection.Location = new System.Drawing.Point(107, 175);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(75, 23);
            this.connection.TabIndex = 9;
            this.connection.Text = "Connexion";
            this.connection.UseVisualStyleBackColor = true;
            this.connection.Click += new System.EventHandler(this.connection_Click);
            // 
            // Ip
            // 
            this.Ip.Location = new System.Drawing.Point(155, 39);
            this.Ip.Name = "Ip";
            this.Ip.Size = new System.Drawing.Size(100, 20);
            this.Ip.TabIndex = 8;
            this.Ip.Text = "localhost";
            // 
            // DB
            // 
            this.DB.Location = new System.Drawing.Point(155, 113);
            this.DB.Name = "DB";
            this.DB.Size = new System.Drawing.Size(100, 20);
            this.DB.TabIndex = 7;
            this.DB.Text = "world";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(155, 89);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 6;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(155, 65);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 5;
            this.username.Text = "root";
            this.username.KeyUp += new System.Windows.Forms.KeyEventHandler(this.username_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresse IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nom base de donnée";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom d\'utilisateur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(60, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant Base de donnée";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 229);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dofus SpellEffect 1.9";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addNewClientVersionDirectory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button connection;
        private System.Windows.Forms.TextBox Ip;
        private System.Windows.Forms.TextBox DB;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox clientVersionCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox addNewClientVersionDirectory;
    }
}


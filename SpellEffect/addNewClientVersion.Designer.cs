namespace SpellEffect
{
    partial class addNewClientVersion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addNewClientVersion));
            this.decompile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.versionMajeur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.versionMineur = new System.Windows.Forms.ComboBox();
            this.versionRevision = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.globalInfo = new System.Windows.Forms.Label();
            this.progressBarGlobal = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.loadingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // decompile
            // 
            this.decompile.Location = new System.Drawing.Point(98, 75);
            this.decompile.Name = "decompile";
            this.decompile.Size = new System.Drawing.Size(199, 35);
            this.decompile.TabIndex = 13;
            this.decompile.Text = "Decompiler";
            this.decompile.UseVisualStyleBackColor = true;
            this.decompile.Click += new System.EventHandler(this.decompile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(108, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Comment ça marche";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Version du client :";
            // 
            // versionMajeur
            // 
            this.versionMajeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionMajeur.Enabled = false;
            this.versionMajeur.FormattingEnabled = true;
            this.versionMajeur.Items.AddRange(new object[] {
            "2"});
            this.versionMajeur.Location = new System.Drawing.Point(172, 41);
            this.versionMajeur.Name = "versionMajeur";
            this.versionMajeur.Size = new System.Drawing.Size(36, 21);
            this.versionMajeur.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = ".";
            // 
            // versionMineur
            // 
            this.versionMineur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionMineur.FormattingEnabled = true;
            this.versionMineur.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.versionMineur.Location = new System.Drawing.Point(222, 41);
            this.versionMineur.Name = "versionMineur";
            this.versionMineur.Size = new System.Drawing.Size(36, 21);
            this.versionMineur.TabIndex = 18;
            // 
            // versionRevision
            // 
            this.versionRevision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionRevision.FormattingEnabled = true;
            this.versionRevision.Items.AddRange(new object[] {
            "",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.versionRevision.Location = new System.Drawing.Point(270, 41);
            this.versionRevision.Name = "versionRevision";
            this.versionRevision.Size = new System.Drawing.Size(36, 21);
            this.versionRevision.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = ".";
            // 
            // loadingPanel
            // 
            this.loadingPanel.Controls.Add(this.globalInfo);
            this.loadingPanel.Controls.Add(this.progressBarGlobal);
            this.loadingPanel.Controls.Add(this.label5);
            this.loadingPanel.Location = new System.Drawing.Point(10, 120);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(379, 67);
            this.loadingPanel.TabIndex = 21;
            // 
            // globalInfo
            // 
            this.globalInfo.AutoSize = true;
            this.globalInfo.Location = new System.Drawing.Point(173, 19);
            this.globalInfo.Name = "globalInfo";
            this.globalInfo.Size = new System.Drawing.Size(16, 13);
            this.globalInfo.TabIndex = 4;
            this.globalInfo.Text = "...";
            // 
            // progressBarGlobal
            // 
            this.progressBarGlobal.Location = new System.Drawing.Point(6, 37);
            this.progressBarGlobal.Name = "progressBarGlobal";
            this.progressBarGlobal.Size = new System.Drawing.Size(370, 17);
            this.progressBarGlobal.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Patientez svp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(253, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // addNewClientVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 118);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loadingPanel);
            this.Controls.Add(this.versionRevision);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.versionMineur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.versionMajeur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decompile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addNewClientVersion";
            this.Text = "Ajouter une nouvelle version de client";
            this.Load += new System.EventHandler(this.addNewClientVersion_Load);
            this.loadingPanel.ResumeLayout(false);
            this.loadingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button decompile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox versionMajeur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox versionMineur;
        private System.Windows.Forms.ComboBox versionRevision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label globalInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBarGlobal;
    }
}
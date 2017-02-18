namespace SpellEffect
{
    partial class SpellEffect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpellEffect));
            this.label1 = new System.Windows.Forms.Label();
            this.sortID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tuto2 = new System.Windows.Forms.Label();
            this.tuto1 = new System.Windows.Forms.Label();
            this.spellLevelL = new System.Windows.Forms.Label();
            this.chooseSpell = new System.Windows.Forms.Button();
            this.SpellPicture = new System.Windows.Forms.PictureBox();
            this.editSpell = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpellPicture)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SortID";
            // 
            // sortID
            // 
            this.sortID.Location = new System.Drawing.Point(55, 10);
            this.sortID.Name = "sortID";
            this.sortID.Size = new System.Drawing.Size(43, 20);
            this.sortID.TabIndex = 1;
            this.sortID.TextChanged += new System.EventHandler(this.sortID_TextChanged);
            this.sortID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sortID_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tuto2);
            this.panel1.Controls.Add(this.tuto1);
            this.panel1.Controls.Add(this.spellLevelL);
            this.panel1.Controls.Add(this.chooseSpell);
            this.panel1.Controls.Add(this.SpellPicture);
            this.panel1.Controls.Add(this.editSpell);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sortID);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 46);
            this.panel1.TabIndex = 2;
            // 
            // tuto2
            // 
            this.tuto2.AutoSize = true;
            this.tuto2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tuto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuto2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tuto2.Location = new System.Drawing.Point(506, 14);
            this.tuto2.Name = "tuto2";
            this.tuto2.Size = new System.Drawing.Size(47, 15);
            this.tuto2.TabIndex = 6;
            this.tuto2.Text = "Tuto 2";
            this.tuto2.Click += new System.EventHandler(this.tuto2_Click);
            // 
            // tuto1
            // 
            this.tuto1.AutoSize = true;
            this.tuto1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tuto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuto1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tuto1.Location = new System.Drawing.Point(451, 14);
            this.tuto1.Name = "tuto1";
            this.tuto1.Size = new System.Drawing.Size(47, 15);
            this.tuto1.TabIndex = 4;
            this.tuto1.Text = "Tuto 1";
            this.tuto1.Click += new System.EventHandler(this.tuto1_Click);
            // 
            // spellLevelL
            // 
            this.spellLevelL.AutoSize = true;
            this.spellLevelL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellLevelL.Location = new System.Drawing.Point(367, 11);
            this.spellLevelL.Name = "spellLevelL";
            this.spellLevelL.Size = new System.Drawing.Size(0, 20);
            this.spellLevelL.TabIndex = 5;
            // 
            // chooseSpell
            // 
            this.chooseSpell.Location = new System.Drawing.Point(268, 10);
            this.chooseSpell.Name = "chooseSpell";
            this.chooseSpell.Size = new System.Drawing.Size(93, 23);
            this.chooseSpell.TabIndex = 4;
            this.chooseSpell.Text = "Choisir le sort";
            this.chooseSpell.UseVisualStyleBackColor = true;
            this.chooseSpell.Click += new System.EventHandler(this.chooseSpell_Click);
            // 
            // SpellPicture
            // 
            this.SpellPicture.Location = new System.Drawing.Point(200, 0);
            this.SpellPicture.Name = "SpellPicture";
            this.SpellPicture.Size = new System.Drawing.Size(42, 22);
            this.SpellPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SpellPicture.TabIndex = 3;
            this.SpellPicture.TabStop = false;
            // 
            // editSpell
            // 
            this.editSpell.Location = new System.Drawing.Point(110, 9);
            this.editSpell.Name = "editSpell";
            this.editSpell.Size = new System.Drawing.Size(75, 23);
            this.editSpell.TabIndex = 2;
            this.editSpell.Text = "Editer";
            this.editSpell.UseVisualStyleBackColor = true;
            this.editSpell.Click += new System.EventHandler(this.editSpell_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 68);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 68);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // SpellEffect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 68);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SpellEffect";
            this.Text = "SpellEffect";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpellPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sortID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editSpell;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox SpellPicture;
        private System.Windows.Forms.Button chooseSpell;
        private System.Windows.Forms.Label spellLevelL;
        private System.Windows.Forms.Label tuto1;
        private System.Windows.Forms.Label tuto2;
    }
}
namespace SpellEffect
{
    partial class SelectionTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionTable));
            this.label1 = new System.Windows.Forms.Label();
            this.tablesName = new System.Windows.Forms.ComboBox();
            this.connexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // tablesName
            // 
            this.tablesName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tablesName.FormattingEnabled = true;
            this.tablesName.Location = new System.Drawing.Point(15, 63);
            this.tablesName.Name = "tablesName";
            this.tablesName.Size = new System.Drawing.Size(166, 21);
            this.tablesName.TabIndex = 2;
            // 
            // connexion
            // 
            this.connexion.Location = new System.Drawing.Point(15, 101);
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(347, 34);
            this.connexion.TabIndex = 3;
            this.connexion.Text = "Connexion";
            this.connexion.UseVisualStyleBackColor = true;
            this.connexion.Click += new System.EventHandler(this.connexion_Click);
            // 
            // SelectionTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 145);
            this.Controls.Add(this.connexion);
            this.Controls.Add(this.tablesName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectionTable";
            this.Text = "SelectionTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tablesName;
        private System.Windows.Forms.Button connexion;
    }
}
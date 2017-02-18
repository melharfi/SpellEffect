namespace SpellEffect
{
    partial class howTo
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
            this.helpPB = new System.Windows.Forms.PictureBox();
            this.description = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.helpPB)).BeginInit();
            this.SuspendLayout();
            // 
            // helpPB
            // 
            this.helpPB.Image = global::SpellEffect.Properties.Resources.howToAddClientVersion;
            this.helpPB.Location = new System.Drawing.Point(-1, 0);
            this.helpPB.Name = "helpPB";
            this.helpPB.Size = new System.Drawing.Size(1040, 539);
            this.helpPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.helpPB.TabIndex = 1;
            this.helpPB.TabStop = false;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Green;
            this.description.Location = new System.Drawing.Point(3, 537);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(20, 16);
            this.description.TabIndex = 2;
            this.description.Text = "...";
            // 
            // howTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 571);
            this.Controls.Add(this.description);
            this.Controls.Add(this.helpPB);
            this.Name = "howTo";
            this.Text = "howToAddNewClientVersion";
            this.Load += new System.EventHandler(this.howTo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.helpPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox helpPB;
        private System.Windows.Forms.Label description;
    }
}
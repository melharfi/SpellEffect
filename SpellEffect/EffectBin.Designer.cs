namespace SpellEffect
{
    partial class EffectBin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EffectBin));
            this.EffectBinHex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modifyHex = new System.Windows.Forms.Button();
            this.SaveHexa = new System.Windows.Forms.Button();
            this.HexValuePanel = new System.Windows.Forms.Panel();
            this.HexValue = new System.Windows.Forms.RadioButton();
            this.paramsValue = new System.Windows.Forms.RadioButton();
            this.ParamsValuePanel = new System.Windows.Forms.Panel();
            this.SaveBtn2 = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.HexValuePanel.SuspendLayout();
            this.ParamsValuePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EffectBinHex
            // 
            this.EffectBinHex.Enabled = false;
            this.EffectBinHex.Location = new System.Drawing.Point(14, 55);
            this.EffectBinHex.Multiline = true;
            this.EffectBinHex.Name = "EffectBinHex";
            this.EffectBinHex.Size = new System.Drawing.Size(523, 87);
            this.EffectBinHex.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "EffectBin en Héxadecimal";
            // 
            // modifyHex
            // 
            this.modifyHex.Location = new System.Drawing.Point(177, 24);
            this.modifyHex.Name = "modifyHex";
            this.modifyHex.Size = new System.Drawing.Size(103, 23);
            this.modifyHex.TabIndex = 2;
            this.modifyHex.Text = "Modifier";
            this.modifyHex.UseVisualStyleBackColor = true;
            this.modifyHex.Click += new System.EventHandler(this.modifyHex_Click);
            // 
            // SaveHexa
            // 
            this.SaveHexa.Enabled = false;
            this.SaveHexa.Location = new System.Drawing.Point(310, 24);
            this.SaveHexa.Name = "SaveHexa";
            this.SaveHexa.Size = new System.Drawing.Size(101, 23);
            this.SaveHexa.TabIndex = 3;
            this.SaveHexa.Text = "Sauveguarder";
            this.SaveHexa.UseVisualStyleBackColor = true;
            this.SaveHexa.Click += new System.EventHandler(this.SaveHexa_Click);
            // 
            // HexValuePanel
            // 
            this.HexValuePanel.Controls.Add(this.modifyHex);
            this.HexValuePanel.Controls.Add(this.SaveHexa);
            this.HexValuePanel.Controls.Add(this.EffectBinHex);
            this.HexValuePanel.Controls.Add(this.label1);
            this.HexValuePanel.Enabled = false;
            this.HexValuePanel.Location = new System.Drawing.Point(12, 25);
            this.HexValuePanel.Name = "HexValuePanel";
            this.HexValuePanel.Size = new System.Drawing.Size(558, 156);
            this.HexValuePanel.TabIndex = 4;
            // 
            // HexValue
            // 
            this.HexValue.AutoSize = true;
            this.HexValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexValue.ForeColor = System.Drawing.Color.DarkRed;
            this.HexValue.Location = new System.Drawing.Point(16, 4);
            this.HexValue.Name = "HexValue";
            this.HexValue.Size = new System.Drawing.Size(180, 20);
            this.HexValue.TabIndex = 5;
            this.HexValue.TabStop = true;
            this.HexValue.Text = "Modifier la valeur Raw";
            this.HexValue.UseVisualStyleBackColor = true;
            this.HexValue.CheckedChanged += new System.EventHandler(this.HexValue_CheckedChanged);
            // 
            // paramsValue
            // 
            this.paramsValue.AutoSize = true;
            this.paramsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paramsValue.ForeColor = System.Drawing.Color.DarkRed;
            this.paramsValue.Location = new System.Drawing.Point(16, 190);
            this.paramsValue.Name = "paramsValue";
            this.paramsValue.Size = new System.Drawing.Size(190, 20);
            this.paramsValue.TabIndex = 6;
            this.paramsValue.TabStop = true;
            this.paramsValue.Text = "Modifier les parametres";
            this.paramsValue.UseVisualStyleBackColor = true;
            this.paramsValue.CheckedChanged += new System.EventHandler(this.paramsValue_CheckedChanged);
            // 
            // ParamsValuePanel
            // 
            this.ParamsValuePanel.Controls.Add(this.SaveBtn2);
            this.ParamsValuePanel.Enabled = false;
            this.ParamsValuePanel.Location = new System.Drawing.Point(12, 216);
            this.ParamsValuePanel.Name = "ParamsValuePanel";
            this.ParamsValuePanel.Size = new System.Drawing.Size(558, 346);
            this.ParamsValuePanel.TabIndex = 7;
            // 
            // SaveBtn2
            // 
            this.SaveBtn2.Location = new System.Drawing.Point(159, 312);
            this.SaveBtn2.Name = "SaveBtn2";
            this.SaveBtn2.Size = new System.Drawing.Size(230, 23);
            this.SaveBtn2.TabIndex = 1;
            this.SaveBtn2.Text = "Enregistrer";
            this.SaveBtn2.UseVisualStyleBackColor = true;
            this.SaveBtn2.Click += new System.EventHandler(this.SaveBtn2_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Green;
            this.description.Location = new System.Drawing.Point(272, 192);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(87, 16);
            this.description.TabIndex = 8;
            this.description.Text = "Description";
            // 
            // EffectBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 562);
            this.Controls.Add(this.description);
            this.Controls.Add(this.ParamsValuePanel);
            this.Controls.Add(this.paramsValue);
            this.Controls.Add(this.HexValue);
            this.Controls.Add(this.HexValuePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EffectBin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EffectBin";
            this.Load += new System.EventHandler(this.EffectBin_Load);
            this.HexValuePanel.ResumeLayout(false);
            this.HexValuePanel.PerformLayout();
            this.ParamsValuePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EffectBinHex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modifyHex;
        private System.Windows.Forms.Button SaveHexa;
        private System.Windows.Forms.Panel HexValuePanel;
        private System.Windows.Forms.RadioButton HexValue;
        private System.Windows.Forms.RadioButton paramsValue;
        private System.Windows.Forms.Panel ParamsValuePanel;
        private System.Windows.Forms.Button SaveBtn2;
        private System.Windows.Forms.Label description;
    }
}
namespace SpellEffect
{
    partial class TargetEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TargetEditor));
            this.ChangeTargetTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.CurrentValueLB = new System.Windows.Forms.ListBox();
            this.AllEnumValuesLB = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Method1Panel = new System.Windows.Forms.Panel();
            this.LeftArrowPB = new System.Windows.Forms.PictureBox();
            this.RightArrowPB = new System.Windows.Forms.PictureBox();
            this.CurrentValueTB = new System.Windows.Forms.TextBox();
            this.Method2Panel = new System.Windows.Forms.Panel();
            this.EditBtn2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Method1Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrowPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightArrowPB)).BeginInit();
            this.Method2Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangeTargetTB
            // 
            this.ChangeTargetTB.Location = new System.Drawing.Point(108, 18);
            this.ChangeTargetTB.Name = "ChangeTargetTB";
            this.ChangeTargetTB.Size = new System.Drawing.Size(80, 20);
            this.ChangeTargetTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Flags";
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EditBtn.Location = new System.Drawing.Point(11, 134);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(445, 28);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "Modifier";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // CurrentValueLB
            // 
            this.CurrentValueLB.FormattingEnabled = true;
            this.CurrentValueLB.Location = new System.Drawing.Point(11, 33);
            this.CurrentValueLB.Name = "CurrentValueLB";
            this.CurrentValueLB.Size = new System.Drawing.Size(215, 95);
            this.CurrentValueLB.TabIndex = 6;
            // 
            // AllEnumValuesLB
            // 
            this.AllEnumValuesLB.FormattingEnabled = true;
            this.AllEnumValuesLB.Location = new System.Drawing.Point(252, 33);
            this.AllEnumValuesLB.Name = "AllEnumValuesLB";
            this.AllEnumValuesLB.Size = new System.Drawing.Size(204, 95);
            this.AllEnumValuesLB.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(254, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Avalaible Flags";
            // 
            // Method1Panel
            // 
            this.Method1Panel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Method1Panel.Controls.Add(this.LeftArrowPB);
            this.Method1Panel.Controls.Add(this.RightArrowPB);
            this.Method1Panel.Controls.Add(this.CurrentValueTB);
            this.Method1Panel.Controls.Add(this.label2);
            this.Method1Panel.Controls.Add(this.label1);
            this.Method1Panel.Controls.Add(this.AllEnumValuesLB);
            this.Method1Panel.Controls.Add(this.EditBtn);
            this.Method1Panel.Controls.Add(this.CurrentValueLB);
            this.Method1Panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Method1Panel.Enabled = false;
            this.Method1Panel.Location = new System.Drawing.Point(12, 39);
            this.Method1Panel.Name = "Method1Panel";
            this.Method1Panel.Size = new System.Drawing.Size(467, 175);
            this.Method1Panel.TabIndex = 9;
            // 
            // LeftArrowPB
            // 
            this.LeftArrowPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftArrowPB.Image = global::SpellEffect.Properties.Resources.Leftarrow;
            this.LeftArrowPB.Location = new System.Drawing.Point(229, 54);
            this.LeftArrowPB.Name = "LeftArrowPB";
            this.LeftArrowPB.Size = new System.Drawing.Size(20, 21);
            this.LeftArrowPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LeftArrowPB.TabIndex = 11;
            this.LeftArrowPB.TabStop = false;
            this.LeftArrowPB.Click += new System.EventHandler(this.LeftArrowPB_Click);
            // 
            // RightArrowPB
            // 
            this.RightArrowPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RightArrowPB.Image = global::SpellEffect.Properties.Resources.Rightarrow;
            this.RightArrowPB.Location = new System.Drawing.Point(229, 81);
            this.RightArrowPB.Name = "RightArrowPB";
            this.RightArrowPB.Size = new System.Drawing.Size(20, 21);
            this.RightArrowPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RightArrowPB.TabIndex = 10;
            this.RightArrowPB.TabStop = false;
            this.RightArrowPB.Click += new System.EventHandler(this.RightArrowPB_Click);
            // 
            // CurrentValueTB
            // 
            this.CurrentValueTB.Enabled = false;
            this.CurrentValueTB.Location = new System.Drawing.Point(140, 10);
            this.CurrentValueTB.Name = "CurrentValueTB";
            this.CurrentValueTB.Size = new System.Drawing.Size(86, 20);
            this.CurrentValueTB.TabIndex = 9;
            // 
            // Method2Panel
            // 
            this.Method2Panel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Method2Panel.Controls.Add(this.EditBtn2);
            this.Method2Panel.Controls.Add(this.label3);
            this.Method2Panel.Controls.Add(this.ChangeTargetTB);
            this.Method2Panel.Enabled = false;
            this.Method2Panel.Location = new System.Drawing.Point(12, 248);
            this.Method2Panel.Name = "Method2Panel";
            this.Method2Panel.Size = new System.Drawing.Size(467, 55);
            this.Method2Panel.TabIndex = 10;
            // 
            // EditBtn2
            // 
            this.EditBtn2.BackColor = System.Drawing.Color.DarkOrange;
            this.EditBtn2.Location = new System.Drawing.Point(197, 13);
            this.EditBtn2.Name = "EditBtn2";
            this.EditBtn2.Size = new System.Drawing.Size(259, 30);
            this.EditBtn2.TabIndex = 3;
            this.EditBtn2.Text = "Modifier";
            this.EditBtn2.UseVisualStyleBackColor = false;
            this.EditBtn2.Click += new System.EventHandler(this.EditBtn2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Flag Target";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Method 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 222);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Method 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // TargetEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 317);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Method2Panel);
            this.Controls.Add(this.Method1Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TargetEditor";
            this.Text = "TargetEditor";
            this.Method1Panel.ResumeLayout(false);
            this.Method1Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrowPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightArrowPB)).EndInit();
            this.Method2Panel.ResumeLayout(false);
            this.Method2Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ChangeTargetTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.ListBox CurrentValueLB;
        private System.Windows.Forms.ListBox AllEnumValuesLB;
        private System.Windows.Forms.Panel Method1Panel;
        private System.Windows.Forms.Panel Method2Panel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CurrentValueTB;
        private System.Windows.Forms.PictureBox RightArrowPB;
        private System.Windows.Forms.PictureBox LeftArrowPB;
        private System.Windows.Forms.Button EditBtn2;
        private System.Windows.Forms.Label label3;
    }
}
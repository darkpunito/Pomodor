namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.optionsworkminuteschoice = new System.Windows.Forms.NumericUpDown();
            this.optionsworksecondschoice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.optionsButtonSubmit = new System.Windows.Forms.Button();
            this.optionsWorkLabel = new System.Windows.Forms.Label();
            this.optionsRestLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.optionsrestminuteschoice = new System.Windows.Forms.NumericUpDown();
            this.optionsrestsecondschoice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.optionsWorkSessionsChoice = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.choiceOptions = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.optionsworkminuteschoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsworksecondschoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsrestminuteschoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsrestsecondschoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsWorkSessionsChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // optionsworkminuteschoice
            // 
            this.optionsworkminuteschoice.Location = new System.Drawing.Point(71, 32);
            this.optionsworkminuteschoice.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.optionsworkminuteschoice.Name = "optionsworkminuteschoice";
            this.optionsworkminuteschoice.Size = new System.Drawing.Size(120, 20);
            this.optionsworkminuteschoice.TabIndex = 0;
            this.optionsworkminuteschoice.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // optionsworksecondschoice
            // 
            this.optionsworksecondschoice.Location = new System.Drawing.Point(71, 58);
            this.optionsworksecondschoice.Name = "optionsworksecondschoice";
            this.optionsworksecondschoice.Size = new System.Drawing.Size(120, 20);
            this.optionsworksecondschoice.TabIndex = 1;
            this.optionsworksecondschoice.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "seconds";
            // 
            // optionsButtonSubmit
            // 
            this.optionsButtonSubmit.Location = new System.Drawing.Point(104, 226);
            this.optionsButtonSubmit.Name = "optionsButtonSubmit";
            this.optionsButtonSubmit.Size = new System.Drawing.Size(75, 23);
            this.optionsButtonSubmit.TabIndex = 4;
            this.optionsButtonSubmit.Text = "OK";
            this.optionsButtonSubmit.UseVisualStyleBackColor = true;
            this.optionsButtonSubmit.Click += new System.EventHandler(this.optionsButton_Click_1);
            // 
            // optionsWorkLabel
            // 
            this.optionsWorkLabel.AutoSize = true;
            this.optionsWorkLabel.Location = new System.Drawing.Point(15, 13);
            this.optionsWorkLabel.Name = "optionsWorkLabel";
            this.optionsWorkLabel.Size = new System.Drawing.Size(33, 13);
            this.optionsWorkLabel.TabIndex = 5;
            this.optionsWorkLabel.Text = "Work";
            // 
            // optionsRestLabel
            // 
            this.optionsRestLabel.AutoSize = true;
            this.optionsRestLabel.Location = new System.Drawing.Point(15, 98);
            this.optionsRestLabel.Name = "optionsRestLabel";
            this.optionsRestLabel.Size = new System.Drawing.Size(29, 13);
            this.optionsRestLabel.TabIndex = 6;
            this.optionsRestLabel.Text = "Rest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "seconds";
            // 
            // optionsrestminuteschoice
            // 
            this.optionsrestminuteschoice.Location = new System.Drawing.Point(71, 122);
            this.optionsrestminuteschoice.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.optionsrestminuteschoice.Name = "optionsrestminuteschoice";
            this.optionsrestminuteschoice.Size = new System.Drawing.Size(120, 20);
            this.optionsrestminuteschoice.TabIndex = 9;
            this.optionsrestminuteschoice.ValueChanged += new System.EventHandler(this.optionsrestminuteschoice_ValueChanged);
            // 
            // optionsrestsecondschoice
            // 
            this.optionsrestsecondschoice.Location = new System.Drawing.Point(71, 148);
            this.optionsrestsecondschoice.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.optionsrestsecondschoice.Name = "optionsrestsecondschoice";
            this.optionsrestsecondschoice.Size = new System.Drawing.Size(120, 20);
            this.optionsrestsecondschoice.TabIndex = 10;
            this.optionsrestsecondschoice.ValueChanged += new System.EventHandler(this.optionsrestsecondschoice_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sessions";
            // 
            // optionsWorkSessionsChoice
            // 
            this.optionsWorkSessionsChoice.Location = new System.Drawing.Point(71, 192);
            this.optionsWorkSessionsChoice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.optionsWorkSessionsChoice.Name = "optionsWorkSessionsChoice";
            this.optionsWorkSessionsChoice.Size = new System.Drawing.Size(120, 20);
            this.optionsWorkSessionsChoice.TabIndex = 12;
            this.optionsWorkSessionsChoice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.optionsWorkSessionsChoice.ValueChanged += new System.EventHandler(this.optionsWorkSessionsChoice_ValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "cycling",
            "mega",
            "ultra",
            "power"});
            this.listBox1.Location = new System.Drawing.Point(219, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // choiceOptions
            // 
            this.choiceOptions.Location = new System.Drawing.Point(243, 39);
            this.choiceOptions.Name = "choiceOptions";
            this.choiceOptions.Size = new System.Drawing.Size(120, 20);
            this.choiceOptions.TabIndex = 15;
            this.choiceOptions.ValueChanged += new System.EventHandler(this.choiceOptions_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 261);
            this.Controls.Add(this.choiceOptions);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.optionsWorkSessionsChoice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.optionsrestsecondschoice);
            this.Controls.Add(this.optionsrestminuteschoice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.optionsRestLabel);
            this.Controls.Add(this.optionsWorkLabel);
            this.Controls.Add(this.optionsButtonSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optionsworksecondschoice);
            this.Controls.Add(this.optionsworkminuteschoice);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.optionsworkminuteschoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsworksecondschoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsrestminuteschoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsrestsecondschoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsWorkSessionsChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceOptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown optionsworkminuteschoice;
        private System.Windows.Forms.NumericUpDown optionsworksecondschoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button optionsButtonSubmit;
        private System.Windows.Forms.Label optionsWorkLabel;
        private System.Windows.Forms.Label optionsRestLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown optionsrestminuteschoice;
        private System.Windows.Forms.NumericUpDown optionsrestsecondschoice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown optionsWorkSessionsChoice;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown choiceOptions;
    }
}
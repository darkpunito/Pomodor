namespace WindowsFormsApplication1
{
    partial class MainWin
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
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabelWork = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timeLabelRest = new System.Windows.Forms.Label();
            this.optionsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(144, 164);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(219, 43);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabelWork
            // 
            this.timeLabelWork.BackColor = System.Drawing.SystemColors.Window;
            this.timeLabelWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabelWork.Location = new System.Drawing.Point(68, 45);
            this.timeLabelWork.Name = "timeLabelWork";
            this.timeLabelWork.Size = new System.Drawing.Size(119, 93);
            this.timeLabelWork.TabIndex = 1;
            this.timeLabelWork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeLabelWork.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timeLabelRest
            // 
            this.timeLabelRest.BackColor = System.Drawing.SystemColors.Window;
            this.timeLabelRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabelRest.Location = new System.Drawing.Point(323, 45);
            this.timeLabelRest.Name = "timeLabelRest";
            this.timeLabelRest.Size = new System.Drawing.Size(119, 93);
            this.timeLabelRest.TabIndex = 2;
            this.timeLabelRest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionsButton
            // 
            this.optionsButton.Location = new System.Drawing.Point(181, 13);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(148, 29);
            this.optionsButton.TabIndex = 3;
            this.optionsButton.Text = "options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 219);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.timeLabelRest);
            this.Controls.Add(this.timeLabelWork);
            this.Controls.Add(this.startButton);
            this.Name = "MainWin";
            this.Text = "MainWin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabelWork;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label timeLabelRest;
        private System.Windows.Forms.Button optionsButton;
    }
}


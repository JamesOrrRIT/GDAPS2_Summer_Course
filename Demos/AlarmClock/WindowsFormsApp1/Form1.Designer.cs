namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.min20 = new System.Windows.Forms.RadioButton();
            this.min30 = new System.Windows.Forms.RadioButton();
            this.min40 = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.min40);
            this.groupBox1.Controls.Add(this.min30);
            this.groupBox1.Controls.Add(this.min20);
            this.groupBox1.Location = new System.Drawing.Point(26, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Time";
            // 
            // min20
            // 
            this.min20.AutoSize = true;
            this.min20.Checked = true;
            this.min20.Location = new System.Drawing.Point(7, 20);
            this.min20.Name = "min20";
            this.min20.Size = new System.Drawing.Size(77, 17);
            this.min20.TabIndex = 0;
            this.min20.TabStop = true;
            this.min20.Text = "20 Minutes";
            this.min20.UseVisualStyleBackColor = true;
            // 
            // min30
            // 
            this.min30.AutoSize = true;
            this.min30.Location = new System.Drawing.Point(141, 20);
            this.min30.Name = "min30";
            this.min30.Size = new System.Drawing.Size(77, 17);
            this.min30.TabIndex = 1;
            this.min30.TabStop = true;
            this.min30.Text = "30 Minutes";
            this.min30.UseVisualStyleBackColor = true;
            // 
            // min40
            // 
            this.min40.AutoSize = true;
            this.min40.Location = new System.Drawing.Point(284, 20);
            this.min40.Name = "min40";
            this.min40.Size = new System.Drawing.Size(77, 17);
            this.min40.TabIndex = 2;
            this.min40.TabStop = true;
            this.min40.Text = "40 Minutes";
            this.min40.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(49, 85);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(316, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(49, 148);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(102, 36);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(263, 148);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(102, 36);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 201);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton min40;
        private System.Windows.Forms.RadioButton min30;
        private System.Windows.Forms.RadioButton min20;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer timer1;
    }
}


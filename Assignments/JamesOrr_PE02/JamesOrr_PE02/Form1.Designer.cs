namespace JamesOrr_PE02
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
            this.assignmentLabel = new System.Windows.Forms.Label();
            this.assignmentText = new System.Windows.Forms.Label();
            this.elementLabel = new System.Windows.Forms.Label();
            this.elementText = new System.Windows.Forms.Label();
            this.solutionLabel = new System.Windows.Forms.Label();
            this.solutionTextBox = new System.Windows.Forms.TextBox();
            this.timerLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // assignmentLabel
            // 
            this.assignmentLabel.AutoSize = true;
            this.assignmentLabel.Location = new System.Drawing.Point(12, 9);
            this.assignmentLabel.Name = "assignmentLabel";
            this.assignmentLabel.Size = new System.Drawing.Size(84, 16);
            this.assignmentLabel.TabIndex = 0;
            this.assignmentLabel.Text = "Assignment :";
            // 
            // assignmentText
            // 
            this.assignmentText.AutoSize = true;
            this.assignmentText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assignmentText.Location = new System.Drawing.Point(12, 36);
            this.assignmentText.Name = "assignmentText";
            this.assignmentText.Size = new System.Drawing.Size(195, 98);
            this.assignmentText.TabIndex = 1;
            this.assignmentText.Text = "*The assignment will fill this box\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // elementLabel
            // 
            this.elementLabel.AutoSize = true;
            this.elementLabel.Location = new System.Drawing.Point(345, 9);
            this.elementLabel.Name = "elementLabel";
            this.elementLabel.Size = new System.Drawing.Size(120, 16);
            this.elementLabel.TabIndex = 2;
            this.elementLabel.Text = "Unstable Element :";
            // 
            // elementText
            // 
            this.elementText.AutoSize = true;
            this.elementText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elementText.Location = new System.Drawing.Point(348, 36);
            this.elementText.Name = "elementText";
            this.elementText.Size = new System.Drawing.Size(228, 98);
            this.elementText.TabIndex = 3;
            this.elementText.Text = "*The unstable element will fill this box\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // solutionLabel
            // 
            this.solutionLabel.AutoSize = true;
            this.solutionLabel.Location = new System.Drawing.Point(12, 216);
            this.solutionLabel.Name = "solutionLabel";
            this.solutionLabel.Size = new System.Drawing.Size(142, 16);
            this.solutionLabel.TabIndex = 4;
            this.solutionLabel.Text = "Enter your plan below :";
            // 
            // solutionTextBox
            // 
            this.solutionTextBox.Location = new System.Drawing.Point(15, 235);
            this.solutionTextBox.Name = "solutionTextBox";
            this.solutionTextBox.Size = new System.Drawing.Size(516, 22);
            this.solutionTextBox.TabIndex = 5;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(252, 216);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(279, 16);
            this.timerLabel.TabIndex = 6;
            this.timerLabel.Text = "Time Remaining : *15 second timer goes here";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(15, 278);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(101, 35);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit Plan";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(178, 278);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(101, 35);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear Fields";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Score : *The score goes here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(634, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.solutionTextBox);
            this.Controls.Add(this.solutionLabel);
            this.Controls.Add(this.elementText);
            this.Controls.Add(this.elementLabel);
            this.Controls.Add(this.assignmentText);
            this.Controls.Add(this.assignmentLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Mad Scientist University";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label assignmentLabel;
        private System.Windows.Forms.Label assignmentText;
        private System.Windows.Forms.Label elementLabel;
        private System.Windows.Forms.Label elementText;
        private System.Windows.Forms.Label solutionLabel;
        private System.Windows.Forms.TextBox solutionTextBox;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
    }
}


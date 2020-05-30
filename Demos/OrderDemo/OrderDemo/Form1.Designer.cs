namespace OrderDemo
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paypalButton = new System.Windows.Forms.RadioButton();
            this.creditButton = new System.Windows.Forms.RadioButton();
            this.checkButton = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.blueBox = new System.Windows.Forms.CheckBox();
            this.redBox = new System.Windows.Forms.CheckBox();
            this.dsBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(121, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(335, 24);
            this.nameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address:";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(121, 45);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(335, 85);
            this.addressBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkButton);
            this.groupBox1.Controls.Add(this.creditButton);
            this.groupBox1.Controls.Add(this.paypalButton);
            this.groupBox1.Location = new System.Drawing.Point(57, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 55);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Method";
            // 
            // paypalButton
            // 
            this.paypalButton.AutoSize = true;
            this.paypalButton.Location = new System.Drawing.Point(18, 23);
            this.paypalButton.Name = "paypalButton";
            this.paypalButton.Size = new System.Drawing.Size(72, 22);
            this.paypalButton.TabIndex = 0;
            this.paypalButton.Text = "PayPal";
            this.paypalButton.UseVisualStyleBackColor = true;
            // 
            // creditButton
            // 
            this.creditButton.AutoSize = true;
            this.creditButton.Checked = true;
            this.creditButton.Location = new System.Drawing.Point(157, 23);
            this.creditButton.Name = "creditButton";
            this.creditButton.Size = new System.Drawing.Size(101, 22);
            this.creditButton.TabIndex = 1;
            this.creditButton.TabStop = true;
            this.creditButton.Text = "Credit Card";
            this.creditButton.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            this.checkButton.AutoSize = true;
            this.checkButton.Location = new System.Drawing.Point(312, 23);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(69, 22);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "Boots",
            "Shields",
            "TIE Fighter",
            "Missiles",
            "Turbolaser Turret",
            "Star Destroyer",
            "Heavy Blaster"});
            this.listBox1.Location = new System.Drawing.Point(57, 255);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(149, 112);
            this.listBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Items:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select Bonus Items";
            // 
            // blueBox
            // 
            this.blueBox.AutoSize = true;
            this.blueBox.Location = new System.Drawing.Point(280, 255);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(127, 22);
            this.blueBox.TabIndex = 8;
            this.blueBox.Text = "Blue light saber";
            this.blueBox.UseVisualStyleBackColor = true;
            // 
            // redBox
            // 
            this.redBox.AutoSize = true;
            this.redBox.Location = new System.Drawing.Point(280, 284);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(125, 22);
            this.redBox.TabIndex = 9;
            this.redBox.Text = "Red light saber";
            this.redBox.UseVisualStyleBackColor = true;
            // 
            // dsBox
            // 
            this.dsBox.AutoSize = true;
            this.dsBox.Location = new System.Drawing.Point(280, 313);
            this.dsBox.Name = "dsBox";
            this.dsBox.Size = new System.Drawing.Size(97, 22);
            this.dsBox.TabIndex = 10;
            this.dsBox.Text = "Death Star";
            this.dsBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(364, 364);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 24);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Deliver On:";
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(60, 409);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(117, 47);
            this.orderButton.TabIndex = 13;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(484, 409);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(117, 47);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 486);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dsBox);
            this.Controls.Add(this.redBox);
            this.Controls.Add(this.blueBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Order System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton checkButton;
        private System.Windows.Forms.RadioButton creditButton;
        private System.Windows.Forms.RadioButton paypalButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox blueBox;
        private System.Windows.Forms.CheckBox redBox;
        private System.Windows.Forms.CheckBox dsBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button clearButton;
    }
}


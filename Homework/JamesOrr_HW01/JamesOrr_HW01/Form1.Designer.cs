namespace JamesOrr_HW01
{
    partial class windowForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.helloUserLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.orderDetails = new System.Windows.Forms.GroupBox();
            this.deliveryInstructions = new System.Windows.Forms.Label();
            this.groupDeliveryLabel = new System.Windows.Forms.Label();
            this.groupProductLabel = new System.Windows.Forms.Label();
            this.groupBoxDate = new System.Windows.Forms.Label();
            this.groupPayLabel = new System.Windows.Forms.Label();
            this.groupBoxName = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.nameButton = new System.Windows.Forms.Button();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.otherOptionTextBox = new System.Windows.Forms.TextBox();
            this.otherOptionRadio = new System.Windows.Forms.RadioButton();
            this.paypalRadio = new System.Windows.Forms.RadioButton();
            this.creditRadio = new System.Windows.Forms.RadioButton();
            this.cashRadio = new System.Windows.Forms.RadioButton();
            this.productLabel = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.quantitySelect = new System.Windows.Forms.NumericUpDown();
            this.confirmProductButton = new System.Windows.Forms.Button();
            this.selectDate = new System.Windows.Forms.DateTimePicker();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.instructionTextBox = new System.Windows.Forms.TextBox();
            this.deliveryButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.confirmOrderButton = new System.Windows.Forms.Button();
            this.isOrderReadyLabel = new System.Windows.Forms.Label();
            this.endProgramButton = new System.Windows.Forms.Button();
            this.orderDetails.SuspendLayout();
            this.paymentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 21;
            // 
            // helloUserLabel
            // 
            this.helloUserLabel.AutoSize = true;
            this.helloUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloUserLabel.Location = new System.Drawing.Point(13, 13);
            this.helloUserLabel.Name = "helloUserLabel";
            this.helloUserLabel.Size = new System.Drawing.Size(425, 20);
            this.helloUserLabel.TabIndex = 4;
            this.helloUserLabel.Text = "Please fill out the following information to submit your order.";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(14, 293);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(174, 13);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Select a date for your item to arrive:";
            // 
            // orderDetails
            // 
            this.orderDetails.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.orderDetails.Controls.Add(this.deliveryInstructions);
            this.orderDetails.Controls.Add(this.groupDeliveryLabel);
            this.orderDetails.Controls.Add(this.groupProductLabel);
            this.orderDetails.Controls.Add(this.groupBoxDate);
            this.orderDetails.Controls.Add(this.groupPayLabel);
            this.orderDetails.Controls.Add(this.groupBoxName);
            this.orderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetails.Location = new System.Drawing.Point(380, 41);
            this.orderDetails.Name = "orderDetails";
            this.orderDetails.Size = new System.Drawing.Size(293, 222);
            this.orderDetails.TabIndex = 7;
            this.orderDetails.TabStop = false;
            this.orderDetails.Text = "Order Details";
            // 
            // deliveryInstructions
            // 
            this.deliveryInstructions.AutoSize = true;
            this.deliveryInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryInstructions.Location = new System.Drawing.Point(5, 145);
            this.deliveryInstructions.Name = "deliveryInstructions";
            this.deliveryInstructions.Size = new System.Drawing.Size(0, 15);
            this.deliveryInstructions.TabIndex = 5;
            // 
            // groupDeliveryLabel
            // 
            this.groupDeliveryLabel.AutoSize = true;
            this.groupDeliveryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDeliveryLabel.Location = new System.Drawing.Point(5, 120);
            this.groupDeliveryLabel.Name = "groupDeliveryLabel";
            this.groupDeliveryLabel.Size = new System.Drawing.Size(59, 15);
            this.groupDeliveryLabel.TabIndex = 4;
            this.groupDeliveryLabel.Text = "Delivery : ";
            // 
            // groupProductLabel
            // 
            this.groupProductLabel.AutoSize = true;
            this.groupProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupProductLabel.Location = new System.Drawing.Point(5, 95);
            this.groupProductLabel.Name = "groupProductLabel";
            this.groupProductLabel.Size = new System.Drawing.Size(55, 15);
            this.groupProductLabel.TabIndex = 3;
            this.groupProductLabel.Text = "Product :";
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.AutoSize = true;
            this.groupBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDate.Location = new System.Drawing.Point(5, 70);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(88, 15);
            this.groupBoxDate.TabIndex = 2;
            this.groupBoxDate.Text = "Date of Arrival :";
            // 
            // groupPayLabel
            // 
            this.groupPayLabel.AutoSize = true;
            this.groupPayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPayLabel.Location = new System.Drawing.Point(5, 45);
            this.groupPayLabel.Name = "groupPayLabel";
            this.groupPayLabel.Size = new System.Drawing.Size(109, 15);
            this.groupPayLabel.TabIndex = 1;
            this.groupPayLabel.Text = "Payment Method : ";
            // 
            // groupBoxName
            // 
            this.groupBoxName.AutoSize = true;
            this.groupBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxName.Location = new System.Drawing.Point(5, 20);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.Size = new System.Drawing.Size(47, 15);
            this.groupBoxName.TabIndex = 0;
            this.groupBoxName.Text = "Name :";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(61, 46);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(139, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(14, 49);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(41, 13);
            this.userNameLabel.TabIndex = 9;
            this.userNameLabel.Text = "Name :";
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(206, 46);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(67, 20);
            this.nameButton.TabIndex = 10;
            this.nameButton.Text = "Confirm";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.paymentGroupBox.Controls.Add(this.otherOptionTextBox);
            this.paymentGroupBox.Controls.Add(this.otherOptionRadio);
            this.paymentGroupBox.Controls.Add(this.paypalRadio);
            this.paymentGroupBox.Controls.Add(this.creditRadio);
            this.paymentGroupBox.Controls.Add(this.cashRadio);
            this.paymentGroupBox.Location = new System.Drawing.Point(17, 155);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Size = new System.Drawing.Size(200, 108);
            this.paymentGroupBox.TabIndex = 11;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Text = "Please select a Payment Method";
            // 
            // otherOptionTextBox
            // 
            this.otherOptionTextBox.Location = new System.Drawing.Point(60, 88);
            this.otherOptionTextBox.Name = "otherOptionTextBox";
            this.otherOptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.otherOptionTextBox.TabIndex = 4;
            // 
            // otherOptionRadio
            // 
            this.otherOptionRadio.AutoSize = true;
            this.otherOptionRadio.Location = new System.Drawing.Point(7, 88);
            this.otherOptionRadio.Name = "otherOptionRadio";
            this.otherOptionRadio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.otherOptionRadio.Size = new System.Drawing.Size(57, 17);
            this.otherOptionRadio.TabIndex = 3;
            this.otherOptionRadio.Text = "Other :";
            this.otherOptionRadio.UseVisualStyleBackColor = true;
            this.otherOptionRadio.CheckedChanged += new System.EventHandler(this.otherOptionRadio_CheckedChanged);
            // 
            // paypalRadio
            // 
            this.paypalRadio.AutoSize = true;
            this.paypalRadio.Location = new System.Drawing.Point(7, 64);
            this.paypalRadio.Name = "paypalRadio";
            this.paypalRadio.Size = new System.Drawing.Size(57, 17);
            this.paypalRadio.TabIndex = 2;
            this.paypalRadio.Text = "Paypal";
            this.paypalRadio.UseVisualStyleBackColor = true;
            this.paypalRadio.CheckedChanged += new System.EventHandler(this.paypalRadio_CheckedChanged);
            // 
            // creditRadio
            // 
            this.creditRadio.AutoSize = true;
            this.creditRadio.Location = new System.Drawing.Point(7, 40);
            this.creditRadio.Name = "creditRadio";
            this.creditRadio.Size = new System.Drawing.Size(88, 17);
            this.creditRadio.TabIndex = 1;
            this.creditRadio.Text = "Credit / Debit";
            this.creditRadio.UseVisualStyleBackColor = true;
            this.creditRadio.CheckedChanged += new System.EventHandler(this.creditRadio_CheckedChanged);
            // 
            // cashRadio
            // 
            this.cashRadio.AutoSize = true;
            this.cashRadio.Location = new System.Drawing.Point(7, 16);
            this.cashRadio.Name = "cashRadio";
            this.cashRadio.Size = new System.Drawing.Size(49, 17);
            this.cashRadio.TabIndex = 0;
            this.cashRadio.Text = "Cash";
            this.cashRadio.UseVisualStyleBackColor = true;
            this.cashRadio.CheckedChanged += new System.EventHandler(this.cashRadio_CheckedChanged);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(14, 96);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(254, 13);
            this.productLabel.TabIndex = 13;
            this.productLabel.Text = "Select a product and how much you want (Max 10) :";
            // 
            // productComboBox
            // 
            this.productComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Items.AddRange(new object[] {
            "",
            "Sketchpad",
            "Magazines",
            "Styrofoam Cooler",
            "Model Airplane",
            "Basketball Shoes",
            "Tin of Butter Cookies",
            "12 of Soda",
            "100 Envelopes w/Stamps",
            "GameMaster Controller",
            "Laptop"});
            this.productComboBox.Location = new System.Drawing.Point(17, 115);
            this.productComboBox.MaxLength = 10;
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(171, 21);
            this.productComboBox.TabIndex = 14;
            // 
            // quantitySelect
            // 
            this.quantitySelect.Location = new System.Drawing.Point(206, 115);
            this.quantitySelect.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.quantitySelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantitySelect.Name = "quantitySelect";
            this.quantitySelect.Size = new System.Drawing.Size(38, 20);
            this.quantitySelect.TabIndex = 15;
            this.quantitySelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // confirmProductButton
            // 
            this.confirmProductButton.Location = new System.Drawing.Point(261, 114);
            this.confirmProductButton.Name = "confirmProductButton";
            this.confirmProductButton.Size = new System.Drawing.Size(67, 20);
            this.confirmProductButton.TabIndex = 16;
            this.confirmProductButton.Text = "Confirm";
            this.confirmProductButton.UseVisualStyleBackColor = true;
            this.confirmProductButton.Click += new System.EventHandler(this.confirmProductButton_Click);
            // 
            // selectDate
            // 
            this.selectDate.Location = new System.Drawing.Point(17, 309);
            this.selectDate.Name = "selectDate";
            this.selectDate.Size = new System.Drawing.Size(200, 20);
            this.selectDate.TabIndex = 17;
            this.selectDate.ValueChanged += new System.EventHandler(this.selectDate_ValueChanged);
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Location = new System.Drawing.Point(17, 347);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(156, 13);
            this.deliveryLabel.TabIndex = 18;
            this.deliveryLabel.Text = "Enter your delivery instructions :";
            // 
            // instructionTextBox
            // 
            this.instructionTextBox.Location = new System.Drawing.Point(17, 363);
            this.instructionTextBox.Name = "instructionTextBox";
            this.instructionTextBox.Size = new System.Drawing.Size(200, 20);
            this.instructionTextBox.TabIndex = 19;
            // 
            // deliveryButton
            // 
            this.deliveryButton.Location = new System.Drawing.Point(223, 363);
            this.deliveryButton.Name = "deliveryButton";
            this.deliveryButton.Size = new System.Drawing.Size(67, 20);
            this.deliveryButton.TabIndex = 20;
            this.deliveryButton.Text = "Confirm";
            this.deliveryButton.UseVisualStyleBackColor = true;
            this.deliveryButton.Click += new System.EventHandler(this.deliveryButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(380, 269);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(93, 37);
            this.clearButton.TabIndex = 22;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // confirmOrderButton
            // 
            this.confirmOrderButton.Location = new System.Drawing.Point(479, 269);
            this.confirmOrderButton.Name = "confirmOrderButton";
            this.confirmOrderButton.Size = new System.Drawing.Size(93, 37);
            this.confirmOrderButton.TabIndex = 23;
            this.confirmOrderButton.Text = "Confirm Order";
            this.confirmOrderButton.UseVisualStyleBackColor = true;
            this.confirmOrderButton.Click += new System.EventHandler(this.confirmOrderButton_Click);
            // 
            // isOrderReadyLabel
            // 
            this.isOrderReadyLabel.AutoSize = true;
            this.isOrderReadyLabel.Location = new System.Drawing.Point(396, 324);
            this.isOrderReadyLabel.Name = "isOrderReadyLabel";
            this.isOrderReadyLabel.Size = new System.Drawing.Size(0, 13);
            this.isOrderReadyLabel.TabIndex = 24;
            // 
            // endProgramButton
            // 
            this.endProgramButton.Location = new System.Drawing.Point(578, 269);
            this.endProgramButton.Name = "endProgramButton";
            this.endProgramButton.Size = new System.Drawing.Size(93, 37);
            this.endProgramButton.TabIndex = 25;
            this.endProgramButton.Text = "End Program";
            this.endProgramButton.UseVisualStyleBackColor = true;
            this.endProgramButton.Click += new System.EventHandler(this.endProgramButton_Click);
            // 
            // windowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(684, 391);
            this.Controls.Add(this.endProgramButton);
            this.Controls.Add(this.isOrderReadyLabel);
            this.Controls.Add(this.confirmOrderButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deliveryButton);
            this.Controls.Add(this.instructionTextBox);
            this.Controls.Add(this.deliveryLabel);
            this.Controls.Add(this.selectDate);
            this.Controls.Add(this.confirmProductButton);
            this.Controls.Add(this.quantitySelect);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.paymentGroupBox);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.orderDetails);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.helloUserLabel);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "windowForm";
            this.Text = "Mail Order";
            this.orderDetails.ResumeLayout(false);
            this.orderDetails.PerformLayout();
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label helloUserLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.GroupBox orderDetails;
        private System.Windows.Forms.Label groupBoxName;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Label groupPayLabel;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.RadioButton otherOptionRadio;
        private System.Windows.Forms.RadioButton paypalRadio;
        private System.Windows.Forms.RadioButton creditRadio;
        private System.Windows.Forms.RadioButton cashRadio;
        private System.Windows.Forms.Label groupBoxDate;
        private System.Windows.Forms.Label groupProductLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.NumericUpDown quantitySelect;
        private System.Windows.Forms.Button confirmProductButton;
        private System.Windows.Forms.DateTimePicker selectDate;
        private System.Windows.Forms.TextBox otherOptionTextBox;
        private System.Windows.Forms.Label deliveryInstructions;
        private System.Windows.Forms.Label groupDeliveryLabel;
        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.TextBox instructionTextBox;
        private System.Windows.Forms.Button deliveryButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button confirmOrderButton;
        private System.Windows.Forms.Label isOrderReadyLabel;
        private System.Windows.Forms.Button endProgramButton;
    }
}


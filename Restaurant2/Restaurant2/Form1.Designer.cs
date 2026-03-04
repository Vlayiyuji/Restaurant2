namespace Restaurant2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnCustomerRequest = new Button();
            comboBoxDrinkType = new ComboBox();
            txtbtnEggCounter = new TextBox();
            txtbtnChickenCounter = new TextBox();
            lbEggAsker = new Label();
            lbChickenAsker = new Label();
            btnSendCookAll = new Button();
            lbQualityLabel = new Label();
            lbQualityCounter = new Label();
            btnDeliveryFood = new Button();
            label5 = new Label();
            listBox1 = new ListBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCustomerRequest);
            groupBox1.Controls.Add(comboBoxDrinkType);
            groupBox1.Controls.Add(txtbtnEggCounter);
            groupBox1.Controls.Add(txtbtnChickenCounter);
            groupBox1.Controls.Add(lbEggAsker);
            groupBox1.Controls.Add(lbChickenAsker);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 121);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // customerRequest
            // 
            btnCustomerRequest.Location = new Point(33, 92);
            btnCustomerRequest.Name = "customerRequest";
            btnCustomerRequest.Size = new Size(347, 23);
            btnCustomerRequest.TabIndex = 5;
            btnCustomerRequest.Text = "Receive this request from a Customer";
            btnCustomerRequest.UseVisualStyleBackColor = true;
            btnCustomerRequest.Click += CustomerRequest_Click;
            // 
            // drinkType
            // 
            comboBoxDrinkType.FormattingEnabled = true;
            comboBoxDrinkType.Location = new Point(267, 39);
            comboBoxDrinkType.Name = "drinkType";
            comboBoxDrinkType.Size = new Size(98, 23);
            comboBoxDrinkType.TabIndex = 4;
            comboBoxDrinkType.Items.AddRange(new object[] { "No Drink", "Water", "Tea", "Soda" });
            // 
            // eggCounter
            // 
            txtbtnEggCounter.Location = new Point(152, 53);
            txtbtnEggCounter.Name = "eggCounter";
            txtbtnEggCounter.Size = new Size(29, 23);
            txtbtnEggCounter.TabIndex = 3;
            // 
            // chickenCounter
            // 
            txtbtnChickenCounter.Location = new Point(152, 20);
            txtbtnChickenCounter.Name = "chickenCounter";
            txtbtnChickenCounter.Size = new Size(29, 23);
            txtbtnChickenCounter.TabIndex = 2;
            // 
            // eggAsker
            // 
            lbEggAsker.AutoSize = true;
            lbEggAsker.Location = new Point(33, 56);
            lbEggAsker.Name = "eggAsker";
            lbEggAsker.Size = new Size(93, 15);
            lbEggAsker.TabIndex = 1;
            lbEggAsker.Text = "How many egg?";
            // 
            // chickenAsker
            // 
            lbChickenAsker.AutoSize = true;
            lbChickenAsker.Location = new Point(33, 23);
            lbChickenAsker.Name = "chickenAsker";
            lbChickenAsker.Size = new Size(114, 15);
            lbChickenAsker.TabIndex = 0;
            lbChickenAsker.Text = "How many chicken?";
            // 
            // sendCookAll
            // 
            btnSendCookAll.Location = new Point(45, 160);
            btnSendCookAll.Name = "sendCookAll";
            btnSendCookAll.Size = new Size(347, 23);
            btnSendCookAll.TabIndex = 6;
            btnSendCookAll.Text = "Send all Customer request to the Cook";
            btnSendCookAll.UseVisualStyleBackColor = true;
            // 
            // qualityLabel
            // 
            lbQualityLabel.AutoSize = true;
            lbQualityLabel.Location = new Point(45, 207);
            lbQualityLabel.Name = "qualityLabel";
            lbQualityLabel.Size = new Size(68, 15);
            lbQualityLabel.TabIndex = 7;
            lbQualityLabel.Text = "Egg Quality";
            // 
            // qualityCounter
            // 
            lbQualityCounter.AutoSize = true;
            lbQualityCounter.Location = new Point(119, 207);
            lbQualityCounter.Name = "qualityCounter";
            lbQualityCounter.Size = new Size(0, 15);
            lbQualityCounter.TabIndex = 8;
            // 
            // deliveryFood
            // 
            btnDeliveryFood.Location = new Point(45, 247);
            btnDeliveryFood.Name = "deliveryFood";
            btnDeliveryFood.Size = new Size(347, 23);
            btnDeliveryFood.TabIndex = 9;
            btnDeliveryFood.Text = "Serve prepared food to the Customers";
            btnDeliveryFood.UseVisualStyleBackColor = true;
            btnDeliveryFood.Click += ShowAllRequests_click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 303);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 10;
            label5.Text = "Results";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(45, 332);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(347, 94);
            listBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 207);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 450);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(btnDeliveryFood);
            Controls.Add(lbQualityCounter);
            Controls.Add(lbQualityLabel);
            Controls.Add(btnSendCookAll);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbChickenAsker;
        private Button btnCustomerRequest;
        private ComboBox comboBoxDrinkType;
        private TextBox txtbtnEggCounter;
        private TextBox txtbtnChickenCounter;
        private Label lbEggAsker;
        private Button btnSendCookAll;
        private Label lbQualityLabel;
        private Label lbQualityCounter;
        private Button btnDeliveryFood;
        private Label label5;
        private ListBox listBox1;
        private Label label1;
    }
}
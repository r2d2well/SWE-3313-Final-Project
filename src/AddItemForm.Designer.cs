namespace SWE_3313_Project
{
    partial class AddItemForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            Label = new Label();
            textBox1 = new TextBox();
            TextBoxLabel = new Label();
            SubmitButton = new Button();
            comboBox = new ComboBox();
            panel2 = new Panel();
            TimeLabel = new Label();
            CurrentUserLabel = new Label();
            CloseButton = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(86, 12);
            button1.Name = "button1";
            button1.Size = new Size(128, 128);
            button1.TabIndex = 0;
            button1.Text = "Appetizers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(220, 12);
            button2.Name = "button2";
            button2.Size = new Size(128, 128);
            button2.TabIndex = 1;
            button2.Text = "Salads";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(354, 12);
            button3.Name = "button3";
            button3.Size = new Size(128, 128);
            button3.TabIndex = 2;
            button3.Text = "Entrees";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(488, 12);
            button4.Name = "button4";
            button4.Size = new Size(128, 128);
            button4.TabIndex = 3;
            button4.Text = "Sandwiches";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(86, 146);
            button5.Name = "button5";
            button5.Size = new Size(128, 128);
            button5.TabIndex = 4;
            button5.Text = "Wraps";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(220, 146);
            button6.Name = "button6";
            button6.Size = new Size(128, 128);
            button6.TabIndex = 5;
            button6.Text = "Burgers";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            // 
            // button7
            // 
            button7.Location = new Point(354, 146);
            button7.Name = "button7";
            button7.Size = new Size(128, 128);
            button7.TabIndex = 6;
            button7.Text = "Drinks";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // button8
            // 
            button8.Location = new Point(488, 146);
            button8.Name = "button8";
            button8.Size = new Size(128, 128);
            button8.TabIndex = 7;
            button8.Text = "Sides";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(322, 321);
            Label.Name = "Label";
            Label.Size = new Size(0, 20);
            Label.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 116);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 158);
            textBox1.TabIndex = 14;
            textBox1.Visible = false;
            // 
            // TextBoxLabel
            // 
            TextBoxLabel.AutoSize = true;
            TextBoxLabel.Location = new Point(220, 93);
            TextBoxLabel.Name = "TextBoxLabel";
            TextBoxLabel.Size = new Size(212, 20);
            TextBoxLabel.TabIndex = 15;
            TextBoxLabel.Text = "Enter Any Additional Requests:";
            TextBoxLabel.Visible = false;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(425, 290);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(94, 29);
            SubmitButton.TabIndex = 16;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Visible = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "0.00", "0.25", "0.50", "0.75", "1.00", "1.25", "1.50", "1.75", "2.00", "2.25", "2.50", "2.75", "3.00" });
            comboBox.Location = new Point(220, 290);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(179, 28);
            comboBox.TabIndex = 17;
            comboBox.Text = "Enter Additional Costs";
            comboBox.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Controls.Add(TimeLabel);
            panel2.Controls.Add(CurrentUserLabel);
            panel2.Location = new Point(0, 388);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 64);
            panel2.TabIndex = 41;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLabel.ForeColor = SystemColors.ButtonFace;
            TimeLabel.Location = new Point(12, 18);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(63, 28);
            TimeLabel.TabIndex = 1;
            TimeLabel.Text = "Time: ";
            // 
            // CurrentUserLabel
            // 
            CurrentUserLabel.AutoSize = true;
            CurrentUserLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentUserLabel.ForeColor = SystemColors.ButtonFace;
            CurrentUserLabel.Location = new Point(600, 18);
            CurrentUserLabel.Name = "CurrentUserLabel";
            CurrentUserLabel.Size = new Size(130, 28);
            CurrentUserLabel.TabIndex = 0;
            CurrentUserLabel.Text = "Current User: ";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Transparent;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonFace;
            CloseButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Image = Properties.Resources.BackArrow;
            CloseButton.Location = new Point(0, 328);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(87, 54);
            CloseButton.TabIndex = 15;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += ReturnButtonPress;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(CloseButton);
            Controls.Add(panel2);
            Controls.Add(comboBox);
            Controls.Add(SubmitButton);
            Controls.Add(TextBoxLabel);
            Controls.Add(textBox1);
            Controls.Add(Label);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AddItemForm";
            Text = "Add Item";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label Label;
        private TextBox textBox1;
        private Label TextBoxLabel;
        private Button SubmitButton;
        private ComboBox comboBox;
        private Panel panel2;
        private Label TimeLabel;
        private Label CurrentUserLabel;
        private Button CloseButton;
    }
}
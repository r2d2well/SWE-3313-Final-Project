namespace SWE_3313_Project
{
    partial class AddEmployeeForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            IDTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            InitalComboBox = new ComboBox();
            SubmitButton = new Button();
            CloseButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 48);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 219);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 130);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 2;
            label3.Text = "Enter Middle Initial:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(415, 48);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 3;
            label4.Text = "Enter Employee ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(415, 130);
            label5.Name = "label5";
            label5.Size = new Size(151, 20);
            label5.TabIndex = 4;
            label5.Text = "Enter Employee Type:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Host", "Server", "Cook", "Bartenders", "Busser", "Manager" });
            comboBox1.Location = new Point(415, 169);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 28);
            comboBox1.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(415, 219);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(169, 88);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Gender:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += Radio_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += Radio_Click;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(415, 85);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(169, 27);
            IDTextBox.TabIndex = 8;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(40, 85);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(169, 27);
            FirstNameTextBox.TabIndex = 9;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(40, 261);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(169, 27);
            LastNameTextBox.TabIndex = 11;
            // 
            // InitalComboBox
            // 
            InitalComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            InitalComboBox.FormattingEnabled = true;
            InitalComboBox.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "L", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" });
            InitalComboBox.Location = new Point(40, 169);
            InitalComboBox.Name = "InitalComboBox";
            InitalComboBox.Size = new Size(169, 28);
            InitalComboBox.TabIndex = 12;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(572, 341);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(126, 44);
            SubmitButton.TabIndex = 13;
            SubmitButton.Text = "Add Employee";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Transparent;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonFace;
            CloseButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Image = Properties.Resources.BackArrow;
            CloseButton.Location = new Point(40, 331);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(87, 54);
            CloseButton.TabIndex = 14;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(710, 397);
            Controls.Add(CloseButton);
            Controls.Add(SubmitButton);
            Controls.Add(InitalComboBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox IDTextBox;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private ComboBox InitalComboBox;
        private Button SubmitButton;
        private Button CloseButton;
    }
}
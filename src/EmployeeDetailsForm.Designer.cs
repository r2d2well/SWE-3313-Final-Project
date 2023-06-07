namespace SWE_3313_Project
{
    partial class EmployeeDetailsForm
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
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            InitalLabel = new Label();
            IDLabel = new Label();
            TypeLabel = new Label();
            GenderLabel = new Label();
            HoursLabel = new Label();
            ClockedLabel = new Label();
            CloseButton = new Button();
            RestrictedLabel = new Label();
            SuspendLayout();
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.Location = new Point(9, 8);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(110, 28);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "First Name:";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameLabel.Location = new Point(9, 104);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(107, 28);
            LastNameLabel.TabIndex = 1;
            LastNameLabel.Text = "Last Name:";
            // 
            // InitalLabel
            // 
            InitalLabel.AutoSize = true;
            InitalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            InitalLabel.Location = new Point(9, 58);
            InitalLabel.Name = "InitalLabel";
            InitalLabel.Size = new Size(126, 28);
            InitalLabel.TabIndex = 2;
            InitalLabel.Text = "Middle Inital:";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDLabel.Location = new Point(9, 150);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(126, 28);
            IDLabel.TabIndex = 3;
            IDLabel.Text = "Employee ID:";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TypeLabel.Location = new Point(12, 205);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(148, 28);
            TypeLabel.TabIndex = 4;
            TypeLabel.Text = "Employee Type:";
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GenderLabel.Location = new Point(12, 261);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(80, 28);
            GenderLabel.TabIndex = 5;
            GenderLabel.Text = "Gender:";
            // 
            // HoursLabel
            // 
            HoursLabel.AutoSize = true;
            HoursLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HoursLabel.Location = new Point(12, 312);
            HoursLabel.Name = "HoursLabel";
            HoursLabel.Size = new Size(68, 28);
            HoursLabel.TabIndex = 6;
            HoursLabel.Text = "Hours:";
            // 
            // ClockedLabel
            // 
            ClockedLabel.AutoSize = true;
            ClockedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClockedLabel.Location = new Point(12, 368);
            ClockedLabel.Name = "ClockedLabel";
            ClockedLabel.Size = new Size(91, 28);
            ClockedLabel.TabIndex = 7;
            ClockedLabel.Text = "Clocked: ";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Transparent;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonFace;
            CloseButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Image = Properties.Resources.BackArrow;
            CloseButton.Location = new Point(5, 466);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(87, 54);
            CloseButton.TabIndex = 15;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // RestrictedLabel
            // 
            RestrictedLabel.AutoSize = true;
            RestrictedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RestrictedLabel.Location = new Point(9, 422);
            RestrictedLabel.Name = "RestrictedLabel";
            RestrictedLabel.Size = new Size(102, 28);
            RestrictedLabel.TabIndex = 16;
            RestrictedLabel.Text = "Restricted:";
            RestrictedLabel.Visible = false;
            // 
            // EmployeeDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(501, 532);
            Controls.Add(RestrictedLabel);
            Controls.Add(CloseButton);
            Controls.Add(ClockedLabel);
            Controls.Add(HoursLabel);
            Controls.Add(GenderLabel);
            Controls.Add(TypeLabel);
            Controls.Add(IDLabel);
            Controls.Add(InitalLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameLabel);
            Name = "EmployeeDetailsForm";
            Text = "EmployeeDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label InitalLabel;
        private Label IDLabel;
        private Label TypeLabel;
        private Label GenderLabel;
        private Label HoursLabel;
        private Label ClockedLabel;
        private Button CloseButton;
        private Label RestrictedLabel;
    }
}
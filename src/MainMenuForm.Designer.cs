namespace SWE_3313_Project
{
    partial class MainMenuForm
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
            OpenTableViewButton = new Button();
            OpenQueueButton = new Button();
            panel2 = new Panel();
            TimeLabel = new Label();
            CurrentUserLabel = new Label();
            SignInButton = new Button();
            ClockInButton = new Button();
            EmployeeListButton = new Button();
            ClockSheetButton = new Button();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // OpenTableViewButton
            // 
            OpenTableViewButton.Location = new Point(595, 146);
            OpenTableViewButton.Name = "OpenTableViewButton";
            OpenTableViewButton.Size = new Size(193, 68);
            OpenTableViewButton.TabIndex = 0;
            OpenTableViewButton.Text = "Open Table View";
            OpenTableViewButton.UseVisualStyleBackColor = true;
            OpenTableViewButton.Click += button1_Click;
            // 
            // OpenQueueButton
            // 
            OpenQueueButton.Location = new Point(12, 146);
            OpenQueueButton.Name = "OpenQueueButton";
            OpenQueueButton.Size = new Size(193, 68);
            OpenQueueButton.TabIndex = 2;
            OpenQueueButton.Text = "Open Queue";
            OpenQueueButton.UseVisualStyleBackColor = true;
            OpenQueueButton.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(TimeLabel);
            panel2.Controls.Add(CurrentUserLabel);
            panel2.ForeColor = SystemColors.ButtonFace;
            panel2.Location = new Point(0, 388);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 64);
            panel2.TabIndex = 41;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.BackColor = SystemColors.ButtonFace;
            TimeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLabel.ForeColor = SystemColors.Desktop;
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
            CurrentUserLabel.ForeColor = SystemColors.Desktop;
            CurrentUserLabel.Location = new Point(569, 18);
            CurrentUserLabel.Name = "CurrentUserLabel";
            CurrentUserLabel.Size = new Size(130, 28);
            CurrentUserLabel.TabIndex = 0;
            CurrentUserLabel.Text = "Current User: ";
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(317, 146);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(172, 68);
            SignInButton.TabIndex = 42;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += button2_Click;
            // 
            // ClockInButton
            // 
            ClockInButton.Location = new Point(314, 292);
            ClockInButton.Name = "ClockInButton";
            ClockInButton.Size = new Size(175, 68);
            ClockInButton.TabIndex = 43;
            ClockInButton.Text = "Clock In";
            ClockInButton.UseVisualStyleBackColor = true;
            ClockInButton.Visible = false;
            ClockInButton.Click += ClockInButton_Click;
            // 
            // EmployeeListButton
            // 
            EmployeeListButton.Location = new Point(595, 292);
            EmployeeListButton.Name = "EmployeeListButton";
            EmployeeListButton.Size = new Size(179, 68);
            EmployeeListButton.TabIndex = 44;
            EmployeeListButton.Text = "Employee List";
            EmployeeListButton.UseVisualStyleBackColor = true;
            EmployeeListButton.Visible = false;
            EmployeeListButton.Click += EmployeeManagementButton_Click;
            // 
            // ClockSheetButton
            // 
            ClockSheetButton.Location = new Point(12, 292);
            ClockSheetButton.Name = "ClockSheetButton";
            ClockSheetButton.Size = new Size(193, 68);
            ClockSheetButton.TabIndex = 45;
            ClockSheetButton.Text = "Clock-In/Clock-Out Sheet";
            ClockSheetButton.UseVisualStyleBackColor = true;
            ClockSheetButton.Visible = false;
            ClockSheetButton.Click += ClockSheetButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(159, 18);
            label1.Name = "label1";
            label1.Size = new Size(0, 81);
            label1.TabIndex = 46;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ClockSheetButton);
            Controls.Add(EmployeeListButton);
            Controls.Add(ClockInButton);
            Controls.Add(SignInButton);
            Controls.Add(panel2);
            Controls.Add(OpenQueueButton);
            Controls.Add(OpenTableViewButton);
            Name = "MainMenuForm";
            Text = "Main Menu Form";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenTableViewButton;
        private Button OpenQueueButton;
        private Panel panel2;
        private Label TimeLabel;
        private Label CurrentUserLabel;
        private Button SignInButton;
        private Button ClockInButton;
        private Button EmployeeListButton;
        private Button ClockSheetButton;
        private Label label1;
    }
}
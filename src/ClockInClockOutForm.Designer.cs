namespace SWE_3313_Project
{
    partial class ClockInClockOutForm
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
            TimeLabel = new Label();
            CurrentUserLabel = new Label();
            panel2 = new Panel();
            listView1 = new ListView();
            Time = new ColumnHeader();
            Date = new ColumnHeader();
            EmployeeID = new ColumnHeader();
            ClockInOrOut = new ColumnHeader();
            CloseButton = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
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
            CurrentUserLabel.Location = new Point(564, 18);
            CurrentUserLabel.Name = "CurrentUserLabel";
            CurrentUserLabel.Size = new Size(130, 28);
            CurrentUserLabel.TabIndex = 0;
            CurrentUserLabel.Text = "Current User: ";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Controls.Add(TimeLabel);
            panel2.Controls.Add(CurrentUserLabel);
            panel2.Location = new Point(1, 389);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 64);
            panel2.TabIndex = 43;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Time, Date, EmployeeID, ClockInOrOut });
            listView1.GridLines = true;
            listView1.Location = new Point(1, -1);
            listView1.Name = "listView1";
            listView1.Size = new Size(803, 324);
            listView1.TabIndex = 45;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Time
            // 
            Time.Text = "Time";
            Time.Width = 200;
            // 
            // Date
            // 
            Date.Text = "Date";
            Date.Width = 150;
            // 
            // EmployeeID
            // 
            EmployeeID.Text = "EmployeeID";
            EmployeeID.TextAlign = HorizontalAlignment.Center;
            EmployeeID.Width = 200;
            // 
            // ClockInOrOut
            // 
            ClockInOrOut.Text = "Clock In/Clock Out";
            ClockInOrOut.Width = 200;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Transparent;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonFace;
            CloseButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Image = Properties.Resources.BackArrow;
            CloseButton.Location = new Point(12, 329);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(87, 54);
            CloseButton.TabIndex = 46;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // ClockInClockOutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CloseButton);
            Controls.Add(listView1);
            Controls.Add(panel2);
            Name = "ClockInClockOutForm";
            Text = "ClockIn/ClockOut";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label TimeLabel;
        private Label CurrentUserLabel;
        private Panel panel2;
        private ListView listView1;
        private ColumnHeader Time;
        private ColumnHeader EmployeeID;
        private ColumnHeader ClockInOrOut;
        private ColumnHeader Date;
        private Button CloseButton;
    }
}
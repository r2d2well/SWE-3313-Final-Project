namespace SWE_3313_Project
{
    partial class EmployeeListForm
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
            EmployeeID = new ColumnHeader();
            FirstName = new ColumnHeader();
            Initial = new ColumnHeader();
            LastName = new ColumnHeader();
            EmployeeType = new ColumnHeader();
            ViewEmployeeDetailsButton = new Button();
            AddEmployeeButton = new Button();
            RemoveEmployeeButton = new Button();
            roundButton1 = new RoundButton();
            RestrictButton = new Button();
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
            CurrentUserLabel.Location = new Point(569, 18);
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
            panel2.Location = new Point(0, 387);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 64);
            panel2.TabIndex = 42;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { EmployeeID, FirstName, Initial, LastName, EmployeeType });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(145, 12);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(492, 269);
            listView1.TabIndex = 43;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // EmployeeID
            // 
            EmployeeID.Text = "EmployeeID";
            EmployeeID.Width = 100;
            // 
            // FirstName
            // 
            FirstName.Text = "First Name";
            FirstName.Width = 100;
            // 
            // Initial
            // 
            Initial.Text = "Initial";
            // 
            // LastName
            // 
            LastName.Text = "Last Name";
            LastName.Width = 100;
            // 
            // EmployeeType
            // 
            EmployeeType.Text = "Employee Type";
            EmployeeType.Width = 120;
            // 
            // ViewEmployeeDetailsButton
            // 
            ViewEmployeeDetailsButton.Location = new Point(145, 319);
            ViewEmployeeDetailsButton.Name = "ViewEmployeeDetailsButton";
            ViewEmployeeDetailsButton.Size = new Size(126, 49);
            ViewEmployeeDetailsButton.TabIndex = 44;
            ViewEmployeeDetailsButton.Text = "View Employee Details";
            ViewEmployeeDetailsButton.UseVisualStyleBackColor = true;
            ViewEmployeeDetailsButton.Visible = false;
            ViewEmployeeDetailsButton.Click += ViewEmployeeDetailsButton_Click;
            // 
            // AddEmployeeButton
            // 
            AddEmployeeButton.Location = new Point(673, 319);
            AddEmployeeButton.Name = "AddEmployeeButton";
            AddEmployeeButton.Size = new Size(115, 49);
            AddEmployeeButton.TabIndex = 45;
            AddEmployeeButton.Text = "Add Employee";
            AddEmployeeButton.UseVisualStyleBackColor = true;
            AddEmployeeButton.Click += AddEmployeeButton_Click;
            // 
            // RemoveEmployeeButton
            // 
            RemoveEmployeeButton.Location = new Point(496, 319);
            RemoveEmployeeButton.Name = "RemoveEmployeeButton";
            RemoveEmployeeButton.Size = new Size(141, 49);
            RemoveEmployeeButton.TabIndex = 47;
            RemoveEmployeeButton.Text = "Remove Employee";
            RemoveEmployeeButton.UseVisualStyleBackColor = true;
            RemoveEmployeeButton.Visible = false;
            RemoveEmployeeButton.Click += RemoveEmployeeButton_Click;
            // 
            // roundButton1
            // 
            roundButton1.Image = Properties.Resources.Home_Icon1;
            roundButton1.Location = new Point(350, 319);
            roundButton1.Name = "roundButton1";
            roundButton1.Size = new Size(64, 64);
            roundButton1.TabIndex = 48;
            roundButton1.UseVisualStyleBackColor = true;
            roundButton1.Click += CloseButton_Click;
            // 
            // RestrictButton
            // 
            RestrictButton.Location = new Point(12, 319);
            RestrictButton.Name = "RestrictButton";
            RestrictButton.Size = new Size(112, 49);
            RestrictButton.TabIndex = 49;
            RestrictButton.Text = "Unrestrict";
            RestrictButton.UseVisualStyleBackColor = true;
            RestrictButton.Visible = false;
            RestrictButton.Click += RestrictButton_Click;
            // 
            // EmployeeListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(800, 450);
            Controls.Add(RestrictButton);
            Controls.Add(roundButton1);
            Controls.Add(RemoveEmployeeButton);
            Controls.Add(AddEmployeeButton);
            Controls.Add(ViewEmployeeDetailsButton);
            Controls.Add(listView1);
            Controls.Add(panel2);
            Name = "EmployeeListForm";
            Text = "EmployeeListForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label TimeLabel;
        private Label CurrentUserLabel;
        private Panel panel2;
        private ListView listView1;
        private ColumnHeader EmployeeID;
        private ColumnHeader FirstName;
        private ColumnHeader Initial;
        private ColumnHeader LastName;
        private ColumnHeader EmployeeType;
        private Button ViewEmployeeDetailsButton;
        private Button AddEmployeeButton;
        private Button RemoveEmployeeButton;
        private RoundButton roundButton1;
        private Button RestrictButton;
    }
}
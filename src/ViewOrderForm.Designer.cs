namespace SWE_3313_Project
{
    partial class ViewOrderForm
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
            listView1 = new ListView();
            NameCol = new ColumnHeader();
            Side1 = new ColumnHeader();
            Side2 = new ColumnHeader();
            Topping1 = new ColumnHeader();
            Topping2 = new ColumnHeader();
            Cost = new ColumnHeader();
            AdditonalRequests = new ColumnHeader();
            panel2 = new Panel();
            TimeLabel = new Label();
            CurrentUserLabel = new Label();
            ViewItemButton = new Button();
            CloseButton = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NameCol, Side1, Side2, Topping1, Topping2, Cost, AdditonalRequests });
            listView1.FullRowSelect = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(0, -1);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(803, 324);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // NameCol
            // 
            NameCol.Text = "Name";
            NameCol.Width = 128;
            // 
            // Side1
            // 
            Side1.Text = "Side 1";
            // 
            // Side2
            // 
            Side2.Text = "Side2";
            // 
            // Topping1
            // 
            Topping1.Text = "Topping";
            Topping1.Width = 128;
            // 
            // Topping2
            // 
            Topping2.Text = "Extra Topping";
            Topping2.Width = 128;
            // 
            // Cost
            // 
            Cost.Text = "Cost";
            // 
            // AdditonalRequests
            // 
            AdditonalRequests.Text = "Additional Requests";
            AdditonalRequests.Width = 230;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Controls.Add(TimeLabel);
            panel2.Controls.Add(CurrentUserLabel);
            panel2.Location = new Point(0, 389);
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
            CurrentUserLabel.Location = new Point(564, 18);
            CurrentUserLabel.Name = "CurrentUserLabel";
            CurrentUserLabel.Size = new Size(130, 28);
            CurrentUserLabel.TabIndex = 0;
            CurrentUserLabel.Text = "Current User: ";
            // 
            // ViewItemButton
            // 
            ViewItemButton.Location = new Point(649, 329);
            ViewItemButton.Name = "ViewItemButton";
            ViewItemButton.Size = new Size(139, 54);
            ViewItemButton.TabIndex = 42;
            ViewItemButton.Text = "View Item";
            ViewItemButton.UseVisualStyleBackColor = true;
            ViewItemButton.Click += ViewItemButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Transparent;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonFace;
            CloseButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Image = Properties.Resources.BackArrow;
            CloseButton.Location = new Point(0, 329);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(87, 54);
            CloseButton.TabIndex = 43;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // ViewOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(800, 450);
            Controls.Add(CloseButton);
            Controls.Add(ViewItemButton);
            Controls.Add(panel2);
            Controls.Add(listView1);
            Name = "ViewOrderForm";
            Text = "View Order Form";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader NameCol;
        private ColumnHeader Side1;
        private ColumnHeader Side2;
        private ColumnHeader Topping1;
        private ColumnHeader Topping2;
        private ColumnHeader Cost;
        private ColumnHeader AdditonalRequests;
        private Panel panel2;
        private Label TimeLabel;
        private Label CurrentUserLabel;
        private Button ViewItemButton;
        private Button CloseButton;
    }
}
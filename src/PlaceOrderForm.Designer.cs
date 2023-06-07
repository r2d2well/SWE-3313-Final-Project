namespace SWE_3313_Project
{
    partial class PlaceOrderForm
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
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button1 = new Button();
            TotalCostLabel = new Label();
            RemoveItemButton = new Button();
            PlaceOrderButton = new Button();
            ViewItemButton = new Button();
            panel2 = new Panel();
            TimeLabel = new Label();
            CurrentUserLabel = new Label();
            TaxLabel = new Label();
            SubTotalLabel = new Label();
            CloseButton = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.AutoArrange = false;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.FullRowSelect = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(189, 65);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(458, 239);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 350;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Price";
            columnHeader2.Width = 100;
            // 
            // button1
            // 
            button1.Location = new Point(375, 310);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Add Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Location = new Point(653, 257);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(78, 20);
            TotalCostLabel.TabIndex = 4;
            TotalCostLabel.Text = "Total Cost:";
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Location = new Point(31, 248);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(135, 29);
            RemoveItemButton.TabIndex = 5;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Visible = false;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // PlaceOrderButton
            // 
            PlaceOrderButton.Location = new Point(646, 368);
            PlaceOrderButton.Name = "PlaceOrderButton";
            PlaceOrderButton.Size = new Size(142, 44);
            PlaceOrderButton.TabIndex = 6;
            PlaceOrderButton.Text = "Place Order";
            PlaceOrderButton.UseVisualStyleBackColor = true;
            PlaceOrderButton.Visible = false;
            PlaceOrderButton.Click += PlaceOrderButton_Click;
            // 
            // ViewItemButton
            // 
            ViewItemButton.Location = new Point(31, 166);
            ViewItemButton.Name = "ViewItemButton";
            ViewItemButton.Size = new Size(135, 29);
            ViewItemButton.TabIndex = 7;
            ViewItemButton.Text = "View Item Details";
            ViewItemButton.UseVisualStyleBackColor = true;
            ViewItemButton.Visible = false;
            ViewItemButton.Click += ViewItemButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Controls.Add(TimeLabel);
            panel2.Controls.Add(CurrentUserLabel);
            panel2.Location = new Point(0, 418);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 64);
            panel2.TabIndex = 40;
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
            // TaxLabel
            // 
            TaxLabel.AutoSize = true;
            TaxLabel.Location = new Point(654, 174);
            TaxLabel.Name = "TaxLabel";
            TaxLabel.Size = new Size(37, 20);
            TaxLabel.TabIndex = 41;
            TaxLabel.Text = "Tax: ";
            // 
            // SubTotalLabel
            // 
            SubTotalLabel.AutoSize = true;
            SubTotalLabel.Location = new Point(653, 95);
            SubTotalLabel.Name = "SubTotalLabel";
            SubTotalLabel.Size = new Size(74, 20);
            SubTotalLabel.TabIndex = 42;
            SubTotalLabel.Text = "SubTotal: ";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Transparent;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonFace;
            CloseButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Image = Properties.Resources.BackArrow;
            CloseButton.Location = new Point(0, 363);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(87, 54);
            CloseButton.TabIndex = 43;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // PlaceOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(800, 481);
            Controls.Add(CloseButton);
            Controls.Add(SubTotalLabel);
            Controls.Add(TaxLabel);
            Controls.Add(panel2);
            Controls.Add(ViewItemButton);
            Controls.Add(PlaceOrderButton);
            Controls.Add(RemoveItemButton);
            Controls.Add(listView1);
            Controls.Add(TotalCostLabel);
            Controls.Add(button1);
            Name = "PlaceOrderForm";
            Text = "Place Order";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listView1;
        private Button button1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label TotalCostLabel;
        private Button RemoveItemButton;
        private Button PlaceOrderButton;
        private Button ViewItemButton;
        private Panel panel2;
        private Label CurrentUserLabel;
        private Label TimeLabel;
        private Label TaxLabel;
        private Label SubTotalLabel;
        private Button CloseButton;
    }
}
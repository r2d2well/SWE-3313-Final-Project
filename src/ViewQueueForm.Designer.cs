namespace SWE_3313_Project
{
    partial class ViewQueueForm
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
            OrderID = new ColumnHeader();
            Price = new ColumnHeader();
            PlacedTime = new ColumnHeader();
            TableID = new ColumnHeader();
            RefreshButton = new Button();
            ViewOrderButton = new Button();
            CurrentUserLabel = new Label();
            panel2 = new Panel();
            TimeLabel = new Label();
            SendOrderButton = new Button();
            roundButton1 = new RoundButton();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { OrderID, Price, PlacedTime, TableID });
            listView1.FullRowSelect = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(164, 61);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(481, 267);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // OrderID
            // 
            OrderID.Text = "Order #";
            OrderID.Width = 70;
            // 
            // Price
            // 
            Price.Text = "Price";
            Price.TextAlign = HorizontalAlignment.Center;
            Price.Width = 100;
            // 
            // PlacedTime
            // 
            PlacedTime.Text = "Placed Time";
            PlacedTime.TextAlign = HorizontalAlignment.Center;
            PlacedTime.Width = 220;
            // 
            // TableID
            // 
            TableID.Text = "TableID";
            TableID.Width = 80;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(662, 384);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(126, 52);
            RefreshButton.TabIndex = 2;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // ViewOrderButton
            // 
            ViewOrderButton.Location = new Point(480, 380);
            ViewOrderButton.Name = "ViewOrderButton";
            ViewOrderButton.Size = new Size(131, 56);
            ViewOrderButton.TabIndex = 3;
            ViewOrderButton.Text = "View Order";
            ViewOrderButton.UseVisualStyleBackColor = true;
            ViewOrderButton.Visible = false;
            ViewOrderButton.Click += ViewOrderButton_Click;
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
            panel2.Location = new Point(0, 444);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 64);
            panel2.TabIndex = 42;
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
            // SendOrderButton
            // 
            SendOrderButton.Location = new Point(169, 382);
            SendOrderButton.Name = "SendOrderButton";
            SendOrderButton.Size = new Size(149, 54);
            SendOrderButton.TabIndex = 43;
            SendOrderButton.Text = "Send Out Order";
            SendOrderButton.UseVisualStyleBackColor = true;
            SendOrderButton.Visible = false;
            SendOrderButton.Click += SendOrderButton_Click;
            // 
            // roundButton1
            // 
            roundButton1.Image = Properties.Resources.Home_Icon1;
            roundButton1.Location = new Point(367, 375);
            roundButton1.Name = "roundButton1";
            roundButton1.Size = new Size(64, 64);
            roundButton1.TabIndex = 44;
            roundButton1.UseVisualStyleBackColor = true;
            roundButton1.Click += CloseWindowButton_Click;
            // 
            // ViewQueueForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(800, 503);
            Controls.Add(roundButton1);
            Controls.Add(SendOrderButton);
            Controls.Add(panel2);
            Controls.Add(ViewOrderButton);
            Controls.Add(RefreshButton);
            Controls.Add(listView1);
            Name = "ViewQueueForm";
            Text = "View Queue";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListView listView1;
        private Button RefreshButton;
        private ColumnHeader OrderID;
        private ColumnHeader Price;
        private ColumnHeader PlacedTime;
        private ColumnHeader TableID;
        private Button ViewOrderButton;
        private Label CurrentUserLabel;
        private Panel panel2;
        private Label TimeLabel;
        private Button SendOrderButton;
        private RoundButton roundButton1;
    }
}
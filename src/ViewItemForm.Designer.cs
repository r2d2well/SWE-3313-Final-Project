namespace SWE_3313_Project
{
    partial class ViewItemForm
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
            NameLabel = new Label();
            PriceLabel = new Label();
            Side1Label = new Label();
            Side2Label = new Label();
            AdditionalRequestsLabel = new Label();
            ToppingLabel = new Label();
            SecondToppingLabel = new Label();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(70, 52);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(52, 20);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name:";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(70, 128);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(48, 20);
            PriceLabel.TabIndex = 1;
            PriceLabel.Text = "Price: ";
            // 
            // Side1Label
            // 
            Side1Label.AutoSize = true;
            Side1Label.Location = new Point(70, 273);
            Side1Label.Name = "Side1Label";
            Side1Label.Size = new Size(57, 20);
            Side1Label.TabIndex = 2;
            Side1Label.Text = "Side 1: ";
            // 
            // Side2Label
            // 
            Side2Label.AutoSize = true;
            Side2Label.Location = new Point(329, 273);
            Side2Label.Name = "Side2Label";
            Side2Label.Size = new Size(53, 20);
            Side2Label.TabIndex = 3;
            Side2Label.Text = "Side 2:";
            // 
            // AdditionalRequestsLabel
            // 
            AdditionalRequestsLabel.AutoSize = true;
            AdditionalRequestsLabel.Location = new Point(70, 344);
            AdditionalRequestsLabel.Name = "AdditionalRequestsLabel";
            AdditionalRequestsLabel.Size = new Size(149, 20);
            AdditionalRequestsLabel.TabIndex = 4;
            AdditionalRequestsLabel.Text = "Additional Requests: ";
            // 
            // ToppingLabel
            // 
            ToppingLabel.AutoSize = true;
            ToppingLabel.Location = new Point(70, 190);
            ToppingLabel.Name = "ToppingLabel";
            ToppingLabel.Size = new Size(71, 20);
            ToppingLabel.TabIndex = 5;
            ToppingLabel.Text = "Topping: ";
            // 
            // SecondToppingLabel
            // 
            SecondToppingLabel.AutoSize = true;
            SecondToppingLabel.Location = new Point(329, 190);
            SecondToppingLabel.Name = "SecondToppingLabel";
            SecondToppingLabel.Size = new Size(124, 20);
            SecondToppingLabel.TabIndex = 6;
            SecondToppingLabel.Text = "Second Topping: ";
            SecondToppingLabel.Visible = false;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Transparent;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonFace;
            CloseButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Image = Properties.Resources.BackArrow;
            CloseButton.Location = new Point(2, 396);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(87, 54);
            CloseButton.TabIndex = 15;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // ViewItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(800, 450);
            Controls.Add(CloseButton);
            Controls.Add(SecondToppingLabel);
            Controls.Add(ToppingLabel);
            Controls.Add(AdditionalRequestsLabel);
            Controls.Add(Side2Label);
            Controls.Add(Side1Label);
            Controls.Add(PriceLabel);
            Controls.Add(NameLabel);
            Name = "ViewItemForm";
            Text = "View Item Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private Label PriceLabel;
        private Label Side1Label;
        private Label Side2Label;
        private Label AdditionalRequestsLabel;
        private Label ToppingLabel;
        private Label SecondToppingLabel;
        private Button CloseButton;
    }
}
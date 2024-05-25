namespace TrackerUI
{
    partial class CreatePrizeForm
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
            headerLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            textBox1 = new TextBox();
            prizeAmountLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(124, 30);
            headerLabel.TabIndex = 13;
            headerLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Font = new Font("Segoe UI", 13.8F);
            placeNumberValue.Location = new Point(172, 47);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(181, 32);
            placeNumberValue.TabIndex = 15;
            placeNumberValue.TextChanged += this.placeNUmberValue_TextChanged;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 13.8F);
            placeNumberLabel.Location = new Point(12, 54);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(131, 25);
            placeNumberLabel.TabIndex = 14;
            placeNumberLabel.Text = "Place Number";
            placeNumberLabel.Click += firstNameLabel_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F);
            textBox1.Location = new Point(172, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 32);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 13.8F);
            prizeAmountLabel.Location = new Point(12, 151);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(126, 25);
            prizeAmountLabel.TabIndex = 16;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // placeNameValue
            // 
            placeNameValue.Font = new Font("Segoe UI", 13.8F);
            placeNameValue.Location = new Point(172, 94);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(181, 32);
            placeNameValue.TabIndex = 19;
            placeNameValue.TextChanged += this.textBox2_TextChanged;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 13.8F);
            placeNameLabel.Location = new Point(11, 101);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(112, 25);
            placeNameLabel.TabIndex = 18;
            placeNameLabel.Text = "Place Name";
            placeNameLabel.Click += label2_Click;
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Font = new Font("Segoe UI", 13.8F);
            prizePercentageValue.Location = new Point(171, 232);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(181, 32);
            prizePercentageValue.TabIndex = 21;
            prizePercentageValue.TextChanged += this.textBox3_TextChanged;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 13.8F);
            prizePercentageLabel.Location = new Point(11, 232);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(154, 25);
            prizePercentageLabel.TabIndex = 20;
            prizePercentageLabel.Text = "Prize percentage";
            prizePercentageLabel.Click += this.label3_Click;
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Location = new Point(153, 189);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(48, 30);
            orLabel.TabIndex = 22;
            orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Location = new Point(171, 305);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(181, 47);
            createPrizeButton.TabIndex = 29;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(683, 583);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(textBox1);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "CreatePrizeForm";
            Load += this.CreatePrizeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox textBox1;
        private Label prizeAmountLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}
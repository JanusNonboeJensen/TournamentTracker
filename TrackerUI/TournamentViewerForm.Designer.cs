namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLabel = new Label();
            TournamentName = new Label();
            round = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneValue = new TextBox();
            teamTwoValue = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            vsLabel = new Label();
            scoreButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Location = new Point(25, 19);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(165, 38);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament";
            headerLabel.Click += label1_Click;
            // 
            // TournamentName
            // 
            TournamentName.AutoSize = true;
            TournamentName.Location = new Point(196, 19);
            TournamentName.Name = "TournamentName";
            TournamentName.Size = new Size(118, 38);
            TournamentName.TabIndex = 1;
            TournamentName.Text = "<none>";
            // 
            // round
            // 
            round.AutoSize = true;
            round.Location = new Point(25, 70);
            round.Name = "round";
            round.Size = new Size(97, 38);
            round.TabIndex = 2;
            round.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(128, 70);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(186, 45);
            roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckBox.Location = new Point(128, 121);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(229, 42);
            unplayedOnlyCheckBox.TabIndex = 4;
            unplayedOnlyCheckBox.Text = "UnPlayed only  ";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 37;
            matchupListBox.Location = new Point(25, 169);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(303, 300);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Location = new Point(397, 169);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(142, 38);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "Team One";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Location = new Point(397, 233);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(86, 38);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamOneValue
            // 
            teamOneValue.Location = new Point(489, 233);
            teamOneValue.Name = "teamOneValue";
            teamOneValue.Size = new Size(125, 43);
            teamOneValue.TabIndex = 8;
            // 
            // teamTwoValue
            // 
            teamTwoValue.Location = new Point(489, 393);
            teamTwoValue.Name = "teamTwoValue";
            teamTwoValue.Size = new Size(125, 43);
            teamTwoValue.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Location = new Point(397, 393);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(86, 38);
            teamTwoScoreLabel.TabIndex = 10;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Location = new Point(397, 329);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(139, 38);
            teamTwoName.TabIndex = 9;
            teamTwoName.Text = "Team Two";
            // 
            // vsLabel
            // 
            vsLabel.AutoSize = true;
            vsLabel.Location = new Point(487, 291);
            vsLabel.Name = "vsLabel";
            vsLabel.Size = new Size(49, 38);
            vsLabel.TabIndex = 12;
            vsLabel.Text = "VS";
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Location = new Point(667, 291);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(163, 48);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(165, 38);
            label1.TabIndex = 0;
            label1.Text = "Tournament";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 233);
            label2.Name = "label2";
            label2.Size = new Size(86, 38);
            label2.TabIndex = 7;
            label2.Text = "Score";
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1088, 506);
            Controls.Add(scoreButton);
            Controls.Add(vsLabel);
            Controls.Add(teamTwoValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneValue);
            Controls.Add(label2);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(roundDropDown);
            Controls.Add(round);
            Controls.Add(TournamentName);
            Controls.Add(label1);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label TournamentName;
        private Label round;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneValue;
        private TextBox teamTwoValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoName;
        private Label vsLabel;
        private Button scoreButton;
        private Label label1;
        private Label label2;
    }
}

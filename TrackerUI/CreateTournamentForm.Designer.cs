namespace TrackerUI
{
    partial class CreateTournamentForm
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
            label1 = new Label();
            tournamentValueBox = new TextBox();
            tournamentName = new Label();
            teamOneScoreLabel = new Label();
            entryFeeValueBox = new TextBox();
            entryFeeLabel = new Label();
            label3 = new Label();
            roundDropDownBox = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLinkClick = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentPlayerListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            deleteSelectedPlayer = new Button();
            deleteSelectedPrizeButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            label4 = new Label();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(253, 38);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create Tournament";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(480, 241);
            label1.Name = "label1";
            label1.Size = new Size(0, 38);
            label1.TabIndex = 2;
            // 
            // tournamentValueBox
            // 
            tournamentValueBox.Location = new Point(27, 112);
            tournamentValueBox.Name = "tournamentValueBox";
            tournamentValueBox.Size = new Size(245, 43);
            tournamentValueBox.TabIndex = 11;
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Location = new Point(20, 71);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(247, 38);
            tournamentName.TabIndex = 9;
            tournamentName.Text = "Tournament Name";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Location = new Point(20, 71);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(86, 38);
            teamOneScoreLabel.TabIndex = 10;
            teamOneScoreLabel.Text = "Score";
            // 
            // entryFeeValueBox
            // 
            entryFeeValueBox.Location = new Point(172, 166);
            entryFeeValueBox.Name = "entryFeeValueBox";
            entryFeeValueBox.Size = new Size(100, 43);
            entryFeeValueBox.TabIndex = 14;
            entryFeeValueBox.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Location = new Point(27, 171);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(132, 38);
            entryFeeLabel.TabIndex = 12;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 171);
            label3.Name = "label3";
            label3.Size = new Size(86, 38);
            label3.TabIndex = 13;
            label3.Text = "Score";
            // 
            // roundDropDownBox
            // 
            roundDropDownBox.FormattingEnabled = true;
            roundDropDownBox.Location = new Point(27, 267);
            roundDropDownBox.Name = "roundDropDownBox";
            roundDropDownBox.Size = new Size(245, 45);
            roundDropDownBox.TabIndex = 16;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Location = new Point(27, 226);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(164, 38);
            selectTeamLabel.TabIndex = 15;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLinkClick
            // 
            createNewTeamLinkClick.AutoSize = true;
            createNewTeamLinkClick.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createNewTeamLinkClick.Location = new Point(196, 242);
            createNewTeamLinkClick.Name = "createNewTeamLinkClick";
            createNewTeamLinkClick.Size = new Size(76, 17);
            createNewTeamLinkClick.TabIndex = 17;
            createNewTeamLinkClick.TabStop = true;
            createNewTeamLinkClick.Text = "Create New";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Location = new Point(27, 405);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(163, 45);
            addTeamButton.TabIndex = 18;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += scoreButton_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Location = new Point(27, 336);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(224, 45);
            createPrizeButton.TabIndex = 19;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayerListBox
            // 
            tournamentPlayerListBox.FormattingEnabled = true;
            tournamentPlayerListBox.ItemHeight = 37;
            tournamentPlayerListBox.Location = new Point(348, 86);
            tournamentPlayerListBox.Name = "tournamentPlayerListBox";
            tournamentPlayerListBox.Size = new Size(303, 152);
            tournamentPlayerListBox.TabIndex = 20;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Location = new Point(348, 45);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(209, 38);
            tournamentPlayersLabel.TabIndex = 21;
            tournamentPlayersLabel.Text = "Players / Teams";
            tournamentPlayersLabel.Click += label2_Click;
            // 
            // deleteSelectedPlayer
            // 
            deleteSelectedPlayer.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPlayer.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            deleteSelectedPlayer.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            deleteSelectedPlayer.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayer.Location = new Point(686, 112);
            deleteSelectedPlayer.Name = "deleteSelectedPlayer";
            deleteSelectedPlayer.Size = new Size(163, 96);
            deleteSelectedPlayer.TabIndex = 22;
            deleteSelectedPlayer.Text = "Delete Selected";
            deleteSelectedPlayer.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            deleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeButton.Location = new Point(686, 351);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(163, 93);
            deleteSelectedPrizeButton.TabIndex = 26;
            deleteSelectedPrizeButton.Text = "Delete Selected ";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Location = new Point(348, 272);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(90, 38);
            prizesLabel.TabIndex = 25;
            prizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 37;
            prizesListBox.Location = new Point(348, 313);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(303, 152);
            prizesListBox.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 468);
            label4.Name = "label4";
            label4.Size = new Size(0, 38);
            label4.TabIndex = 23;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Location = new Point(27, 487);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(496, 67);
            createTournamentButton.TabIndex = 27;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1046, 605);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(label4);
            Controls.Add(deleteSelectedPlayer);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentPlayerListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLinkClick);
            Controls.Add(roundDropDownBox);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValueBox);
            Controls.Add(entryFeeLabel);
            Controls.Add(label3);
            Controls.Add(tournamentValueBox);
            Controls.Add(tournamentName);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(label1);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "CreateTournamentForm";
            Text = "CreateTournamentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label label1;
        private TextBox tournamentValueBox;
        private Label tournamentName;
        private Label teamOneScoreLabel;
        private TextBox entryFeeValueBox;
        private Label entryFeeLabel;
        private Label label3;
        private ComboBox roundDropDownBox;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLinkClick;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentPlayerListBox;
        private Label tournamentPlayersLabel;
        private Button deleteSelectedPlayer;
        private Button deleteSelectedPrizeButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Label label4;
        private Button createTournamentButton;
    }
}
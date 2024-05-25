namespace TrackerUI
{
    partial class CreateTeamForm
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
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            teamOneScoreLabel = new Label();
            headerLabel = new Label();
            addMemberButton = new Button();
            teamMemberDropDownBox = new ComboBox();
            selectTeamMemberLabel = new Label();
            addNewMemberBox = new GroupBox();
            createMemberButton = new Button();
            cellPhoneValue = new TextBox();
            label2 = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            label1 = new Label();
            teamMemberListBox = new ListBox();
            deleteSelectedMember = new Button();
            createTeamButton = new Button();
            addNewMemberBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(27, 112);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(350, 36);
            teamNameValue.TabIndex = 15;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Location = new Point(20, 71);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(129, 30);
            teamNameLabel.TabIndex = 13;
            teamNameLabel.Text = "Team Name";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Location = new Point(20, 71);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(68, 30);
            teamOneScoreLabel.TabIndex = 14;
            teamOneScoreLabel.Text = "Score";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(135, 30);
            headerLabel.TabIndex = 12;
            headerLabel.Text = "Create Team";
            headerLabel.Click += this.headerLabel_Click;
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI", 13.8F);
            addMemberButton.Location = new Point(27, 281);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(224, 45);
            addMemberButton.TabIndex = 22;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMemberDropDownBox
            // 
            teamMemberDropDownBox.FormattingEnabled = true;
            teamMemberDropDownBox.Location = new Point(27, 212);
            teamMemberDropDownBox.Name = "teamMemberDropDownBox";
            teamMemberDropDownBox.Size = new Size(350, 38);
            teamMemberDropDownBox.TabIndex = 21;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Location = new Point(27, 171);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(219, 30);
            selectTeamMemberLabel.TabIndex = 20;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberBox
            // 
            addNewMemberBox.Controls.Add(createMemberButton);
            addNewMemberBox.Controls.Add(cellPhoneValue);
            addNewMemberBox.Controls.Add(label2);
            addNewMemberBox.Controls.Add(emailValue);
            addNewMemberBox.Controls.Add(emailLabel);
            addNewMemberBox.Controls.Add(lastNameValue);
            addNewMemberBox.Controls.Add(lastNameLabel);
            addNewMemberBox.Controls.Add(firstNameValue);
            addNewMemberBox.Controls.Add(firstNameLabel);
            addNewMemberBox.Controls.Add(label1);
            addNewMemberBox.Location = new Point(27, 360);
            addNewMemberBox.Name = "addNewMemberBox";
            addNewMemberBox.Size = new Size(350, 311);
            addNewMemberBox.TabIndex = 23;
            addNewMemberBox.TabStop = false;
            addNewMemberBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI", 13.8F);
            createMemberButton.Location = new Point(54, 247);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(223, 45);
            createMemberButton.TabIndex = 23;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            // 
            // cellPhoneValue
            // 
            cellPhoneValue.Font = new Font("Segoe UI", 13.8F);
            cellPhoneValue.Location = new Point(163, 188);
            cellPhoneValue.Name = "cellPhoneValue";
            cellPhoneValue.Size = new Size(181, 32);
            cellPhoneValue.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(6, 188);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 16;
            label2.Text = "CellPhone";
            // 
            // emailValue
            // 
            emailValue.Font = new Font("Segoe UI", 13.8F);
            emailValue.Location = new Point(163, 137);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(181, 32);
            emailValue.TabIndex = 15;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 13.8F);
            emailLabel.Location = new Point(6, 137);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(58, 25);
            emailLabel.TabIndex = 14;
            emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            lastNameValue.Font = new Font("Segoe UI", 13.8F);
            lastNameValue.Location = new Point(163, 88);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(181, 32);
            lastNameValue.TabIndex = 13;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 13.8F);
            lastNameLabel.Location = new Point(6, 88);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(100, 25);
            lastNameLabel.TabIndex = 12;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            firstNameValue.Font = new Font("Segoe UI", 13.8F);
            firstNameValue.Location = new Point(163, 39);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(181, 32);
            firstNameValue.TabIndex = 11;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 13.8F);
            firstNameLabel.Location = new Point(6, 39);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(102, 25);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(68, 30);
            label1.TabIndex = 10;
            label1.Text = "Score";
            // 
            // teamMemberListBox
            // 
            teamMemberListBox.FormattingEnabled = true;
            teamMemberListBox.ItemHeight = 30;
            teamMemberListBox.Location = new Point(422, 112);
            teamMemberListBox.Name = "teamMemberListBox";
            teamMemberListBox.Size = new Size(317, 544);
            teamMemberListBox.TabIndex = 24;
            // 
            // deleteSelectedMember
            // 
            deleteSelectedMember.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedMember.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            deleteSelectedMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            deleteSelectedMember.FlatStyle = FlatStyle.Flat;
            deleteSelectedMember.Location = new Point(787, 364);
            deleteSelectedMember.Name = "deleteSelectedMember";
            deleteSelectedMember.Size = new Size(163, 96);
            deleteSelectedMember.TabIndex = 25;
            deleteSelectedMember.Text = "Delete Selected";
            deleteSelectedMember.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Location = new Point(214, 677);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(496, 67);
            createTeamButton.TabIndex = 28;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1046, 753);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedMember);
            Controls.Add(teamMemberListBox);
            Controls.Add(addNewMemberBox);
            Controls.Add(addMemberButton);
            Controls.Add(teamMemberDropDownBox);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "CreateTeamForm";
            Text = "CreateTeamForm";
            Load += CreateTeamForm_Load;
            addNewMemberBox.ResumeLayout(false);
            addNewMemberBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label teamOneScoreLabel;
        private Label headerLabel;
        private Button addMemberButton;
        private ComboBox teamMemberDropDownBox;
        private Label selectTeamMemberLabel;
        private GroupBox addNewMemberBox;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private Label label1;
        private TextBox cellPhoneValue;
        private Label label2;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private Button createMemberButton;
        private ListBox teamMemberListBox;
        private Button deleteSelectedMember;
        private Button createTeamButton;
    }
}
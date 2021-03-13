
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentNameValue = new System.Windows.Forms.TextBox();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.CreateNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.TournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.TournamentPlayersLabel = new System.Windows.Forms.Label();
            this.DeleteSelectedPlayersButton = new System.Windows.Forms.Button();
            this.DeleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.PrizesLabel = new System.Windows.Forms.Label();
            this.PrizesListBox1 = new System.Windows.Forms.ListBox();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.HeaderLabel.Location = new System.Drawing.Point(23, 33);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(276, 45);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Create Tournament";
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.Location = new System.Drawing.Point(31, 124);
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(268, 35);
            this.TournamentNameValue.TabIndex = 10;
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TournamentNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TournamentNameLabel.Location = new System.Drawing.Point(40, 81);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(186, 30);
            this.TournamentNameLabel.TabIndex = 9;
            this.TournamentNameLabel.Text = "Tournament Name";
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.Location = new System.Drawing.Point(130, 181);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(122, 35);
            this.EntryFeeValue.TabIndex = 12;
            this.EntryFeeValue.Text = "0";
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.EntryFeeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.EntryFeeLabel.Location = new System.Drawing.Point(26, 181);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(98, 30);
            this.EntryFeeLabel.TabIndex = 11;
            this.EntryFeeLabel.Text = "Entry Fee";
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(31, 281);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(268, 38);
            this.SelectTeamDropDown.TabIndex = 14;
            this.SelectTeamDropDown.SelectedIndexChanged += new System.EventHandler(this.SelectTeamDropDown_SelectedIndexChanged);
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SelectTeamLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SelectTeamLabel.Location = new System.Drawing.Point(26, 239);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(123, 30);
            this.SelectTeamLabel.TabIndex = 13;
            this.SelectTeamLabel.Text = "Select Team";
            this.SelectTeamLabel.Click += new System.EventHandler(this.SelectTeamLabel_Click);
            // 
            // CreateNewTeamLink
            // 
            this.CreateNewTeamLink.AutoSize = true;
            this.CreateNewTeamLink.Location = new System.Drawing.Point(178, 239);
            this.CreateNewTeamLink.Name = "CreateNewTeamLink";
            this.CreateNewTeamLink.Size = new System.Drawing.Size(121, 30);
            this.CreateNewTeamLink.TabIndex = 15;
            this.CreateNewTeamLink.TabStop = true;
            this.CreateNewTeamLink.Text = "Create New";
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddTeamButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AddTeamButton.Location = new System.Drawing.Point(82, 325);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(170, 35);
            this.AddTeamButton.TabIndex = 16;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            this.AddTeamButton.Click += new System.EventHandler(this.ScoreButton_Click);
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CreatePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CreatePrizeButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreatePrizeButton.Location = new System.Drawing.Point(82, 385);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(170, 35);
            this.CreatePrizeButton.TabIndex = 17;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayersListBox
            // 
            this.TournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentPlayersListBox.FormattingEnabled = true;
            this.TournamentPlayersListBox.ItemHeight = 30;
            this.TournamentPlayersListBox.Location = new System.Drawing.Point(373, 110);
            this.TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            this.TournamentPlayersListBox.Size = new System.Drawing.Size(265, 122);
            this.TournamentPlayersListBox.TabIndex = 18;
            // 
            // TournamentPlayersLabel
            // 
            this.TournamentPlayersLabel.AutoSize = true;
            this.TournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TournamentPlayersLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TournamentPlayersLabel.Location = new System.Drawing.Point(368, 73);
            this.TournamentPlayersLabel.Name = "TournamentPlayersLabel";
            this.TournamentPlayersLabel.Size = new System.Drawing.Size(144, 30);
            this.TournamentPlayersLabel.TabIndex = 19;
            this.TournamentPlayersLabel.Text = "Teams/Players";
            // 
            // DeleteSelectedPlayersButton
            // 
            this.DeleteSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.DeleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DeleteSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedPlayersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DeleteSelectedPlayersButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DeleteSelectedPlayersButton.Location = new System.Drawing.Point(662, 150);
            this.DeleteSelectedPlayersButton.Name = "DeleteSelectedPlayersButton";
            this.DeleteSelectedPlayersButton.Size = new System.Drawing.Size(89, 52);
            this.DeleteSelectedPlayersButton.TabIndex = 20;
            this.DeleteSelectedPlayersButton.Text = "Delete Selected";
            this.DeleteSelectedPlayersButton.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedPrizeButton
            // 
            this.DeleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.DeleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DeleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DeleteSelectedPrizeButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DeleteSelectedPrizeButton.Location = new System.Drawing.Point(662, 347);
            this.DeleteSelectedPrizeButton.Name = "DeleteSelectedPrizeButton";
            this.DeleteSelectedPrizeButton.Size = new System.Drawing.Size(89, 54);
            this.DeleteSelectedPrizeButton.TabIndex = 23;
            this.DeleteSelectedPrizeButton.Text = "Delete Selected";
            this.DeleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // PrizesLabel
            // 
            this.PrizesLabel.AutoSize = true;
            this.PrizesLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PrizesLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PrizesLabel.Location = new System.Drawing.Point(368, 274);
            this.PrizesLabel.Name = "PrizesLabel";
            this.PrizesLabel.Size = new System.Drawing.Size(144, 30);
            this.PrizesLabel.TabIndex = 22;
            this.PrizesLabel.Text = "Teams/Players";
            // 
            // PrizesListBox1
            // 
            this.PrizesListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizesListBox1.FormattingEnabled = true;
            this.PrizesListBox1.ItemHeight = 30;
            this.PrizesListBox1.Location = new System.Drawing.Point(373, 311);
            this.PrizesListBox1.Name = "PrizesListBox1";
            this.PrizesListBox1.Size = new System.Drawing.Size(265, 122);
            this.PrizesListBox1.TabIndex = 21;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CreateTournamentButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreateTournamentButton.Location = new System.Drawing.Point(281, 451);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(208, 47);
            this.CreateTournamentButton.TabIndex = 24;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 695);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.DeleteSelectedPrizeButton);
            this.Controls.Add(this.PrizesLabel);
            this.Controls.Add(this.PrizesListBox1);
            this.Controls.Add(this.DeleteSelectedPlayersButton);
            this.Controls.Add(this.TournamentPlayersLabel);
            this.Controls.Add(this.TournamentPlayersListBox);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.CreateNewTeamLink);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNameValue);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournament";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox TournamentNameValue;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.TextBox EntryFeeValue;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.ComboBox SelectTeamDropDown;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.LinkLabel CreateNewTeamLink;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.Button CreatePrizeButton;
        private System.Windows.Forms.ListBox TournamentPlayersListBox;
        private System.Windows.Forms.Label TournamentPlayersLabel;
        private System.Windows.Forms.Button DeleteSelectedPlayersButton;
        private System.Windows.Forms.Button DeleteSelectedPrizeButton;
        private System.Windows.Forms.Label PrizesLabel;
        private System.Windows.Forms.ListBox PrizesListBox1;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}

namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.LoadingExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.LoadingExistingTournamentLabel = new System.Windows.Forms.Label();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.HeaderLabel.Location = new System.Drawing.Point(84, 44);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(335, 45);
            this.HeaderLabel.TabIndex = 27;
            this.HeaderLabel.Text = "Tournament Dashboard";
            // 
            // LoadingExistingTournamentDropDown
            // 
            this.LoadingExistingTournamentDropDown.FormattingEnabled = true;
            this.LoadingExistingTournamentDropDown.Location = new System.Drawing.Point(117, 155);
            this.LoadingExistingTournamentDropDown.Name = "LoadingExistingTournamentDropDown";
            this.LoadingExistingTournamentDropDown.Size = new System.Drawing.Size(268, 38);
            this.LoadingExistingTournamentDropDown.TabIndex = 35;
            // 
            // LoadingExistingTournamentLabel
            // 
            this.LoadingExistingTournamentLabel.AutoSize = true;
            this.LoadingExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LoadingExistingTournamentLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoadingExistingTournamentLabel.Location = new System.Drawing.Point(125, 113);
            this.LoadingExistingTournamentLabel.Name = "LoadingExistingTournamentLabel";
            this.LoadingExistingTournamentLabel.Size = new System.Drawing.Size(252, 30);
            this.LoadingExistingTournamentLabel.TabIndex = 34;
            this.LoadingExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // LoadTournamentButton
            // 
            this.LoadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LoadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.LoadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.LoadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LoadTournamentButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoadTournamentButton.Location = new System.Drawing.Point(154, 208);
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.Size = new System.Drawing.Size(195, 35);
            this.LoadTournamentButton.TabIndex = 36;
            this.LoadTournamentButton.Text = "Load Tournament";
            this.LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CreateTournamentButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreateTournamentButton.Location = new System.Drawing.Point(147, 268);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(208, 47);
            this.CreateTournamentButton.TabIndex = 37;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 378);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.LoadingExistingTournamentDropDown);
            this.Controls.Add(this.LoadingExistingTournamentLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.Load += new System.EventHandler(this.TournamentDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.ComboBox LoadingExistingTournamentDropDown;
        private System.Windows.Forms.Label LoadingExistingTournamentLabel;
        private System.Windows.Forms.Button LoadTournamentButton;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}
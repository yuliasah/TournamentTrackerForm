
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.PlaceNumberValue = new System.Windows.Forms.TextBox();
            this.PlaceNumberLabel = new System.Windows.Forms.Label();
            this.PlaceNameValue = new System.Windows.Forms.TextBox();
            this.PlaceNameLabel = new System.Windows.Forms.Label();
            this.PrizeAmountValue = new System.Windows.Forms.TextBox();
            this.PrizeAmountLabel = new System.Windows.Forms.Label();
            this.PrizePercentageValue = new System.Windows.Forms.TextBox();
            this.PrizePercentageLabel = new System.Windows.Forms.Label();
            this.OrLabel = new System.Windows.Forms.Label();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.HeaderLabel.Location = new System.Drawing.Point(49, 37);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(225, 54);
            this.HeaderLabel.TabIndex = 26;
            this.HeaderLabel.Text = "Create Prize";
            // 
            // PlaceNumberValue
            // 
            this.PlaceNumberValue.Location = new System.Drawing.Point(232, 108);
            this.PlaceNumberValue.Name = "PlaceNumberValue";
            this.PlaceNumberValue.Size = new System.Drawing.Size(137, 42);
            this.PlaceNumberValue.TabIndex = 28;
            this.PlaceNumberValue.TextChanged += new System.EventHandler(this.PlaceNumberValue_TextChanged);
            // 
            // PlaceNumberLabel
            // 
            this.PlaceNumberLabel.AutoSize = true;
            this.PlaceNumberLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PlaceNumberLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PlaceNumberLabel.Location = new System.Drawing.Point(59, 108);
            this.PlaceNumberLabel.Name = "PlaceNumberLabel";
            this.PlaceNumberLabel.Size = new System.Drawing.Size(183, 37);
            this.PlaceNumberLabel.TabIndex = 27;
            this.PlaceNumberLabel.Text = "Place Number";
            // 
            // PlaceNameValue
            // 
            this.PlaceNameValue.Location = new System.Drawing.Point(232, 149);
            this.PlaceNameValue.Name = "PlaceNameValue";
            this.PlaceNameValue.Size = new System.Drawing.Size(137, 42);
            this.PlaceNameValue.TabIndex = 30;
            // 
            // PlaceNameLabel
            // 
            this.PlaceNameLabel.AutoSize = true;
            this.PlaceNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PlaceNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PlaceNameLabel.Location = new System.Drawing.Point(59, 149);
            this.PlaceNameLabel.Name = "PlaceNameLabel";
            this.PlaceNameLabel.Size = new System.Drawing.Size(157, 37);
            this.PlaceNameLabel.TabIndex = 29;
            this.PlaceNameLabel.Text = "Place Name";
            // 
            // PrizeAmountValue
            // 
            this.PrizeAmountValue.Location = new System.Drawing.Point(232, 190);
            this.PrizeAmountValue.Name = "PrizeAmountValue";
            this.PrizeAmountValue.Size = new System.Drawing.Size(137, 42);
            this.PrizeAmountValue.TabIndex = 32;
            this.PrizeAmountValue.Text = "0";
            // 
            // PrizeAmountLabel
            // 
            this.PrizeAmountLabel.AutoSize = true;
            this.PrizeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PrizeAmountLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PrizeAmountLabel.Location = new System.Drawing.Point(59, 190);
            this.PrizeAmountLabel.Name = "PrizeAmountLabel";
            this.PrizeAmountLabel.Size = new System.Drawing.Size(176, 37);
            this.PrizeAmountLabel.TabIndex = 31;
            this.PrizeAmountLabel.Text = "Prize Amount";
            // 
            // PrizePercentageValue
            // 
            this.PrizePercentageValue.Location = new System.Drawing.Point(232, 280);
            this.PrizePercentageValue.Name = "PrizePercentageValue";
            this.PrizePercentageValue.Size = new System.Drawing.Size(137, 42);
            this.PrizePercentageValue.TabIndex = 34;
            this.PrizePercentageValue.Text = "0";
            // 
            // PrizePercentageLabel
            // 
            this.PrizePercentageLabel.AutoSize = true;
            this.PrizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PrizePercentageLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PrizePercentageLabel.Location = new System.Drawing.Point(59, 280);
            this.PrizePercentageLabel.Name = "PrizePercentageLabel";
            this.PrizePercentageLabel.Size = new System.Drawing.Size(212, 37);
            this.PrizePercentageLabel.TabIndex = 33;
            this.PrizePercentageLabel.Text = "Prize Percentage";
            // 
            // OrLabel
            // 
            this.OrLabel.AutoSize = true;
            this.OrLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.OrLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.OrLabel.Location = new System.Drawing.Point(198, 237);
            this.OrLabel.Name = "OrLabel";
            this.OrLabel.Size = new System.Drawing.Size(64, 37);
            this.OrLabel.TabIndex = 35;
            this.OrLabel.Text = "-or-";
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CreatePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CreatePrizeButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreatePrizeButton.Location = new System.Drawing.Point(134, 347);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(208, 47);
            this.CreatePrizeButton.TabIndex = 36;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            this.CreatePrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 617);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.OrLabel);
            this.Controls.Add(this.PrizePercentageValue);
            this.Controls.Add(this.PrizePercentageLabel);
            this.Controls.Add(this.PrizeAmountValue);
            this.Controls.Add(this.PrizeAmountLabel);
            this.Controls.Add(this.PlaceNameValue);
            this.Controls.Add(this.PlaceNameLabel);
            this.Controls.Add(this.PlaceNumberValue);
            this.Controls.Add(this.PlaceNumberLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox PlaceNumberValue;
        private System.Windows.Forms.Label PlaceNumberLabel;
        private System.Windows.Forms.TextBox PlaceNameValue;
        private System.Windows.Forms.Label PlaceNameLabel;
        private System.Windows.Forms.TextBox PrizeAmountValue;
        private System.Windows.Forms.Label PrizeAmountLabel;
        private System.Windows.Forms.TextBox PrizePercentageValue;
        private System.Windows.Forms.Label PrizePercentageLabel;
        private System.Windows.Forms.Label OrLabel;
        private System.Windows.Forms.Button CreatePrizeButton;
    }
}
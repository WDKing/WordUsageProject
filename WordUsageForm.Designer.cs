namespace WordUsageProject
{
    partial class WordUsageProjectForm
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
            this.WordToLocate = new System.Windows.Forms.ComboBox();
            this.WordToChooseLabel = new System.Windows.Forms.Label();
            this.FinalCountTextBox = new System.Windows.Forms.TextBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WordToLocate
            // 
            this.WordToLocate.FormattingEnabled = true;
            this.WordToLocate.Location = new System.Drawing.Point(215, 96);
            this.WordToLocate.Name = "WordToLocate";
            this.WordToLocate.Size = new System.Drawing.Size(332, 23);
            this.WordToLocate.TabIndex = 0;
            this.WordToLocate.SelectedIndexChanged += new System.EventHandler(this.WordToLocate_SelectedIndexChanged);
            // 
            // WordToChooseLabel
            // 
            this.WordToChooseLabel.AutoSize = true;
            this.WordToChooseLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordToChooseLabel.Location = new System.Drawing.Point(12, 98);
            this.WordToChooseLabel.Name = "WordToChooseLabel";
            this.WordToChooseLabel.Size = new System.Drawing.Size(197, 21);
            this.WordToChooseLabel.TabIndex = 1;
            this.WordToChooseLabel.Text = "Choose the Word to Count:";
            // 
            // FinalCountTextBox
            // 
            this.FinalCountTextBox.Location = new System.Drawing.Point(12, 140);
            this.FinalCountTextBox.Name = "FinalCountTextBox";
            this.FinalCountTextBox.Size = new System.Drawing.Size(535, 23);
            this.FinalCountTextBox.TabIndex = 2;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(209, 32);
            this.HeaderLabel.TabIndex = 3;
            this.HeaderLabel.Text = "Moby Dick Project";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 52);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(527, 21);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "This project displays the count of the chosen word in the text of Moby Dick.";
            // 
            // WordUsageProjectForm
            // 
            this.ClientSize = new System.Drawing.Size(562, 223);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.FinalCountTextBox);
            this.Controls.Add(this.WordToChooseLabel);
            this.Controls.Add(this.WordToLocate);
            this.Name = "WordUsageProjectForm";
            this.Load += new System.EventHandler(this.WordUsageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox WordToLocate;
        private Label WordToChooseLabel;
        private TextBox FinalCountTextBox;
        private Label HeaderLabel;
        private Label DescriptionLabel;
    }
}
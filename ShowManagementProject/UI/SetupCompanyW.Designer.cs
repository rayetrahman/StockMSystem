namespace ShockManagementProject.UI
{
    partial class SetupCompanyW
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
            this.hiddenIdLabel = new System.Windows.Forms.Label();
            this.companylistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.showMessageLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.saveCompanyButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // hiddenIdLabel
            // 
            this.hiddenIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hiddenIdLabel.AutoSize = true;
            this.hiddenIdLabel.Location = new System.Drawing.Point(448, 36);
            this.hiddenIdLabel.Name = "hiddenIdLabel";
            this.hiddenIdLabel.Size = new System.Drawing.Size(0, 13);
            this.hiddenIdLabel.TabIndex = 27;
            this.hiddenIdLabel.Visible = false;
            // 
            // companylistView
            // 
            this.companylistView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.companylistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.companylistView.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.companylistView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companylistView.ForeColor = System.Drawing.Color.DarkGreen;
            this.companylistView.FullRowSelect = true;
            this.companylistView.GridLines = true;
            this.companylistView.Location = new System.Drawing.Point(111, 246);
            this.companylistView.Name = "companylistView";
            this.companylistView.Size = new System.Drawing.Size(361, 205);
            this.companylistView.TabIndex = 26;
            this.companylistView.UseCompatibleStateImageBehavior = false;
            this.companylistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SL";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Company";
            this.columnHeader2.Width = 284;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(78, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(436, 37);
            this.label4.TabIndex = 25;
            this.label4.Text = "     Setup New Company     ";
            // 
            // showMessageLabel
            // 
            this.showMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showMessageLabel.AutoSize = true;
            this.showMessageLabel.Location = new System.Drawing.Point(211, 90);
            this.showMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showMessageLabel.Name = "showMessageLabel";
            this.showMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.showMessageLabel.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(107, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Company List :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(107, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Company Name :";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.companyNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameTextBox.Location = new System.Drawing.Point(265, 125);
            this.companyNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(207, 26);
            this.companyNameTextBox.TabIndex = 20;
            // 
            // saveCompanyButton
            // 
            this.saveCompanyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveCompanyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCompanyButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.saveCompanyButton.Location = new System.Drawing.Point(350, 166);
            this.saveCompanyButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveCompanyButton.Name = "saveCompanyButton";
            this.saveCompanyButton.Size = new System.Drawing.Size(122, 28);
            this.saveCompanyButton.TabIndex = 21;
            this.saveCompanyButton.Text = "Save ";
            this.saveCompanyButton.UseVisualStyleBackColor = true;
            this.saveCompanyButton.Click += new System.EventHandler(this.saveCompanyButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Location = new System.Drawing.Point(85, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 390);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // SetupCompanyW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 497);
            this.Controls.Add(this.hiddenIdLabel);
            this.Controls.Add(this.companylistView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showMessageLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.saveCompanyButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "SetupCompanyW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup Company";
            this.Load += new System.EventHandler(this.SetupCompanyW_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hiddenIdLabel;
        private System.Windows.Forms.ListView companylistView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label showMessageLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.Button saveCompanyButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
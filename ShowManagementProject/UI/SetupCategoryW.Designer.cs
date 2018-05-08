namespace ShockManagementProject.UI
{
    partial class SetupCategoryW
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
            this.categoryListView = new System.Windows.Forms.ListView();
            this.SL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.showMessageLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.saveCategoryBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hiddenIdLabel
            // 
            this.hiddenIdLabel.AutoSize = true;
            this.hiddenIdLabel.Location = new System.Drawing.Point(470, 1);
            this.hiddenIdLabel.Name = "hiddenIdLabel";
            this.hiddenIdLabel.Size = new System.Drawing.Size(0, 13);
            this.hiddenIdLabel.TabIndex = 18;
            this.hiddenIdLabel.Visible = false;
            // 
            // categoryListView
            // 
            this.categoryListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SL,
            this.columnHeader1});
            this.categoryListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryListView.ForeColor = System.Drawing.Color.DarkGreen;
            this.categoryListView.FullRowSelect = true;
            this.categoryListView.GridLines = true;
            this.categoryListView.Location = new System.Drawing.Point(107, 227);
            this.categoryListView.Name = "categoryListView";
            this.categoryListView.Size = new System.Drawing.Size(347, 223);
            this.categoryListView.TabIndex = 17;
            this.categoryListView.UseCompatibleStateImageBehavior = false;
            this.categoryListView.View = System.Windows.Forms.View.Details;
            this.categoryListView.DoubleClick += new System.EventHandler(this.categoryListView_DoubleClick);
            // 
            // SL
            // 
            this.SL.Text = "SL";
            this.SL.Width = 103;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Category";
            this.columnHeader1.Width = 271;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(72, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "     Setup New  Category   ";
            // 
            // showMessageLabel
            // 
            this.showMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showMessageLabel.AutoSize = true;
            this.showMessageLabel.Location = new System.Drawing.Point(190, 94);
            this.showMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showMessageLabel.Name = "showMessageLabel";
            this.showMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.showMessageLabel.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(100, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Category List :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(21, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Category Name :";
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameTextBox.Location = new System.Drawing.Point(235, 114);
            this.categoryNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(219, 26);
            this.categoryNameTextBox.TabIndex = 11;
            // 
            // saveCategoryBtn
            // 
            this.saveCategoryBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCategoryBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.saveCategoryBtn.Location = new System.Drawing.Point(340, 148);
            this.saveCategoryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveCategoryBtn.Name = "saveCategoryBtn";
            this.saveCategoryBtn.Size = new System.Drawing.Size(114, 35);
            this.saveCategoryBtn.TabIndex = 12;
            this.saveCategoryBtn.Text = "Save";
            this.saveCategoryBtn.UseVisualStyleBackColor = true;
            this.saveCategoryBtn.Click += new System.EventHandler(this.saveCategoryBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Location = new System.Drawing.Point(64, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 397);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // SetupCategoryW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 503);
            this.Controls.Add(this.hiddenIdLabel);
            this.Controls.Add(this.categoryListView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showMessageLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.saveCategoryBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "SetupCategoryW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup New Category";
            this.Load += new System.EventHandler(this.SetupCategoryW_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hiddenIdLabel;
        private System.Windows.Forms.ListView categoryListView;
        private System.Windows.Forms.ColumnHeader SL;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label showMessageLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.Button saveCategoryBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
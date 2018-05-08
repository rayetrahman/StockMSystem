namespace ShockManagementProject
{
    partial class StockOutwf
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
            this.addStockOutBtn = new System.Windows.Forms.Button();
            this.quentityTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.availableQuentityTb = new System.Windows.Forms.TextBox();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.itemNameComboBox = new System.Windows.Forms.ComboBox();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.showListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sellButton = new System.Windows.Forms.Button();
            this.damageButton = new System.Windows.Forms.Button();
            this.lostButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addStockOutBtn
            // 
            this.addStockOutBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addStockOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStockOutBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.addStockOutBtn.Location = new System.Drawing.Point(337, 233);
            this.addStockOutBtn.Name = "addStockOutBtn";
            this.addStockOutBtn.Size = new System.Drawing.Size(104, 29);
            this.addStockOutBtn.TabIndex = 5;
            this.addStockOutBtn.Text = "Add";
            this.addStockOutBtn.UseVisualStyleBackColor = true;
            this.addStockOutBtn.Click += new System.EventHandler(this.addStockOutBtn_Click);
            // 
            // quentityTextBox
            // 
            this.quentityTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quentityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quentityTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.quentityTextBox.Location = new System.Drawing.Point(262, 195);
            this.quentityTextBox.Name = "quentityTextBox";
            this.quentityTextBox.Size = new System.Drawing.Size(179, 26);
            this.quentityTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label5.Location = new System.Drawing.Point(104, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(402, 37);
            this.label5.TabIndex = 48;
            this.label5.Text = "        Item Stock Out        ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(106, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(39, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Available Quantity";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(66, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Reorder Level";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(87, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(54, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Company Name";
            // 
            // availableQuentityTb
            // 
            this.availableQuentityTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.availableQuentityTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableQuentityTb.ForeColor = System.Drawing.Color.DarkGreen;
            this.availableQuentityTb.Location = new System.Drawing.Point(194, 115);
            this.availableQuentityTb.Name = "availableQuentityTb";
            this.availableQuentityTb.ReadOnly = true;
            this.availableQuentityTb.Size = new System.Drawing.Size(179, 26);
            this.availableQuentityTb.TabIndex = 2;
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reorderLevelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderLevelTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.reorderLevelTextBox.Location = new System.Drawing.Point(194, 83);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.ReadOnly = true;
            this.reorderLevelTextBox.Size = new System.Drawing.Size(179, 26);
            this.reorderLevelTextBox.TabIndex = 3;
            // 
            // itemNameComboBox
            // 
            this.itemNameComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.itemNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itemNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameComboBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.itemNameComboBox.FormattingEnabled = true;
            this.itemNameComboBox.Location = new System.Drawing.Point(262, 97);
            this.itemNameComboBox.Name = "itemNameComboBox";
            this.itemNameComboBox.Size = new System.Drawing.Size(179, 28);
            this.itemNameComboBox.TabIndex = 1;
            this.itemNameComboBox.SelectionChangeCommitted += new System.EventHandler(this.itemNameComboBox_SelectionChangeCommitted);
            // 
            // companyComboBox
            // 
            this.companyComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.companyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyComboBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(262, 63);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(179, 28);
            this.companyComboBox.TabIndex = 0;
            // 
            // showListView
            // 
            this.showListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.showListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showListView.ForeColor = System.Drawing.Color.DarkGreen;
            this.showListView.FullRowSelect = true;
            this.showListView.GridLines = true;
            this.showListView.Location = new System.Drawing.Point(96, 270);
            this.showListView.Name = "showListView";
            this.showListView.Size = new System.Drawing.Size(345, 219);
            this.showListView.TabIndex = 51;
            this.showListView.UseCompatibleStateImageBehavior = false;
            this.showListView.View = System.Windows.Forms.View.Details;
            this.showListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.showListView_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SL";
            this.columnHeader1.Width = 49;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item";
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Company";
            this.columnHeader3.Width = 109;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            this.columnHeader4.Width = 87;
            // 
            // sellButton
            // 
            this.sellButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.sellButton.Location = new System.Drawing.Point(458, 295);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(98, 33);
            this.sellButton.TabIndex = 6;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // damageButton
            // 
            this.damageButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.damageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.damageButton.Location = new System.Drawing.Point(458, 362);
            this.damageButton.Name = "damageButton";
            this.damageButton.Size = new System.Drawing.Size(98, 33);
            this.damageButton.TabIndex = 7;
            this.damageButton.Text = "Damage";
            this.damageButton.UseVisualStyleBackColor = true;
            this.damageButton.Click += new System.EventHandler(this.damageButton_Click);
            // 
            // lostButton
            // 
            this.lostButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.lostButton.Location = new System.Drawing.Point(458, 427);
            this.lostButton.Name = "lostButton";
            this.lostButton.Size = new System.Drawing.Size(98, 33);
            this.lostButton.TabIndex = 8;
            this.lostButton.Text = "Lost";
            this.lostButton.UseVisualStyleBackColor = true;
            this.lostButton.Click += new System.EventHandler(this.lostButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.reorderLevelTextBox);
            this.groupBox1.Controls.Add(this.availableQuentityTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(68, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 451);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // StockOutwf
            // 
            this.AcceptButton = this.addStockOutBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 515);
            this.Controls.Add(this.lostButton);
            this.Controls.Add(this.damageButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.showListView);
            this.Controls.Add(this.addStockOutBtn);
            this.Controls.Add(this.quentityTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.itemNameComboBox);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockOutwf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Out";
            this.Load += new System.EventHandler(this.StockOutwf_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStockOutBtn;
        private System.Windows.Forms.TextBox quentityTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox availableQuentityTb;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.ComboBox itemNameComboBox;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ListView showListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button damageButton;
        private System.Windows.Forms.Button lostButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
namespace New_Database
{
    partial class New_Database
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
            this.T_EarningsDataGridview = new System.Windows.Forms.DataGridView();
            this.Btn_Switch = new System.Windows.Forms.Button();
            this.SaveToCSV = new System.Windows.Forms.Button();
            this.ClkToPDF = new System.Windows.Forms.Button();
            this.AddRow_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earnings_PK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earnings_Deleted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Earnings_Staff_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earnings_Staff_Name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Earnings_Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earnings_Customer_Name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Earnings_Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earnings_earnings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earnings_Completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Earnings_Contract_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earnings_Payment_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.T_EarningsDataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // T_EarningsDataGridview
            // 
            this.T_EarningsDataGridview.AllowUserToAddRows = false;
            this.T_EarningsDataGridview.AllowUserToOrderColumns = true;
            this.T_EarningsDataGridview.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.T_EarningsDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.T_EarningsDataGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Earnings_PK,
            this.Earnings_Deleted,
            this.Earnings_Staff_ID,
            this.Earnings_Staff_Name,
            this.Earnings_Customer_ID,
            this.Earnings_Customer_Name,
            this.Earnings_Content,
            this.Earnings_earnings,
            this.Earnings_Completed,
            this.Earnings_Contract_Date,
            this.Earnings_Payment_Date});
            this.T_EarningsDataGridview.Location = new System.Drawing.Point(30, 24);
            this.T_EarningsDataGridview.Name = "T_EarningsDataGridview";
            this.T_EarningsDataGridview.RowHeadersWidth = 51;
            this.T_EarningsDataGridview.Size = new System.Drawing.Size(821, 381);
            this.T_EarningsDataGridview.TabIndex = 0;
            this.T_EarningsDataGridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.T_EarningsDataGridview_CellClick);
            this.T_EarningsDataGridview.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.T_EarningsDataGridview_CellEndEdit);
            this.T_EarningsDataGridview.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.T_EarningsDataGridview_ColumnWidthChanged);
            this.T_EarningsDataGridview.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.T_EarningsDataGridview_EditingControlShowing);
            this.T_EarningsDataGridview.Scroll += new System.Windows.Forms.ScrollEventHandler(this.T_EarningsDataGridview_Scroll);
            // 
            // Btn_Switch
            // 
            this.Btn_Switch.Location = new System.Drawing.Point(30, 433);
            this.Btn_Switch.Name = "Btn_Switch";
            this.Btn_Switch.Size = new System.Drawing.Size(80, 46);
            this.Btn_Switch.TabIndex = 1;
            this.Btn_Switch.Text = "表示切替";
            this.Btn_Switch.UseVisualStyleBackColor = true;
            this.Btn_Switch.Click += new System.EventHandler(this.Btn_Switch_Click);
            // 
            // SaveToCSV
            // 
            this.SaveToCSV.Location = new System.Drawing.Point(202, 433);
            this.SaveToCSV.Name = "SaveToCSV";
            this.SaveToCSV.Size = new System.Drawing.Size(91, 46);
            this.SaveToCSV.TabIndex = 2;
            this.SaveToCSV.Text = "CSV出力";
            this.SaveToCSV.UseVisualStyleBackColor = true;
            this.SaveToCSV.Click += new System.EventHandler(this.SaveToCSV_Click);
            // 
            // ClkToPDF
            // 
            this.ClkToPDF.Location = new System.Drawing.Point(334, 433);
            this.ClkToPDF.Name = "ClkToPDF";
            this.ClkToPDF.Size = new System.Drawing.Size(101, 46);
            this.ClkToPDF.TabIndex = 3;
            this.ClkToPDF.Text = "帳表出力";
            this.ClkToPDF.UseVisualStyleBackColor = true;
            this.ClkToPDF.Click += new System.EventHandler(this.ClkToPDF_Click);
            // 
            // AddRow_Btn
            // 
            this.AddRow_Btn.Location = new System.Drawing.Point(522, 433);
            this.AddRow_Btn.Name = "AddRow_Btn";
            this.AddRow_Btn.Size = new System.Drawing.Size(87, 46);
            this.AddRow_Btn.TabIndex = 4;
            this.AddRow_Btn.Text = "新規追加";
            this.AddRow_Btn.UseVisualStyleBackColor = true;
            this.AddRow_Btn.Click += new System.EventHandler(this.AddRow_Btn_Click);
            // 
            // Save_Btn
            // 
            this.Save_Btn.Location = new System.Drawing.Point(647, 433);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(89, 46);
            this.Save_Btn.TabIndex = 5;
            this.Save_Btn.Text = "更新";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(766, 433);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(85, 46);
            this.CloseBtn.TabIndex = 6;
            this.CloseBtn.Text = "終了";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // No
            // 
            this.No.DataPropertyName = "no";
            this.No.HeaderText = "No.";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.Width = 60;
            // 
            // Earnings_PK
            // 
            this.Earnings_PK.HeaderText = "T_EARNINGS_PK";
            this.Earnings_PK.MinimumWidth = 6;
            this.Earnings_PK.Name = "Earnings_PK";
            this.Earnings_PK.Visible = false;
            this.Earnings_PK.Width = 125;
            // 
            // Earnings_Deleted
            // 
            this.Earnings_Deleted.DataPropertyName = "Delete";
            this.Earnings_Deleted.HeaderText = "削除";
            this.Earnings_Deleted.MinimumWidth = 6;
            this.Earnings_Deleted.Name = "Earnings_Deleted";
            this.Earnings_Deleted.Width = 70;
            // 
            // Earnings_Staff_ID
            // 
            this.Earnings_Staff_ID.DataPropertyName = "STAFF_ID";
            this.Earnings_Staff_ID.HeaderText = "従業員ID";
            this.Earnings_Staff_ID.MinimumWidth = 6;
            this.Earnings_Staff_ID.Name = "Earnings_Staff_ID";
            this.Earnings_Staff_ID.Width = 90;
            // 
            // Earnings_Staff_Name
            // 
            this.Earnings_Staff_Name.DataPropertyName = "staffName";
            this.Earnings_Staff_Name.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Earnings_Staff_Name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Earnings_Staff_Name.HeaderText = "従業員名";
            this.Earnings_Staff_Name.MinimumWidth = 6;
            this.Earnings_Staff_Name.Name = "Earnings_Staff_Name";
            this.Earnings_Staff_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Earnings_Staff_Name.Width = 125;
            // 
            // Earnings_Customer_ID
            // 
            this.Earnings_Customer_ID.DataPropertyName = "customerID";
            this.Earnings_Customer_ID.HeaderText = "顧客ID";
            this.Earnings_Customer_ID.MinimumWidth = 6;
            this.Earnings_Customer_ID.Name = "Earnings_Customer_ID";
            this.Earnings_Customer_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Earnings_Customer_ID.Width = 80;
            // 
            // Earnings_Customer_Name
            // 
            this.Earnings_Customer_Name.DataPropertyName = "customerName";
            this.Earnings_Customer_Name.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Earnings_Customer_Name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Earnings_Customer_Name.HeaderText = "顧客名";
            this.Earnings_Customer_Name.MinimumWidth = 6;
            this.Earnings_Customer_Name.Name = "Earnings_Customer_Name";
            this.Earnings_Customer_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Earnings_Customer_Name.Width = 125;
            // 
            // Earnings_Content
            // 
            this.Earnings_Content.DataPropertyName = "content";
            this.Earnings_Content.HeaderText = "納品物";
            this.Earnings_Content.MinimumWidth = 6;
            this.Earnings_Content.Name = "Earnings_Content";
            this.Earnings_Content.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Earnings_Content.Width = 90;
            // 
            // Earnings_earnings
            // 
            this.Earnings_earnings.DataPropertyName = "earnings";
            this.Earnings_earnings.HeaderText = "売上額";
            this.Earnings_earnings.MinimumWidth = 6;
            this.Earnings_earnings.Name = "Earnings_earnings";
            this.Earnings_earnings.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Earnings_earnings.Width = 80;
            // 
            // Earnings_Completed
            // 
            this.Earnings_Completed.DataPropertyName = "completed";
            this.Earnings_Completed.HeaderText = "納品";
            this.Earnings_Completed.MinimumWidth = 6;
            this.Earnings_Completed.Name = "Earnings_Completed";
            this.Earnings_Completed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Earnings_Completed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Earnings_Completed.Width = 70;
            // 
            // Earnings_Contract_Date
            // 
            this.Earnings_Contract_Date.DataPropertyName = "contractDate";
            this.Earnings_Contract_Date.HeaderText = "契約日";
            this.Earnings_Contract_Date.MinimumWidth = 6;
            this.Earnings_Contract_Date.Name = "Earnings_Contract_Date";
            this.Earnings_Contract_Date.Width = 125;
            // 
            // Earnings_Payment_Date
            // 
            this.Earnings_Payment_Date.DataPropertyName = "paymentDate";
            this.Earnings_Payment_Date.HeaderText = "入金日";
            this.Earnings_Payment_Date.MinimumWidth = 6;
            this.Earnings_Payment_Date.Name = "Earnings_Payment_Date";
            this.Earnings_Payment_Date.Width = 125;
            // 
            // New_Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 507);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.AddRow_Btn);
            this.Controls.Add(this.ClkToPDF);
            this.Controls.Add(this.SaveToCSV);
            this.Controls.Add(this.Btn_Switch);
            this.Controls.Add(this.T_EarningsDataGridview);
            this.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "New_Database";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "リスト";
            this.Load += new System.EventHandler(this.New_Database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.T_EarningsDataGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView T_EarningsDataGridview;
        private System.Windows.Forms.Button Btn_Switch;
        private System.Windows.Forms.Button SaveToCSV;
        private System.Windows.Forms.Button ClkToPDF;
        private System.Windows.Forms.Button AddRow_Btn;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earnings_PK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Earnings_Deleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earnings_Staff_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Earnings_Staff_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earnings_Customer_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Earnings_Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earnings_Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earnings_earnings;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Earnings_Completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earnings_Contract_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earnings_Payment_Date;
    }
}


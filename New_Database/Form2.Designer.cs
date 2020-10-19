namespace New_Database
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.AddRow_Btn = new System.Windows.Forms.Button();
            this.ClkToPDF = new System.Windows.Forms.Button();
            this.SaveToCSV = new System.Windows.Forms.Button();
            this.Btn_Switch = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earnings_PK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earnings_Deleted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Earnings_Staff_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earnings_Staff_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earnings_Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earnings_Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earnings_Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earnings_earnings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earnings_Completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Earnings_Contract_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earnings_Payment_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.T_EarningsDataGridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // T_EarningsDataGridview
            // 
            this.T_EarningsDataGridview.AllowUserToAddRows = false;
            this.T_EarningsDataGridview.AllowUserToDeleteRows = false;
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
            this.T_EarningsDataGridview.Location = new System.Drawing.Point(37, 28);
            this.T_EarningsDataGridview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.T_EarningsDataGridview.Name = "T_EarningsDataGridview";
            this.T_EarningsDataGridview.ReadOnly = true;
            this.T_EarningsDataGridview.RowHeadersWidth = 51;
            this.T_EarningsDataGridview.Size = new System.Drawing.Size(1099, 337);
            this.T_EarningsDataGridview.TabIndex = 0;
            this.T_EarningsDataGridview.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.T_EarningsDataGridview_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 383);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1099, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker2.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(889, 103);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(145, 26);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker1.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(609, 103);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(227, 28);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(392, 108);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(609, 61);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 23);
            this.comboBox2.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(609, 24);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 23);
            this.comboBox1.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(889, 63);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(145, 22);
            this.textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(889, 24);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 22);
            this.textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(392, 65);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(72, 22);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(392, 24);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(72, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(57, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 22);
            this.textBox1.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(799, 106);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "入金日";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(524, 107);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "契約日";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(327, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "納品";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(524, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "顧客名";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(799, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "売上額";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(305, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "顧客ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(799, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "納品物";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(503, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "従業員名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(284, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "従業員ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(164, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "削除";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "No";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(1019, 553);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(113, 53);
            this.CloseBtn.TabIndex = 12;
            this.CloseBtn.Text = "終了";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Save_Btn
            // 
            this.Save_Btn.Location = new System.Drawing.Point(860, 553);
            this.Save_Btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(119, 53);
            this.Save_Btn.TabIndex = 11;
            this.Save_Btn.Text = "更新";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // AddRow_Btn
            // 
            this.AddRow_Btn.Location = new System.Drawing.Point(693, 553);
            this.AddRow_Btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddRow_Btn.Name = "AddRow_Btn";
            this.AddRow_Btn.Size = new System.Drawing.Size(116, 53);
            this.AddRow_Btn.TabIndex = 10;
            this.AddRow_Btn.Text = "新規追加";
            this.AddRow_Btn.UseVisualStyleBackColor = true;
            this.AddRow_Btn.Click += new System.EventHandler(this.AddRow_Btn_Click);
            // 
            // ClkToPDF
            // 
            this.ClkToPDF.Location = new System.Drawing.Point(443, 553);
            this.ClkToPDF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClkToPDF.Name = "ClkToPDF";
            this.ClkToPDF.Size = new System.Drawing.Size(135, 53);
            this.ClkToPDF.TabIndex = 9;
            this.ClkToPDF.Text = "帳表出力";
            this.ClkToPDF.UseVisualStyleBackColor = true;
            this.ClkToPDF.Click += new System.EventHandler(this.ClkToPDF_Click);
            // 
            // SaveToCSV
            // 
            this.SaveToCSV.Location = new System.Drawing.Point(267, 553);
            this.SaveToCSV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveToCSV.Name = "SaveToCSV";
            this.SaveToCSV.Size = new System.Drawing.Size(121, 53);
            this.SaveToCSV.TabIndex = 8;
            this.SaveToCSV.Text = "CSV出力";
            this.SaveToCSV.UseVisualStyleBackColor = true;
            this.SaveToCSV.Click += new System.EventHandler(this.SaveToCSV_Click);
            // 
            // Btn_Switch
            // 
            this.Btn_Switch.Location = new System.Drawing.Point(37, 553);
            this.Btn_Switch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Switch.Name = "Btn_Switch";
            this.Btn_Switch.Size = new System.Drawing.Size(107, 53);
            this.Btn_Switch.TabIndex = 7;
            this.Btn_Switch.Text = "表示切替";
            this.Btn_Switch.UseVisualStyleBackColor = true;
            this.Btn_Switch.Click += new System.EventHandler(this.Btn_Switch_Click);
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 60;
            // 
            // Earnings_PK
            // 
            this.Earnings_PK.HeaderText = "T_EARNINGS_PK";
            this.Earnings_PK.MinimumWidth = 6;
            this.Earnings_PK.Name = "Earnings_PK";
            this.Earnings_PK.ReadOnly = true;
            this.Earnings_PK.Visible = false;
            this.Earnings_PK.Width = 125;
            // 
            // Earnings_Deleted
            // 
            this.Earnings_Deleted.HeaderText = "削除";
            this.Earnings_Deleted.MinimumWidth = 6;
            this.Earnings_Deleted.Name = "Earnings_Deleted";
            this.Earnings_Deleted.ReadOnly = true;
            this.Earnings_Deleted.Width = 70;
            // 
            // Earnings_Staff_ID
            // 
            this.Earnings_Staff_ID.HeaderText = "従業員ID";
            this.Earnings_Staff_ID.MinimumWidth = 6;
            this.Earnings_Staff_ID.Name = "Earnings_Staff_ID";
            this.Earnings_Staff_ID.ReadOnly = true;
            this.Earnings_Staff_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Earnings_Staff_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Earnings_Staff_ID.Width = 80;
            // 
            // Earnings_Staff_Name
            // 
            this.Earnings_Staff_Name.HeaderText = "従業員名";
            this.Earnings_Staff_Name.MinimumWidth = 6;
            this.Earnings_Staff_Name.Name = "Earnings_Staff_Name";
            this.Earnings_Staff_Name.ReadOnly = true;
            this.Earnings_Staff_Name.Width = 125;
            // 
            // Earnings_Customer_ID
            // 
            this.Earnings_Customer_ID.HeaderText = "顧客ID";
            this.Earnings_Customer_ID.MinimumWidth = 6;
            this.Earnings_Customer_ID.Name = "Earnings_Customer_ID";
            this.Earnings_Customer_ID.ReadOnly = true;
            this.Earnings_Customer_ID.Width = 80;
            // 
            // Earnings_Customer_Name
            // 
            this.Earnings_Customer_Name.HeaderText = "顧客名";
            this.Earnings_Customer_Name.MinimumWidth = 6;
            this.Earnings_Customer_Name.Name = "Earnings_Customer_Name";
            this.Earnings_Customer_Name.ReadOnly = true;
            this.Earnings_Customer_Name.Width = 125;
            // 
            // Earnings_Content
            // 
            this.Earnings_Content.HeaderText = "納品物";
            this.Earnings_Content.MinimumWidth = 6;
            this.Earnings_Content.Name = "Earnings_Content";
            this.Earnings_Content.ReadOnly = true;
            this.Earnings_Content.Width = 80;
            // 
            // Earnings_earnings
            // 
            this.Earnings_earnings.HeaderText = "売上額";
            this.Earnings_earnings.MinimumWidth = 6;
            this.Earnings_earnings.Name = "Earnings_earnings";
            this.Earnings_earnings.ReadOnly = true;
            this.Earnings_earnings.Width = 80;
            // 
            // Earnings_Completed
            // 
            this.Earnings_Completed.HeaderText = "納品";
            this.Earnings_Completed.MinimumWidth = 6;
            this.Earnings_Completed.Name = "Earnings_Completed";
            this.Earnings_Completed.ReadOnly = true;
            this.Earnings_Completed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Earnings_Completed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Earnings_Completed.Width = 70;
            // 
            // Earnings_Contract_Date
            // 
            this.Earnings_Contract_Date.HeaderText = "契約日";
            this.Earnings_Contract_Date.MinimumWidth = 6;
            this.Earnings_Contract_Date.Name = "Earnings_Contract_Date";
            this.Earnings_Contract_Date.ReadOnly = true;
            this.Earnings_Contract_Date.Width = 125;
            // 
            // Earnings_Payment_Date
            // 
            this.Earnings_Payment_Date.HeaderText = "入金日";
            this.Earnings_Payment_Date.MinimumWidth = 6;
            this.Earnings_Payment_Date.Name = "Earnings_Payment_Date";
            this.Earnings_Payment_Date.ReadOnly = true;
            this.Earnings_Payment_Date.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 630);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.AddRow_Btn);
            this.Controls.Add(this.ClkToPDF);
            this.Controls.Add(this.SaveToCSV);
            this.Controls.Add(this.Btn_Switch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.T_EarningsDataGridview);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "詳細";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.T_EarningsDataGridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView T_EarningsDataGridview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Button AddRow_Btn;
        private System.Windows.Forms.Button ClkToPDF;
        private System.Windows.Forms.Button SaveToCSV;
        private System.Windows.Forms.Button Btn_Switch;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earnings_PK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Earnings_Deleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earnings_Staff_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earnings_Staff_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earnings_Customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earnings_Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earnings_Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earnings_earnings;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Earnings_Completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earnings_Contract_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earnings_Payment_Date;
    }
}
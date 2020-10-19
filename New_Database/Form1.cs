using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;

namespace New_Database
{
    public partial class New_Database : Form
    {
        //Access File Connection  
        private const string DbPFile = "Test1.mdb";

        DateTimePicker DTP = new DateTimePicker();
        
        System.Drawing.Rectangle _Rectangle;
        int addNewRowNumber, SelectedRowIndex;
        int databaseTotalRows;
        DataTable dataTable;
        List<int> EditRows = new List<int>();
        public New_Database()
        {
            InitializeComponent();
            //Date-Time Picker
            T_EarningsDataGridview.Controls.Add(DTP);
            DTP.Visible = false;
            DTP.Format = DateTimePickerFormat.Custom;
            DTP.CustomFormat = "yyyy/MM/dd";
            DTP.TextChanged += new EventHandler(DTP_TextChange);
            DTP.CloseUp += new EventHandler(Dtp_CloseUp);
            DTP.KeyDown += Dtp_KeyDown;
            Staff_Name_Combobox();
            Customer_Name_Combobox();

            //ヘッダースタイルの設定
            this.T_EarningsDataGridview.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void T_EarningsDataGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if ((e.ColumnIndex == 10 || e.ColumnIndex == 11) && e.RowIndex >= 0)
            {
                DTP.CustomFormat = "yyyy/MM/dd";
                DTP.CustomFormat = " ";
                
                if (T_EarningsDataGridview.CurrentCell.Value != null)
                {
                    
                    DTP.Text = T_EarningsDataGridview.CurrentCell.Value.ToString();

                }
                else
                {
                    DTP.Value = DateTime.Now;
                    DTP.CustomFormat = " ";
                }

                _Rectangle = T_EarningsDataGridview.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                DTP.Size = new Size(_Rectangle.Width, _Rectangle.Height);
                DTP.Location = new Point(_Rectangle.X, _Rectangle.Y);
                DTP.Visible = true;
            }
            else
            {
                DTP.Visible = false;
            }
        }
        private void DTP_TextChange(object sender, EventArgs e)
        {
            T_EarningsDataGridview.CurrentCell.Value = DTP.Text.ToString();
            int editRowIndex = T_EarningsDataGridview.CurrentRow.Index;

            string DateStr = T_EarningsDataGridview.CurrentCell.Value.ToString();
            if (!string.IsNullOrWhiteSpace(DateStr))
            {
                DTP.CustomFormat = "yyyy/MM/dd";
                DateTime dateTime = Convert.ToDateTime(DateStr);
                string date = dateTime.ToString("yyyy/MM/dd");
                if (date != DTP.Text)
                {

                    ////編集した行を「list<int>」に追加する
                    if (editRowIndex < databaseTotalRows)
                    {
                        bool AlreadyHave = EditRows.Contains(editRowIndex);
                        //編集した行を[List<int>]にあるかどうか、確認
                        if (!AlreadyHave)
                        {
                            EditRows.Add(editRowIndex);
                        }
                    }
                    T_EarningsDataGridview.CurrentCell.Value = DTP.Text.ToString();
                }
            }
            else
            {
                DTP.CustomFormat = "yyyy/MM/dd";

                if (DateStr != DTP.Text)
                {
                    //編集した行を「list<int>」に追加する
                    if (editRowIndex < databaseTotalRows)
                    {
                        bool AlreadyHave = EditRows.Contains(editRowIndex);

                        //編集した行を[List<int>]にあるかどうか、確認
                        if (!AlreadyHave)
                        {
                            EditRows.Add(editRowIndex);

                        }
                    }

                    T_EarningsDataGridview.CurrentCell.Value = DTP.Text.ToString();
                }
            }
        }
        private void Dtp_CloseUp(object sender, EventArgs e)
        {
            DTP.Visible = false;

        }
        private void T_EarningsDataGridview_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            DTP.Visible = false;
        }

        private void T_EarningsDataGridview_Scroll(object sender, ScrollEventArgs e)
        {
            DTP.Visible = false;
        }
        private void Dtp_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                DTP.CustomFormat = " ";
                T_EarningsDataGridview.CurrentCell.Value = DBNull.Value;

                int editRowIndex = T_EarningsDataGridview.CurrentRow.Index;

                //編集した行を「list<int>」に追加する
                if (editRowIndex < databaseTotalRows)
                {
                    bool AlreadyHave = EditRows.Contains(editRowIndex);

                    //編集した行を[List<int>]にあるかどうか、確認
                    if (!AlreadyHave)
                    {
                        EditRows.Add(editRowIndex);
                    }
                }
            }
        }

        private void New_Database_Load(object sender, EventArgs e)
        {
            using (var connection = new OleDbConnection())
            using (var command = new OleDbCommand())
            {
                var dt = new DataTable();

                // Accessファイルは、実行ファイルと同じフォルダに置いてあることを前提にしています。
                // 変更する場合、以下を修正してください。
                var dbPath = System.AppDomain.CurrentDomain.BaseDirectory + DbPFile;
                // 接続文字列
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath;

                try
                {
                    // 接続します。
                    connection.Open();

                    // SQL文を設定
                    command.CommandText = "SELECT * FROM T_EARNINGS WHERE DELETED = @DELETED ORDER BY T_EARNINGS_PK";
                    command.Parameters.Add(new OleDbParameter("@DELETED", OleDbType.Boolean)).Value = false;
                    command.Connection = connection;

                    // SQLを実行
                    var odda = new OleDbDataAdapter();
                    odda.SelectCommand = command;

                    DataSet dataSet = new DataSet();
                    odda.Fill(dt);
                    T_EarningsDataGridview.AutoGenerateColumns = false;
                    T_EarningsDataGridview.DataSource = dt;
                    //T_EarningsDataGridview.Columns["Earnings_Contract_Date"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    //結果処理
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        T_EarningsDataGridview.Rows[i].Cells["No"].Value = (i + 1).ToString();
                        T_EarningsDataGridview.Rows[i].Cells["Earnings_PK"].Value = dt.Rows[i]["T_EARNINGS_PK"].ToString();
                        T_EarningsDataGridview.Rows[i].Cells["Earnings_Deleted"].Value = dt.Rows[i]["DELETED"].ToString();
                        T_EarningsDataGridview.Rows[i].Cells["Earnings_Staff_ID"].Value = dt.Rows[i]["STAFF_ID"].ToString();
                        T_EarningsDataGridview.Rows[i].Cells["Earnings_Staff_Name"].Value = dt.Rows[i]["STAFF_NAME"].ToString();
                        T_EarningsDataGridview.Rows[i].Cells["Earnings_Customer_ID"].Value = dt.Rows[i]["CUSTOMER_ID"].ToString();
                        T_EarningsDataGridview.Rows[i].Cells["Earnings_Customer_Name"].Value = dt.Rows[i]["CUSTOMER_NAME"].ToString();
                        T_EarningsDataGridview.Rows[i].Cells["Earnings_Content"].Value = dt.Rows[i]["CONTENT"].ToString();
                        T_EarningsDataGridview.Rows[i].Cells["Earnings_earnings"].Value = dt.Rows[i]["EARNINGS"].ToString();
                        T_EarningsDataGridview.Rows[i].Cells["Earnings_Completed"].Value = dt.Rows[i]["COMPLETED"].ToString();
                        if(!string.IsNullOrWhiteSpace(dt.Rows[i]["CONTRACT_DATE"].ToString()) )
                        {
                            DateTime ContractDate = (DateTime)dt.Rows[i]["CONTRACT_DATE"];
                            string ContractDateString=  ContractDate.ToString("yyyy/MM/dd");
                            T_EarningsDataGridview.Rows[i].Cells["Earnings_Contract_Date"].Value = ContractDateString;
                           
                        }
                        if (!string.IsNullOrWhiteSpace(dt.Rows[i]["PAYMENT_DATE"].ToString()))
                        {
                            DateTime ContractDate = (DateTime)dt.Rows[i]["PAYMENT_DATE"];
                            string ContractDateString = ContractDate.ToString("yyyy/MM/dd");
                            T_EarningsDataGridview.Rows[i].Cells["Earnings_Payment_Date"].Value = ContractDateString;

                        }
                        
                    }
                }

                finally
                {
                    // 接続を解除します。
                    connection.Close();
                }
            }
        }
        private void Customer_Name_Combobox()
        {
            using (var connection = new OleDbConnection())
            using (var command = new OleDbCommand())
            {
                var dt = new DataTable();

                // Accessファイルは、実行ファイルと同じフォルダに置いてあることを前提にしています。
                // 変更する場合、以下を修正してください。
                var dbPath = System.AppDomain.CurrentDomain.BaseDirectory + DbPFile;
                // 接続文字列
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath;

                try
                {
                    // 接続します。
                    connection.Open();

                    // SQL文を設定
                    command.CommandText = "SELECT * FROM M_CUSTOMER";
                    command.Connection = connection;

                    // SQLを実行
                    var odda = new OleDbDataAdapter();
                    odda.SelectCommand = command;
                    odda.Fill(dt);

                    // 結果処理
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        Earnings_Customer_Name.Items.Add(dt.Rows[i]["CUSTOMER_NAME"].ToString());

                    }
                }
                finally
                {
                    // 接続を解除します。
                    connection.Close();
                }
            }
        }

        private void CustomerNameCombobox_SelectionChange(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string customerName = cb.Text;

            using (var connection = new OleDbConnection())
            using (var command = new OleDbCommand())
            {
                var dt = new DataTable();

                // Accessファイルは、実行ファイルと同じフォルダに置いてあることを前提にしています。
                // 変更する場合、以下を修正してください。
                var dbPath = System.AppDomain.CurrentDomain.BaseDirectory + DbPFile;
                // 接続文字列
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath;

                try
                {
                    // 接続します。
                    connection.Open();

                    // SQL文を設定
                    command.CommandText = "SELECT * FROM M_CUSTOMER WHERE CUSTOMER_NAME=@customerName";
                    command.Parameters.AddWithValue("@customerName", customerName);
                    command.Connection = connection;

                    // SQLを実行
                    var odda = new OleDbDataAdapter();
                    odda.SelectCommand = command;
                    odda.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string customerId = dt.Rows[i]["CUSTOMER_ID"].ToString();
                        T_EarningsDataGridview.Rows[SelectedRowIndex].Cells["Earnings_Customer_ID"].Value = customerId;

                    }
                }
                
                finally
                {
                    // 接続を解除します。
                    connection.Close();
                }


            }
        }

        //Linking Data in DataGridView Staff_Name_Combobox
        private void Staff_Name_Combobox()
        {
            using (var connection = new OleDbConnection())
            using (var command = new OleDbCommand())
            {
                var dt = new DataTable();

                // Accessファイルは、実行ファイルと同じフォルダに置いてあることを前提にしています。
                // 変更する場合、以下を修正してください。
                var dbPath = System.AppDomain.CurrentDomain.BaseDirectory + DbPFile;
                // 接続文字列
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath;

                try
                {
                    // 接続します。
                    connection.Open();

                    // SQL文を設定
                    command.CommandText = "SELECT * FROM M_STAFF";
                    command.Connection = connection;

                    // SQLを実行
                    var odda = new OleDbDataAdapter();
                    odda.SelectCommand = command;
                    odda.Fill(dt);

                    // 結果処理
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        Earnings_Staff_Name.Items.Add(dt.Rows[i]["STAFF_NAME"].ToString());

                    }
                }
                finally
                {
                    // 接続を解除します。
                    connection.Close();
                }
            }
        }
        private void StaffNameCombobox_SelectionChange(object sender, EventArgs e)
        {

            ComboBox cb = (ComboBox)sender;
            string staffName = cb.Text;


            using (var connection = new OleDbConnection())
            using (var command = new OleDbCommand())
            {
                var dt = new DataTable();

                // Accessファイルは、実行ファイルと同じフォルダに置いてあることを前提にしています。
                // 変更する場合、以下を修正してください。
                var dbPath = System.AppDomain.CurrentDomain.BaseDirectory + DbPFile;
                // 接続文字列
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath;

                try
                {
                    // 接続します。
                    connection.Open();

                    // SQL文を設定
                    command.CommandText = "SELECT * FROM M_STAFF WHERE STAFF_NAME=@staffName";
                    command.Parameters.AddWithValue("@staffName", staffName);
                    command.Connection = connection;

                    // SQLを実行
                    var odda = new OleDbDataAdapter();
                    odda.SelectCommand = command;
                    odda.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string staffId = dt.Rows[i]["STAFF_ID"].ToString();
                        T_EarningsDataGridview.Rows[SelectedRowIndex].Cells["Earnings_Staff_ID"].Value = staffId;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
                finally
                {
                    // 接続を解除します。
                    connection.Close();
                }
            }
        }
        
        // Exit Application
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Save The data in Csv File
        private void SaveToCSV_Click(object sender, EventArgs e)
        {
            if (T_EarningsDataGridview.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It Wasn't Possible to write the Data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        using (var connection = new OleDbConnection())
                        using (var command = new OleDbCommand())
                        {
                            var dt = new DataTable();

                            // Accessファイルは、実行ファイルと同じフォルダに置いてあることを前提にしています。
                            // 変更する場合、以下を修正してください。
                            var dbPath = System.AppDomain.CurrentDomain.BaseDirectory + DbPFile;
                            // 接続文字列
                            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath;

                            try
                            {
                                // 接続します。
                                connection.Open();

                                // SQL文を設定
                                command.CommandText = "SELECT * FROM T_EARNINGS WHERE DELETED = @DELETED";
                                command.Parameters.Add(new OleDbParameter("@DELETED", OleDbType.Boolean)).Value = false;
                                command.Connection = connection;

                                // SQLを実行
                                var odda = new OleDbDataAdapter();
                                odda.SelectCommand = command;
                                odda.Fill(dt);

                                int RowCount = dt.Rows.Count;
                                int ColumnCount = dt.Columns.Count;

                                string[] outPutCsv = new string[RowCount + 1];
                                outPutCsv[0] = "";

                                for (int i = 0; i < ColumnCount; i++)
                                {
                                    outPutCsv[0] += dt.Columns[i].Caption;
                                    if (i < ColumnCount - 1)
                                    {
                                        outPutCsv[0] += ", ";
                                    }
                                }

                                for (int i = 0; i < RowCount; i++)
                                {
                                    outPutCsv[i + 1] = "";
                                    for (int j = 0; j < ColumnCount; j++)
                                    {
                                        string s = dt.Rows[i][j].ToString();
                                        if (j == 0)
                                        {
                                            s = (i + 1).ToString();
                                        }
                                        if (j == 5 || j == 6 || j == 11)
                                        {
                                            if (!string.IsNullOrWhiteSpace(s))
                                            {
                                                DateTime date = Convert.ToDateTime(s);
                                                s = date.ToString("yyyy/M/d");
                                            }
                                        }
                                        if (s.IndexOf(',') >= 0)
                                        {
                                            s = "\"" + s + "\"";
                                        }
                                        outPutCsv[i + 1] += s;
                                        if (j < ColumnCount - 1)
                                        {
                                            outPutCsv[i + 1] += ", ";
                                        }
                                        
                                    }
                                }
                                File.WriteAllLines(sfd.FileName, outPutCsv, Encoding.UTF8);
                                MessageBox.Show("Data Expored Successfully !!!", "Info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error :" + ex.Message);
                            }

                            finally
                            {
                                // 接続を解除します。
                                connection.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Record to Export!!!", "info");
                    }
                }
            }
        }

        //Add the Row in DatagridView
        private void AddRow_Btn_Click(object sender, EventArgs e)
        {
            addNewRowNumber = T_EarningsDataGridview.Rows.Count;

            DataTable dt = T_EarningsDataGridview.DataSource as DataTable;

            //新しい行を追加」
            DataRow row = dt.NewRow();

            //行を　データテーブルに入力
            dt.Rows.Add(row);

            T_EarningsDataGridview.Rows[addNewRowNumber].Cells[0].Value = addNewRowNumber + 1;
            int LastRow = T_EarningsDataGridview.Rows.GetLastRow(DataGridViewElementStates.Visible);
            T_EarningsDataGridview.ClearSelection();

            //最後行　を選択
            T_EarningsDataGridview.Rows[LastRow].Selected = true;
            T_EarningsDataGridview.FirstDisplayedScrollingRowIndex = T_EarningsDataGridview.RowCount - 1;
        }

        //Save the updated Data
        private void Save_Btn_Click(object sender, EventArgs e)
        {
            using (var connection = new OleDbConnection())
            using (var command = new OleDbCommand())
            {
                var dt = new DataTable();

                // Accessファイルは、実行ファイルと同じフォルダに置いてあることを前提にしています。
                // 変更する場合、以下を修正してください。
                var dbPath = System.AppDomain.CurrentDomain.BaseDirectory + DbPFile;
                // 接続文字列
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath;

                try
                {
                    // 接続します。
                    connection.Open();
                    command.Connection = connection;


                    // UPDATE //////////////////////////////////////////////////////////////////

                    // SQL文を設定
                    command.CommandText = "UPDATE T_EARNINGS "
                        + "SET STAFF_ID = @STAFF_ID"
                        + ", STAFF_NAME = @STAFF_NAME"
                        + ", CUSTOMER_ID = @CUSTOMER_ID"
                        + ", CUSTOMER_NAME = @CUSTOMER_NAME"
                        + ", CONTRACT_DATE = @CONTRACT_DATE"
                        + ", PAYMENT_DATE = @PAYMENT_DATE"
                        + ", CONTENT = @CONTENT"
                        + ", EARNINGS = @EARNINGS"
                        + ", COMPLETED = @COMPLETED"
                        + ", DELETED = @DELETED"
                        + ", UPDATE_DATE = NOW()"
                        + " WHERE "
                        + "T_EARNINGS_PK = @T_EARNINGS_PK";

                   
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        // PKが設定されていない行は、新規追加なので対象外
                        if (string.IsNullOrEmpty(T_EarningsDataGridview.Rows[i].Cells["Earnings_PK"].Value.ToString()))
                        {
                            continue;
                        }

                        command.Parameters.Clear();
                        command.Parameters.Add(new OleDbParameter("@STAFF_ID", OleDbType.BigInt)).Value = T_EarningsDataGridview.Rows[i].Cells["Earnings_Staff_ID"].Value;
                        command.Parameters.Add(new OleDbParameter("@STAFF_NAME", OleDbType.VarChar)).Value = T_EarningsDataGridview.Rows[i].Cells["Earnings_Staff_Name"].Value;
                        command.Parameters.Add(new OleDbParameter("@CUSTOMER_ID", OleDbType.BigInt)).Value = T_EarningsDataGridview.Rows[i].Cells["Earnings_Customer_ID"].Value;
                        command.Parameters.Add(new OleDbParameter("@CUSTOMER_NAME", OleDbType.VarChar)).Value = T_EarningsDataGridview.Rows[i].Cells["Earnings_Customer_Name"].Value;
                        command.Parameters.Add(new OleDbParameter("@CONTRACT_DATE", OleDbType.Date)).Value = ConvertStrToDate(T_EarningsDataGridview.Rows[i].Cells["Earnings_Contract_Date"].Value);
                        command.Parameters.Add(new OleDbParameter("@PAYMENT_DATE", OleDbType.Date)).Value = ConvertStrToDate(T_EarningsDataGridview.Rows[i].Cells["Earnings_Payment_Date"].Value);
                        command.Parameters.Add(new OleDbParameter("@CONTENT", OleDbType.VarChar)).Value = T_EarningsDataGridview.Rows[i].Cells["Earnings_Content"].Value;
                        command.Parameters.Add(new OleDbParameter("@EARNINGS", OleDbType.BigInt)).Value = T_EarningsDataGridview.Rows[i].Cells["Earnings_earnings"].Value;
                        command.Parameters.Add(new OleDbParameter("@COMPLETED", OleDbType.Boolean)).Value = T_EarningsDataGridview.Rows[i].Cells["Earnings_Completed"].Value;
                        command.Parameters.Add(new OleDbParameter("@DELETED", OleDbType.Boolean)).Value = T_EarningsDataGridview.Rows[i].Cells["Earnings_Deleted"].Value.ToString().ToLower();
                        command.Parameters.Add(new OleDbParameter("@T_EARNINGS_PK", OleDbType.BigInt)).Value = T_EarningsDataGridview.Rows[i].Cells["Earnings_PK"].Value;

                        // SQLを実行
                        command.ExecuteNonQuery();
                    }


                    // INSERT //////////////////////////////////////////////////////////////////

                    // SQL文を設定
                    command.CommandText = "INSERT INTO T_EARNINGS ("
                        + "  STAFF_ID"
                        + ", STAFF_NAME"
                        + ", CUSTOMER_ID"
                        + ", CUSTOMER_NAME"
                        + ", CONTRACT_DATE"
                        + ", PAYMENT_DATE"
                        + ", CONTENT"
                        + ", EARNINGS"
                        + ", COMPLETED"
                        + ", DELETED"
                        + ", UPDATE_DATE"
                        + ") VALUES ("
                        + "  @STAFF_ID"
                        + ", @STAFF_NAME"
                        + ", @CUSTOMER_ID"
                        + ", @CUSTOMER_NAME"
                        + ", @CONTRACT_DATE"
                        + ", @PAYMENT_DATE"
                        + ", @CONTENT"
                        + ", @EARNINGS"
                        + ", @COMPLETED"
                        + ", 0"
                        + ", NOW()"
                        + ")";

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        // PKが設定されている行は保存済み行、削除フラグが設定されている行は新規追加されない
                        if (!string.IsNullOrEmpty(T_EarningsDataGridview.Rows[i].Cells["Earnings_PK"].Value.ToString()) || T_EarningsDataGridview.Rows[i].Cells["Earnings_Deleted"].Value.ToString().ToLower() == "false")
                        {
                            continue;
                        }

                        command.Parameters.Clear();
                        command.Parameters.Add(new OleDbParameter("@STAFF_ID", OleDbType.BigInt)).Value = T_EarningsDataGridview.Rows[i].Cells["Earnings_Staff_ID"].Value;
                        command.Parameters.Add(new OleDbParameter("@STAFF_NAME", OleDbType.VarChar)).Value = T_EarningsDataGridview.Rows[i].Cells["Earnings_Staff_Name"].Value;
                        command.Parameters.Add(new OleDbParameter("@CUSTOMER_ID", OleDbType.BigInt)).Value = T_EarningsDataGridview.Rows[i].Cells["Earnings_Customer_ID"].Value;
                        command.Parameters.Add(new OleDbParameter("@CUSTOMER_NAME", OleDbType.VarChar)).Value = T_EarningsDataGridview.Rows[i].Cells["Earnings_Customer_Name"].Value;
                        command.Parameters.Add(new OleDbParameter("@CONTRACT_DATE", OleDbType.Date)).Value = ConvertStrToDate(T_EarningsDataGridview.Rows[i].Cells["Earnings_Contract_Date"].Value);
                        command.Parameters.Add(new OleDbParameter("@PAYMENT_DATE", OleDbType.Date)).Value = ConvertStrToDate(T_EarningsDataGridview.Rows[i].Cells["Earnings_Payment_Date"].Value);
                        command.Parameters.Add(new OleDbParameter("@CONTENT", OleDbType.VarChar)).Value = T_EarningsDataGridview.Rows[i].Cells["Earnings_Content"].Value;
                        command.Parameters.Add(new OleDbParameter("@EARNINGS", OleDbType.BigInt)).Value = T_EarningsDataGridview.Rows[i].Cells["Earnings_earnings"].Value;
                        command.Parameters.Add(new OleDbParameter("@COMPLETED", OleDbType.Boolean)).Value = T_EarningsDataGridview.Rows[i].Cells["Earnings_Completed"].Value;

                        // SQLを実行
                        command.ExecuteNonQuery();
                    }


                    MessageBox.Show("Data Saved");
                    
                }
                finally
                {
                    // 接続を解除します。
                    connection.Close();
                }
            }
        }
        private object ConvertStrToDate(object obj)
        {
            // 文字列を日付に変換する

            DateTime dt;
            if (DateTime.TryParse(obj.ToString(), out dt))
            {
                return dt;
            }
            else
            {
                // 文字列を日付に変換できない場合は、データベース用のnullを返す
                return DBNull.Value;
            }
        }

        private List<Class1> GetDataGridViewData()
        {
            List<Class1> TEarningsList = new List<Class1>();
            TEarningsList.Clear();
            DataTable dt = dataTable;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int EarningAmount;
                int.TryParse(dt.Rows[i]["EARNINGS"].ToString(), out EarningAmount);
                string CompletedValue = dt.Rows[i]["COMPLETED"].ToString();
                string ContractDate;
                if (!string.IsNullOrWhiteSpace(dt.Rows[i]["CONTRACT_DATE"].ToString()))
                {
                    DateTime contractdate = Convert.ToDateTime(dt.Rows[i]["CONTRACT_DATE"].ToString());
                    ContractDate = contractdate.ToString("yyyy/MM/dd");
                }
                else
                {
                    ContractDate = string.Empty;
                }
                string PaymentDate;
                if (!string.IsNullOrWhiteSpace(dt.Rows[i]["PAYMENT_DATE"].ToString()))
                {
                    DateTime paymentdate = Convert.ToDateTime(dt.Rows[i]["PAYMENT_DATE"].ToString());
                    PaymentDate = paymentdate.ToString("yyyy/MM/dd");
                }
                else
                {
                    PaymentDate = string.Empty;
                }
                Class1 TEarnings = new Class1
                {
                    No = (i + 1).ToString(),
                    Earnings_Staff_ID = dt.Rows[i]["STAFF_ID"].ToString(),
                    Earnings_Staff_Name = dt.Rows[i]["STAFF_NAME"].ToString(),
                    Earnings_Customer_ID = dt.Rows[i]["CUSTOMER_ID"].ToString(),
                    Earnings_Customer_Name = dt.Rows[i]["CUSTOMER_NAME"].ToString(),
                    Earnings_Content = dt.Rows[i]["CONTENT"].ToString(),
                    Earnings_earnings = EarningAmount,
                    Earnings_Completed = Iscompleted(CompletedValue),
                    Earnings_Contract_Date = ContractDate,
                    Earnings_Payment_Date = PaymentDate
                };
                TEarningsList.Add(TEarnings);
            }
            return TEarningsList;
        }
        private string Iscompleted(string boolValue)
        {
            if (boolValue == "True")
            {
                return "○";
            }
            else
            {
                return string.Empty;
            }
        }
        private void Get_Table_Data()
        {
            using (var connection = new OleDbConnection())
            using (var command = new OleDbCommand())
            {
                var dt = new DataTable();

                // Accessファイルは、実行ファイルと同じフォルダに置いてあることを前提にしています。
                // 変更する場合、以下を修正してください。
                var dbPath = System.AppDomain.CurrentDomain.BaseDirectory + DbPFile;
                // 接続文字列
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath;

                try
                {
                    // 接続します。
                    connection.Open();

                    // SQL文を設定
                    command.CommandText = "SELECT * FROM T_EARNINGS WHERE DELETED = @DELETED ORDER BY T_EARNINGS_PK";
                    command.Parameters.Add(new OleDbParameter("@DELETED", OleDbType.Boolean)).Value = false;
                    command.Connection = connection;

                    // SQLを実行
                    var odda = new OleDbDataAdapter();
                    odda.SelectCommand = command;

                    //DataSet dataSet = new DataSet();
                    odda.Fill(dt);

                    dataTable = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
                finally
                {
                    // 接続を解除します。
                    connection.Close();
                }
            }
        }
        private void Export_To_Pdf()
        {
            try
            {
                string deviceInfo = "";
                string[] streamIds;
                Warning[] warnings;
                string mimeType = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;

                ReportViewer viewer = new ReportViewer();
                viewer.ProcessingMode = ProcessingMode.Local;
                viewer.LocalReport.ReportPath = "Report1.rdlc";
                viewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", GetDataGridViewData()));
                viewer.RefreshReport();
                var bytes = viewer.LocalReport.Render("PDF", deviceInfo, out mimeType, out encoding, out extension, out streamIds, out warnings);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Pdf Files|*.pdf";
                saveFileDialog.FileName = ".pdf";
                saveFileDialog.ShowDialog();

                FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.ReadWrite);
                stream.Write(bytes, 0, bytes.Length);
                stream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void T_EarningsDataGridview_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            SelectedRowIndex = ((DataGridView)sender).CurrentRow.Index;

            if (((DataGridView)sender).CurrentCell.ColumnIndex == 4) //Assuming 0 is the index of the ComboBox Column you want to show
            {
                ComboBox staffNameCombobox = e.Control as ComboBox;
                if (staffNameCombobox != null)
                {
                    staffNameCombobox.SelectionChangeCommitted -= StaffNameCombobox_SelectionChange;
                    // now attach the event handler
                    staffNameCombobox.SelectionChangeCommitted += StaffNameCombobox_SelectionChange;
                }

            }

            if (((DataGridView)sender).CurrentCell.ColumnIndex == 6)
            {
                ComboBox customerNameCombobox = e.Control as ComboBox;
                if (customerNameCombobox != null)
                {
                    customerNameCombobox.SelectionChangeCommitted -= CustomerNameCombobox_SelectionChange;
                    // now attach the event handler
                    customerNameCombobox.SelectionChangeCommitted += CustomerNameCombobox_SelectionChange;

                }
            }
        }

        private void Btn_Switch_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 form = new Form2();
            form.Show();
        }

        private void T_EarningsDataGridview_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int editRowIndex = e.RowIndex;

            //編集した行を「list<int>」に追加する
            if (editRowIndex < databaseTotalRows)
            {
                bool AlreadyHave = EditRows.Contains(editRowIndex);
                if (!AlreadyHave)
                {
                    //編集した行を[List<int>]にあるかどうか、確認
                    EditRows.Add(editRowIndex);
                }
            }

            //「staffId」に従って、staffname　を　「staffnameColumn」カラムに自動的に入力
            if (e.ColumnIndex == 3)
            {
                //選択したstaffId
                string staffId = T_EarningsDataGridview.Rows[editRowIndex].Cells["Earnings_Staff_ID"].Value.ToString();
                if (!string.IsNullOrWhiteSpace(staffId))
                {
                    using (var connection = new OleDbConnection())
                    using (var command = new OleDbCommand())
                    {
                        var dt = new DataTable();

                        // Accessファイルは、実行ファイルと同じフォルダに置いてあることを前提にしています。
                        // 変更する場合、以下を修正してください。
                        var dbPath = System.AppDomain.CurrentDomain.BaseDirectory + DbPFile;

                        // 接続文字列
                        connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath;

                        try
                        {
                            // 接続します。
                            connection.Open();

                            // SQL文を設定
                            command.CommandText = "SELECT * FROM M_STAFF WHERE STAFF_ID=@staffId";
                            command.Parameters.AddWithValue("@staffId", staffId);
                            command.Connection = connection;

                            // SQLを実行
                            var odda = new OleDbDataAdapter();
                            odda.SelectCommand = command;
                            odda.Fill(dt);
                            // 結果処理
                            string staffName = string.Empty;
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                //入力した　staffId　の　staffName　をもらう
                                staffName = dt.Rows[i]["STAFF_NAME"].ToString();

                                //もらった　staffName　値　を　選択した行の「staffNameColumn」カラムに入力する　
                                T_EarningsDataGridview.Rows[editRowIndex].Cells["Earnings_Staff_Name"].Value = staffName;

                            }
                            //if insert wrong staffId, staffName will be Empty;
                            if (string.IsNullOrEmpty(staffName))
                            {
                                T_EarningsDataGridview.Rows[editRowIndex].Cells["Earnings_Staff_Name"].Value = DBNull.Value;
                                throw new Exception("入力した　’従業員ID’ の値を間違えました ");
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("エラー　" + ex.Message);
                        }
                        finally
                        {
                            // 接続を解除します。
                            connection.Close();
                        }
                    }
                }


            }


            //「customerId」に従って、customerName　を　「customerNameColumn」カラムに自動的に入力する。
            if (e.ColumnIndex == 5)
            {
                string customerId = T_EarningsDataGridview.Rows[editRowIndex].Cells["Earnings_Customer_ID"].Value.ToString();
                if (!string.IsNullOrWhiteSpace(customerId))
                {
                    using (var connection = new OleDbConnection())
                    using (var command = new OleDbCommand())
                    {
                        var dt = new DataTable();

                        // Accessファイルは、実行ファイルと同じフォルダに置いてあることを前提にしています。
                        // 変更する場合、以下を修正してください。
                        var dbPath = System.AppDomain.CurrentDomain.BaseDirectory + DbPFile;

                        // 接続文字列
                        connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath;

                        try
                        {
                            // 接続します。
                            connection.Open();

                            // SQL文を設定
                            command.CommandText = "SELECT * FROM M_CUSTOMER WHERE CUSTOMER_ID=@customerId";
                            command.Parameters.AddWithValue("@customerId", customerId);
                            command.Connection = connection;

                            // SQLを実行
                            var odda = new OleDbDataAdapter();
                            odda.SelectCommand = command;
                            odda.Fill(dt);
                            // 結果処理
                            string customerName = string.Empty;

                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                //入力した　customerID　の　customerName　をもらう
                                customerName = dt.Rows[i]["CUSTOMER_NAME"].ToString();
                                //もらった　customerName　値　を　選択した行の「customerNameColumn」カラムに入力する　
                                T_EarningsDataGridview.Rows[editRowIndex].Cells["Earnings_Customer_Name"].Value = customerName;
                            }
                            //if insert wrong customerId, customerName will be Empty;
                            if (string.IsNullOrWhiteSpace(customerName))
                            {
                                T_EarningsDataGridview.Rows[editRowIndex].Cells["Earnings_Customer_Name"].Value = "";
                                throw new Exception("入力した　’顧客ID’の値を間違えました ");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("エラー　" + ex.Message);
                        }
                        finally
                        {
                            // 接続を解除します。
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void ClkToPDF_Click(object sender, EventArgs e)
        {
            Get_Table_Data();
            if (dataTable.Rows.Count > 0)
            {
                Export_To_Pdf();
                MessageBox.Show("Data Expored Successfully !!!", "Info");
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
    }
}

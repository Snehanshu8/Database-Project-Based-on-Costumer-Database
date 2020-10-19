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
    public partial class Form2 : Form
    {
        //Access File Connection
        private const string DbPFile = "Test1.mdb";
        int addNewRowNumber;
        DataTable dataTable;
        bool isDtpempty = false;
        public Form2()
        {
            InitializeComponent();
            FillCombo_StaffName();
            FillCombo_CustomerName();
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
            //列スタイルの設定
            this.T_EarningsDataGridview.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.T_EarningsDataGridview.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        void FillCombo_StaffName()
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
                        comboBox1.Items.Add(dt.Rows[i]["STAFF_NAME"].ToString());
                    }
                }
                finally
                {
                    // 接続を解除します。
                    connection.Close();
                }
            }
        }
        void FillCombo_CustomerName()
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

                        comboBox2.Items.Add(dt.Rows[i]["CUSTOMER_NAME"].ToString());

                    }
                }
                finally
                {
                    // 接続を解除します。
                    connection.Close();
                }
            }
        }
        private void Btn_Switch_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            New_Database new_Database = new New_Database();
            new_Database.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
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

                    DataSet dataSet = new DataSet();
                    odda.Fill(dt);
                    T_EarningsDataGridview.AutoGenerateColumns = false;
                    T_EarningsDataGridview.DataSource = dt;

                    // 結果処理
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
                        if (!string.IsNullOrWhiteSpace(dt.Rows[i]["CONTRACT_DATE"].ToString()))
                        {
                            DateTime ContractDate = (DateTime)dt.Rows[i]["CONTRACT_DATE"];
                            string ContractDateString = ContractDate.ToString("yyyy/MM/dd");
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

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
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

        private void T_EarningsDataGridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = T_EarningsDataGridview.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                //checkBox2.Checked = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[3].Value.ToString();
                comboBox1.Text = row.Cells[4].Value.ToString();
                textBox3.Text = row.Cells[5].Value.ToString();
                comboBox2.Text = row.Cells[6].Value.ToString();
                textBox4.Text = row.Cells[7].Value.ToString();
                textBox5.Text = row.Cells[8].Value.ToString();
                
                if (row.Cells[10].Value != null)
                {
                    dateTimePicker1.CustomFormat = "yyyy/MM/dd";
                    dateTimePicker1.Text = row.Cells[10].Value.ToString();

                }
                else
                {
                    isDtpempty = true;
                    dateTimePicker1.CustomFormat = " ";
                    isDtpempty = false;
                }
                
                if (row.Cells[11].Value != null)
                {
                    dateTimePicker2.CustomFormat = "yyyy/MM/dd";
                    dateTimePicker2.Text = row.Cells[11].Value.ToString();

                }
                else
                {
                    isDtpempty = true;
                    dateTimePicker2.CustomFormat = " ";
                    isDtpempty = false;
                }
            }
        }

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

    }
}

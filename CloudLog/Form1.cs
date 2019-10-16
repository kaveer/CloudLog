using System;
using Google.Cloud.Storage.V1;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Logging.V2;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Data.SqlClient;
using ProtoBuf;

namespace CloudLog
{
    public partial class Form1 : Form
    {
        int addedCount;

        string connectionString;
        string projectId;
        string resourceName;
        string filter;
        string orderBy;

        public Form1()
        {
            string value = Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS");

            InitializeComponent();
            this.ddgDefault.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ddgDefault_cellclick);
            txtInsertId.ReadOnly = true;
            txtLogId.ReadOnly = true;
            txtLogName.ReadOnly = true;
            txtLogTimstamp.ReadOnly = true;
            txtProtoBType.ReadOnly = true;
            txtProtoBValue.ReadOnly = true;
            txtRecieveDate.ReadOnly = true;
            txtSeverity.ReadOnly = true;

            Configuration();
            RetrieveCloudLog();
            LoadGridData();

        }

        private void ddgDefault_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            int logId = Convert.ToInt32(ddgDefault.SelectedRows[0].Cells[1].Value);
            if (logId > 0)
            {
                RetrieveLogById(logId);
                RetrieveResourceById(logId);
            }

        }

        private void RetrieveResourceById(int logId)
        {
            SqlConnection connection = null;
            DataTable dataTable = new DataTable();

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("LogsResourceRetrieve", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.Add(new SqlParameter("@logId", logId));

                dataTable.Load(command.ExecuteReader());
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            if (dataTable != null || dataTable.Rows.Count > 0)
            {
                ddgResource.DataSource = dataTable;
            }
        }

        private void RetrieveLogById(int logId)
        {
            SqlConnection connection = null;
            DataTable dataTable = new DataTable();

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("LogsDetailsRetrieve", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.Add(new SqlParameter("@logId", logId));

                dataTable.Load(command.ExecuteReader());
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            if (dataTable != null || dataTable.Rows.Count > 0)
            {
                txtInsertId.Text = dataTable.Rows[0][1].ToString();
                txtLogId.Text = dataTable.Rows[0][0].ToString();
                txtLogName.Text = dataTable.Rows[0][2].ToString();
                txtLogTimstamp.Text = dataTable.Rows[0][7].ToString();
                txtProtoBType.Text = dataTable.Rows[0][3].ToString();
                txtProtoBValue.Text = dataTable.Rows[0][4].ToString();
                txtRecieveDate.Text = dataTable.Rows[0][5].ToString();
                txtSeverity.Text = dataTable.Rows[0][6].ToString();
            }
        }

        private void LoadGridData()
        {
            SqlConnection connection = null;
            DataTable dataTable = new DataTable();

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("LogsRetrieve", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                dataTable.Load(command.ExecuteReader());
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            if (dataTable != null || dataTable.Rows.Count > 0)
            {
                ddgDefault.DataSource = dataTable;
                AddButtonToGrid();
            }
        }

        private void AddButtonToGrid()
        {
            this.ddgDefault.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ddgDefault.MultiSelect = false;
            var buttonCol = new DataGridViewButtonColumn(); // The button to display a particular cell value when clicks//
            buttonCol.Name = "ButtonColumnName";
            buttonCol.HeaderText = "Show";
            buttonCol.Text = "View";
            buttonCol.UseColumnTextForButtonValue = true;
            ddgDefault.Columns.Add(buttonCol);
        }

        private void RetrieveCloudLog()
        {
            List<LogViewModel> logs = new List<LogViewModel>();
            Dictionary<string, string> resources = new Dictionary<string, string>();


            List<string> resource = new List<string>();
            resource.Add(resourceName);

            IEnumerable<string> resourceNames = resource;
            var client = LoggingServiceV2Client.Create();

            var logEntries = client.ListLogEntries(resourceNames, filter, orderBy);
            int count = logEntries.Count();

            if (count > 0)
            {
                foreach (var item in logEntries)
                {
                    try
                    {
                        ////convert protocol buffer method 1
                        //ProtoPayload serlizedPerson;
                        //var by = item.ProtoPayload.Value.ToArray();
                        //using (var stream = new MemoryStream(by))
                        //{
                        //    serlizedPerson = Serializer.Deserialize<ProtoPayload>(stream);
                        //}

                        ////convert protocol buffer method 2
                        //if (File.Exists("test.bin"))
                        //{
                        //    File.Delete("test.bin");
                        //}

                        //using (var fs = File.Create("test.bin"))
                        //{
                        //    Serializer.Serialize(fs, item.ProtoPayload.Value);
                        //}

                        //using (var fs = File.OpenRead("test.bin"))
                        //{
                        //    serlizedPerson = Serializer.Deserialize<ProtoPayload>(fs);
                        //    // do something with person
                        //}

                        LogViewModel log = new LogViewModel
                        {
                            InsertId = item.InsertId,
                            LogName = item.LogName,
                            ProtoPayloadTypeUrl = item.ProtoPayload.TypeUrl,
                            ProtoPayloadValue = item.ProtoPayload.Value.ToBase64(),
                            RecieveTimestamp = item.ReceiveTimestamp,
                            Resource = resources,
                            Severity = item.Severity.ToString(),
                            LogTimestamp = item.Timestamp
                        };

                        foreach (var resourceItem in item.Resource.Labels)
                        {
                            try
                            {
                                resources.Add(resourceItem.Key, resourceItem.Value);
                            }
                            catch (Exception)
                            {

                            }

                        }

                        logs.Add(log);

                        if (logs.Count() == 10)
                        {
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                if (logs.Count() > 0)
                {
                    MessageBox.Show(string.Format("{0} logs will be processed to the system", logs.Count()));
                    SaveToDatabase(logs);
                }
            }
        }

        private void Configuration()
        {
            connectionString = @"Data Source=DESKTOP-3KHTJ6N\SQLEXPRESS;Initial Catalog=CloudLog;Integrated Security=True";
            projectId = "resolute-world-253406";
            resourceName = string.Format("projects/{0}", projectId);
            filter = "resource.type = \"gcs_bucket\"";
            orderBy = "timestamp desc";
        }

        private void SaveToDatabase(List<LogViewModel> logs)
        {
            foreach (var item in logs)
            {
                try
                {
                    LogViewModel log = SaveLogs(item);
                    if (log.IsNew)
                    {
                        item.LogId = log.LogId;
                        SaveLogDetails(item);
                        SaveLogResources(item);
                    }
                    if (log.LogId > 0 && log.IsNew)
                    {
                        addedCount++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("error while saving log id {0}", item.InsertId));
                }
            }

            MessageBox.Show(string.Format("{0} logs added", addedCount));
        }

        private void SaveLogResources(LogViewModel item)
        {
            if (item.Resource != null || item.Resource?.Count > 0)
            {
                foreach (var resource in item.Resource)
                {
                    SqlConnection connection = null;
                    DataTable dataTable = new DataTable();

                    try
                    {
                        connection = new SqlConnection(connectionString);
                        connection.Open();

                        SqlCommand command = new SqlCommand("SaveLogResource", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        command.Parameters.Add(new SqlParameter("@logId", item.LogId));
                        command.Parameters.Add(new SqlParameter("@rkey", resource.Key.Trim()));
                        command.Parameters.Add(new SqlParameter("@rvalue", resource.Value.Trim()));

                        dataTable.Load(command.ExecuteReader());
                    }
                    finally
                    {
                        if (connection != null)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void SaveLogDetails(LogViewModel item)
        {
            SqlConnection connection = null;
            DataTable dataTable = new DataTable();

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("SaveLogDetails", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new SqlParameter("@logId", item.LogId));
                command.Parameters.Add(new SqlParameter("@logName", item.LogName.Trim()));
                command.Parameters.Add(new SqlParameter("@ptypeUrl", item.ProtoPayloadTypeUrl.Trim()));
                command.Parameters.Add(new SqlParameter("@pvalue", item.ProtoPayloadValue.Trim()));
                command.Parameters.Add(new SqlParameter("@recieve", item.RecieveTimestamp.ToDateTime()));
                command.Parameters.Add(new SqlParameter("@severity", item.Severity.Trim()));
                command.Parameters.Add(new SqlParameter("@logTimestamp", item.LogTimestamp.ToDateTime()));

                dataTable.Load(command.ExecuteReader());
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        private LogViewModel SaveLogs(LogViewModel item)
        {
            LogViewModel result = new LogViewModel();

            SqlConnection connection = null;
            DataTable dataTable = new DataTable();

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("SaveLog", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.Add(new SqlParameter("@insertId", item.InsertId.Trim()));

                dataTable.Load(command.ExecuteReader());
                if (dataTable != null || dataTable.Rows.Count > 0)
                {
                    result.LogId = Convert.ToInt32(dataTable.Rows[0][0]);
                    result.InsertId = dataTable.Rows[0][1].ToString();
                    result.IsNew = Convert.ToBoolean(dataTable.Rows[0][2]);
                }
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return result;
        }

        public static T ProtoDeserialize<T>(byte[] data) where T : class
        {
            if (null == data) return null;

            try
            {
                using (var stream = new MemoryStream(data))
                {
                    return Serializer.Deserialize<T>(stream);
                }
            }
            catch
            {
                // Log error
                throw;
            }
        }

        private void converted(byte[] protoPayloadValue)
        {
            byte[] bytes = protoPayloadValue; // A byte array contains non-ASCII (or non-readable) characters

            string s1 = Encoding.UTF8.GetString(bytes); // ���
            byte[] decBytes1 = Encoding.UTF8.GetBytes(s1);  // decBytes1.Length == 10 !!
                                                            // decBytes1 not same as bytes
                                                            // Using UTF-8 or other Encoding object will get similar results

            string s2 = BitConverter.ToString(bytes);   // 82-C8-EA-17
            String[] tempAry = s2.Split('-');
            byte[] decBytes2 = new byte[tempAry.Length];
            for (int i = 0; i < tempAry.Length; i++)
                decBytes2[i] = Convert.ToByte(tempAry[i], 16);
            // decBytes2 same as bytes

            string s3 = Convert.ToBase64String(bytes);  // gsjqFw==
            byte[] decByte3 = Convert.FromBase64String(s3);
            // decByte3 same as bytes

            byte[] data = Convert.FromBase64String(s3);
            string decodedString = Encoding.UTF8.GetString(data);

            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            var tg = encoding.GetString(protoPayloadValue);

            //string s4 = HttpServerUtility.UrlTokenEncode(bytes);    // gsjqFw2
            //byte[] decBytes4 = HttpServerUtility.UrlTokenDecode(s4);
            // decBytes4 same as bytes
        }

        public object AuthImplicit(string projectId)
        {
            // If you don't specify credentials when constructing the client, the
            // client library will look for credentials in the environment.

            var credential = GoogleCredential.FromFile(@"C:\Users\kaveer\Desktop\My Project 52129-05afa0d08744.json");
            var storage = StorageClient.Create(credential);

            // Make an authenticated API request.
            var buckets = storage.ListBuckets(projectId);
            foreach (var bucket in buckets)
            {
                Console.WriteLine(bucket.Name);
            }
            return null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System will be updated by google cloud log");

            RetrieveCloudLog();
            LoadGridData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }
    }


}

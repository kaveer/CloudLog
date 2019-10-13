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

namespace CloudLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string value = Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS");

            InitializeComponent();
            string projectId = "resolute-world-253406";
            string resourceName = string.Format("projects/{0}", projectId);
            string filter = "resource.type = \"gcs_bucket\"";
            string orderBy = "timestamp desc";

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
                        LogViewModel log = new LogViewModel();
                        log.InsertId = item.InsertId;
                        log.LogName = item.LogName;
                        log.ProtoPayloadTypeUrl = item.ProtoPayload.TypeUrl;
                        log.ProtoPayloadValue = item.ProtoPayload.Value.ToBase64();
                        log.RecieveTimestamp = item.ReceiveTimestamp;
                        log.Resource = resources;
                        log.Severity = item.Severity.ToString();
                        log.LogTimestamp = item.Timestamp;

                        foreach (var resourceItem in item.Resource.Labels)
                        {
                            try
                            {
                                resources = new Dictionary<string, string>
                                {
                                    { resourceItem.Key, resourceItem.Value }
                                };
                            }
                            catch (Exception)
                            {

                            }

                        }

                        logs.Add(log);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                if (logs.Count() > 0)
                {
                    MessageBox.Show(string.Format("{0} logs will be updated to the system", logs.Count()));

                    SaveToDatabase(logs);
                }
            }
        }

        private void SaveToDatabase(List<LogViewModel> logs)
        {
            foreach (var item in logs)
            {
                try
                {
                    SqlConnection connection = null;
                    SqlDataReader dataReader = null;
                    DataTable dataTable = new DataTable();

                    try
                    {
                        connection = new SqlConnection("Server=(local);DataBase=Northwind;Integrated Security=SSPI");
                        connection.Open();

                        SqlCommand command = new SqlCommand("CustOrderHist", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@CustomerID", "data here"));

                        dataTable.Load(command.ExecuteReader());
                        dataReader = command.ExecuteReader();
                       
                        while (dataReader.Read())
                        {
                            Console.WriteLine(
                                "Product: {0,-35} Total: {1,2}",
                                dataReader["ProductName"],
                                dataReader["Total"]);
                            
                        }
                    }
                    finally
                    {
                        if (connection != null)
                        {
                            connection.Close();
                        }
                        if (dataReader != null)
                        {
                            dataReader.Close();
                        }
                    }
                }
                catch (Exception)
                {

                }
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
    }
}

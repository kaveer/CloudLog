using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudLog
{
    public partial class Search : Form
    {
        string connectionString;
        bool reciveDateChange = false;
        bool logDateChange = false;

        public Search()
        {
            InitializeComponent();
            Configuration();
            dpRecieveFrom.ValueChanged += new System.EventHandler(dpRecieve_ValueChanged);
            dpRecieveTo.ValueChanged += new System.EventHandler(dpRecieve_ValueChanged);

            dpLogTimestampFrom.ValueChanged += new System.EventHandler(dplogTimestamp_ValueChanged);
            dpLogTimestampTo.ValueChanged += new System.EventHandler(dplogTimestamp_ValueChanged);

        }

        private void Configuration()
        {
            connectionString = @"Data Source=DESKTOP-3KHTJ6N\SQLEXPRESS;Initial Catalog=CloudLog;Integrated Security=True";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInsertId.Clear();
            txtLogId.Clear();
            txtLogName.Clear();
            txtProtoBType.Clear();
            txtProtoBValue.Clear();
            txtSeverity.Clear();
            txtResource.Clear();
            dpLogTimestampFrom.ResetText();
            dpLogTimestampTo.ResetText();
            dpRecieveFrom.ResetText();
            dpRecieveTo.ResetText();
            reciveDateChange = false;
            logDateChange = false;
        }

        private void dpRecieve_ValueChanged(object sender, EventArgs e)
        {
            reciveDateChange = true;
        }

        private void dplogTimestamp_ValueChanged(object sender, EventArgs e)
        {
            logDateChange = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = null;
                DataTable dataTable = new DataTable();

                try
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    SqlCommand command = new SqlCommand("Search", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    command.Parameters.Add(new SqlParameter("@logId", txtLogId.Text.Trim()));
                    command.Parameters.Add(new SqlParameter("@insertId", txtInsertId.Text.Trim()));
                    command.Parameters.Add(new SqlParameter("@logName", txtLogName.Text.Trim()));
                    command.Parameters.Add(new SqlParameter("@ptypeUrl", txtProtoBType.Text.Trim()));
                    command.Parameters.Add(new SqlParameter("@pvalue", txtProtoBValue.Text.Trim()));
                    command.Parameters.Add(new SqlParameter("@recieveFrom", Convert.ToDateTime(dpRecieveFrom.Value.ToString("yyyy-MM-dd"))));
                    command.Parameters.Add(new SqlParameter("@recieveTo", Convert.ToDateTime(dpRecieveTo.Value.ToString("yyyy-MM-dd"))));
                    command.Parameters.Add(new SqlParameter("@severity", txtSeverity.Text.Trim()));
                    command.Parameters.Add(new SqlParameter("@logChange", logDateChange));
                    command.Parameters.Add(new SqlParameter("@RecieveChange", reciveDateChange));
                    command.Parameters.Add(new SqlParameter("@logTimestampFrom", Convert.ToDateTime(dpLogTimestampFrom.Value.ToString("yyyy-MM-dd"))));
                    command.Parameters.Add(new SqlParameter("@logTimestampTo", Convert.ToDateTime(dpLogTimestampTo.Value.ToString("yyyy-MM-dd"))));
                    command.Parameters.Add(new SqlParameter("@resource", txtResource.Text.Trim()));


                    dataTable.Load(command.ExecuteReader());
                    ddgSearch.DataSource = dataTable;
                }
                finally
                {
                    if (connection != null)
                    {
                        connection.Close();
                    }
                }

                if (true)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtLogId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

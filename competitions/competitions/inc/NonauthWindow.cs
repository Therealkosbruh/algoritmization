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

namespace competitions.inc
{
    public partial class NonauthWindow : Form
    {
        public static string connString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=competitions;Data Source=DESKTOP-GH88B30";
        SqlConnection sqlConnect = new SqlConnection(connString);
        int cnt_rows;
        public NonauthWindow()
        {
            InitializeComponent();
        }

        private void main_window_nonauth_Load(object sender, EventArgs e)
        {
            //загрузка данных в combobox'ы
            sqlConnect.Open();
            SqlCommand eventIdCmd = new SqlCommand("SELECT DISTINCT event_id FROM comp", sqlConnect);
            SqlDataReader eventIdReader = eventIdCmd.ExecuteReader();

            while (eventIdReader.Read())
            {
                
                if (!eventIdReader.IsDBNull(0))
                {
                    event_cb.Items.Add(eventIdReader[0].ToString());
                }
            }
            sqlConnect.Close();

            //выгрузка таблицы в datagrid
            sqlConnect.Open();
            SqlCommand logRequest = new SqlCommand();
            logRequest.CommandText = "Select * FROM comp";
            logRequest.Connection = sqlConnect;

            SqlDataAdapter adapter = new SqlDataAdapter(logRequest);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            sqlConnect.Close();
            actlist.DataSource = dataSet.Tables[0];

            cnt_rows = dataSet.Tables[0].Rows.Count;
            label2.Text = cnt_rows.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void event_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //фильтрация таблицы по мероприятию
            sqlConnect.Open();
            SqlCommand logRequest = new SqlCommand("SELECT * FROM comp WHERE event_id = @eventId", sqlConnect);
            logRequest.Parameters.AddWithValue("@eventId", event_cb.SelectedItem.ToString());

            SqlDataAdapter adapter = new SqlDataAdapter(logRequest);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            sqlConnect.Close();
            actlist.DataSource = dataSet.Tables[0];
            cnt_rows = dataSet.Tables[0].Rows.Count;
            label2.Text = cnt_rows.ToString();
        }
    }
}

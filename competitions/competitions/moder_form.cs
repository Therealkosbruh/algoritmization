using competitions.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace competitions
{
    public partial class moder_form : Form
    {
        public static string connString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=competitions;Data Source=DESKTOP-GH88B30";
        SqlConnection sqlConnect = new SqlConnection(connString);
        public moder_form()
        {
            InitializeComponent();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_moder_jury_form amj = new add_moder_jury_form();
            amj.Show();
        }

        private void moder_form_Load(object sender, EventArgs e)
        {
            //вывод аватарки
            usr_id_lbl.Text = Properties.Settings.Default.usr_id;

            sqlConnect.Open();
            string loadpic = "select * from users where User_id= '" + usr_id_lbl.Text + "'";
            SqlCommand command = new SqlCommand(loadpic, sqlConnect);

            SqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();
            if (dataReader.HasRows)
            {
                usr_id_lbl.Text = dataReader["User_id"].ToString();
                byte[] images = (byte[])dataReader["photo"];
                if (images == null)
                {
                    avatar_pb.Image = null;
                }
                else
                {
                    MemoryStream me = new MemoryStream();
                    avatar_pb.Image = Image.FromStream(me);
                }
            }
            sqlConnect.Close();
            //установка времени для преветствия
            if (DateTime.Now.Hour < 12)
            {
                time_of_day_lbl.Text = "Доброе утро,";
            }
            else if (DateTime.Now.Hour < 17 && DateTime.Now.Hour > 12)
            {
                time_of_day_lbl.Text = "Добрый день,";
            }
            else if (DateTime.Now.Hour < 12 && DateTime.Now.Hour > 17)
            {
                time_of_day_lbl.Text = "Доброе утро,";
            }
            Properties.Settings.Default.usr_id = usr_id_lbl.Text;
            Properties.Settings.Default.Save();


            //запрос на ФИО пользователя
            sqlConnect.Open();
            SqlCommand usrfullname = new SqlCommand("SELECT FIO FROM users WHERE login = @login", sqlConnect);
            usrfullname.Parameters.AddWithValue("@login", usr_id_lbl.Text);
            SqlDataReader reader = usrfullname.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string name = reader["FIO"].ToString();
                    fio_lable.Text = name;
                }
            }
            else
            {
                fio_lable.Text = "No data";
            }
            sqlConnect.Close();

            Properties.Settings.Default.Save();
        }
    }
}

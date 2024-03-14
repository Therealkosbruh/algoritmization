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

namespace competitions.Forms
{
    public partial class registre_form : Form
    {
        public static string connString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=competitions;Data Source=DESKTOP-GH88B30";
        SqlConnection sqlConnect = new SqlConnection(connString);
        public registre_form()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (password_tb.Text == conf_tb.Text)
            {
                sqlConnect.Open();
                string newusr = "INSERT INTO users(FIO,gender,dob,country,phone,password,photo,mail,kind_of_trend,trend) values(@role_id,@FIO,@gender,@dob,@country,@phone,@password,@photo,@mail,@kind_of_trend,@trend))";
                SqlCommand addusr = new SqlCommand(newusr, sqlConnect);
                MemoryStream me = new MemoryStream();
                avatar_pb.Image.Save(me, avatar_pb.Image.RawFormat);
                addusr.Parameters.AddWithValue("@FIO", fio_tb.Text);
                addusr.Parameters.AddWithValue("@dob", dob_tb.Text);
                addusr.Parameters.AddWithValue("@country", country_lbl.Text);
                addusr.Parameters.AddWithValue("@phone", phone_tb.Text);
                addusr.Parameters.AddWithValue("@password", password_tb.Text);
                addusr.Parameters.AddWithValue("@photo", me.ToArray());
                addusr.Parameters.AddWithValue("@mail", email_tb.Text);
                addusr.Parameters.AddWithValue("@kind_of_trend", kind_of_trend_lbl.Text);
                addusr.Parameters.AddWithValue("@trend", act_lbl.Text);


                addusr.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("ПОльзователь успешно добавлен!");
            }
            else
            {
                MessageBox.Show("Проверьте заполненные данные, ваш пароль не совпадает с подтверждением, повторите попытку.");
            }
        }

        private void registre_form_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            SqlCommand eventIdCmd = new SqlCommand("SELECT DISTINCT event_name FROM events", sqlConnect);
            SqlDataReader eventIdReader = eventIdCmd.ExecuteReader();

            while (eventIdReader.Read())
            {

                if (!eventIdReader.IsDBNull(0))
                {
                    act_tb.Items.Add(eventIdReader[0].ToString());
                }
            }
            sqlConnect.Close();

            sqlConnect.Open();
            SqlCommand gender = new SqlCommand("SELECT DISTINCT Gender_name FROM renders", sqlConnect);
            SqlDataReader genderReader = gender.ExecuteReader();

            while (genderReader.Read())
            {

                if (!genderReader.IsDBNull(0))
                {
                    gender_cb.Items.Add(genderReader[0].ToString());
                }
            }
            sqlConnect.Close();

            sqlConnect.Open();
            SqlCommand kot = new SqlCommand("SELECT DISTINCT kot FROM kind_of_trend", sqlConnect);
            SqlDataReader kotReader = kot.ExecuteReader();

            while (kotReader.Read())
            {

                if (!kotReader.IsDBNull(0))
                {
                    trend_cb.Items.Add(kotReader[0].ToString());
                }
            }
            sqlConnect.Close();
            sqlConnect.Open();
            SqlCommand usrcountry = new SqlCommand("SELECT DISTINCT country_name FROM counties", sqlConnect);
            SqlDataReader usrcountryReader = usrcountry.ExecuteReader();

            while (usrcountryReader.Read())
            {

                if (!usrcountryReader.IsDBNull(0))
                {
                    country_tb.Items.Add(kotReader[0].ToString());
                }
            }
            sqlConnect.Close();
        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            int usrgen;
            usrgen = gender_cb.SelectedIndex + 1;
            gender_lbl.Text = Convert.ToString(usrgen);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int usrkot;
            usrkot = trend_cb.SelectedIndex + 1;
            kind_of_trend_lbl.Text = Convert.ToString(usrkot);
        }

        private void act_tb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int usract;
            usract = act_tb.SelectedIndex + 1;
            act_lbl.Text = Convert.ToString(usract);
        }

        private void country_tb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int usrcountry;
            usrcountry = country_tb.SelectedIndex + 1;
            country_lbl.Text = Convert.ToString(usrcountry);
        }

        private void avatar_pb_Click(object sender, EventArgs e)
        {
            OpenFileDialog filter = new OpenFileDialog();
            filter.Filter = "select image(*Jpg; *.png)";
            if (filter.ShowDialog() == DialogResult.OK)
            {
                avatar_pb.Image = Image.FromFile(filter.FileName);
            }
        }
    }
}

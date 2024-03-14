using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using competitions.Forms;
using competitions.inc;

namespace competitions
{
    public partial class auth_form : Form
    {
        static public string loginActive;
        public static string connString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=competitions;Data Source=DESKTOP-GH88B30";
        SqlConnection sqlConnect = new SqlConnection(connString);
        public auth_form()
        {
            InitializeComponent();
        }

        public object role_id { get;  }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();


            SqlCommand logRequsest = new SqlCommand();
            logRequsest.CommandType = CommandType.StoredProcedure;
            logRequsest.CommandText = "Login";
            logRequsest.Parameters.AddWithValue("@user_id", id_tb.Text);
            logRequsest.Parameters.AddWithValue("@password", password_tb.Text);
            logRequsest.Connection = sqlConnect;

            
            using (SqlDataReader sqlReader = logRequsest.ExecuteReader())
            {
                if (sqlReader.Read())
                {
                    
                    int userId = Convert.ToInt32(sqlReader["user_id"]);

                    
                    sqlReader.Close();

                    
                    SqlCommand roleRequest = new SqlCommand();
                    roleRequest.CommandType = CommandType.Text;
                    roleRequest.CommandText = "SELECT role_id FROM users WHERE User_id = @user_id";
                    roleRequest.Parameters.AddWithValue("@user_id", userId);
                    roleRequest.Connection = sqlConnect;

                    
                    using (SqlDataReader roleReader = roleRequest.ExecuteReader())
                    {
                        if (roleReader.Read())
                        {
                            int roleId = Convert.ToInt32(roleReader["role_id"]);

                            
                            if (roleId == 1) 
                            {
                                
                                this.Hide();
                                MemberForm mf = new MemberForm();
                                mf.Show();
                            }
                            else if (roleId == 2) 
                            {
                                //this.Hide();
                                //moder_form mf = new moder_form();
                                //mf.Show();
                            }
                            else if (roleId == 3) 
                            {

                                //this.Hide();
                                //jury_form jf = new jury_form();
                                //jf.Show();
                            }
                            else if (roleId == 4) 
                            {
                                
                                this.Hide();
                                ArrangerForm af = new ArrangerForm();
                                af.Show();
                                    
                                
                            }

                        }
                        else
                        {
                            MessageBox.Show("Ошибка в заполнение данных, попробуйте снова!");
                        }
                    }
                }
            }

            
            sqlConnect.Close();
            Properties.Settings.Default.usr_id = id_tb.Text;
            Properties.Settings.Default.Save();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm rgstr = new RegisterForm();
            rgstr.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            NonauthWindow mwn = new NonauthWindow();
            mwn.Show();
        }
    }
    }


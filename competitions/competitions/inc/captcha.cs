using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace competitions.inc
{
    public partial class captcha : Form
    {
        public captcha()
        {
            InitializeComponent();
            loadCptch();
        }
        int num = 0;
        private void loadCptch()
        {
            Random r1 = new Random();
            num = r1.Next(100, 999);
            var ing = new Bitmap(this.cptch_tb.Width, this.cptch_tb.Height);
            var font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Pixel);
            var grph = Graphics.FromImage(ing);
            grph.DrawString(num.ToString(), font, Brushes.Red, new Point(0, 0));
            cpt_pb.Image = ing;
        }

        private void capthca_btn_Click(object sender, EventArgs e)
        { 

        }

        private void capthca_btn_Click_1(object sender, EventArgs e)
        {
            if (cptch_tb.Text == num.ToString())
            {
                MessageBox.Show("Верно",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                this.Hide();
                AuthForm af = new AuthForm();
                af.Show();
            }
        }

        private void chnge_btn_Click(object sender, EventArgs e)
        {
            loadCptch();
        }
    }
}

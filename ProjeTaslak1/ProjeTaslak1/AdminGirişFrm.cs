using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeTaslak1
{
    public partial class AdminGirişFrm : Form
    {
        public AdminGirişFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve Şifre boş geçilemez.", "UYARI");
            }

            else

            {
                if ((textBox1.Text == "Yasin" && textBox2.Text == "1810206055" || textBox1.Text == "Nazif" && textBox2.Text == "1810206034"))
                {
                    MessageBox.Show("Giriş Başarılı");
                    AnaMenüFrm frm = new AnaMenüFrm();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız");
                }
            }

        }

      
    }
}















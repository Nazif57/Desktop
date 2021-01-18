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
    public partial class AnaMenüFrm : Form
    {
        public AnaMenüFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Masa1Frm frm = new Masa1Frm();
            frm.Show();
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Masa2Frm frm = new Masa2Frm();
            frm.Show();           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Masa3Frm frm = new Masa3Frm();
            frm.Show();
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Masa4Frm frm = new Masa4Frm();
            frm.Show();
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Masa5Frm frm = new Masa5Frm();
            frm.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AÜrünlerFrm frm = new AÜrünlerFrm();
            frm.Show();           
        }

        private void AnaMenüFrm_Load(object sender, EventArgs e)
        {

        }
    }
}

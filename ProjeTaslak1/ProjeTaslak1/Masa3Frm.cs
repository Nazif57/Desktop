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
    public partial class Masa3Frm : Form
    {
        public Masa3Frm()
        {
            InitializeComponent();
        }

        private void Masa3Frm_Load(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox2.SelectionMode = SelectionMode.MultiExtended;
            listBox3.SelectionMode = SelectionMode.MultiExtended;
            listBox4.SelectionMode = SelectionMode.MultiExtended;
            listBox5.SelectionMode = SelectionMode.MultiExtended;
            listBox6.SelectionMode = SelectionMode.MultiExtended;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           listBox6.Items.Add(listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           listBox6.Items.Add(listBox5.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           listBox6.Items.Add(listBox2.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add(listBox4.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add(listBox3.SelectedItem);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox6.Items.Remove(listBox6.SelectedItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox6.Items.Clear();
        }
    }
}

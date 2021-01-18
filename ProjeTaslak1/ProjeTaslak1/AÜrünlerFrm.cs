using System;
using System.Windows.Forms;

namespace ProjeTaslak1
{
    public partial class AÜrünlerFrm : Form
    {

        public AÜrünlerFrm()
        {
            InitializeComponent();
        }
    
        private void AürünlerFORM_Load(object sender, EventArgs e)
        {
            {
                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].Name = "Ürün Adı";
                dataGridView1.Columns[1].Name = "Ürün Fiyatı";
                dataGridView1.Columns[2].Name = "Ürün Kodu";

                dataGridView1.Rows.Add("Kurabiye", "3,50", "KRB");
                dataGridView1.Rows.Add("Poğaça", "2,75", "PGÇ");
                dataGridView1.Rows.Add("Simit", "2,50", "SMT");
                dataGridView1.Rows.Add("Gül Böreği", "4,00", "GLB");
                dataGridView1.Rows.Add("Küt Böreği", "7,50", "BRK");
                dataGridView1.Rows.Add("Çay", "2,00", "CAY");
                dataGridView1.Rows.Add("Ekler", "4,00", "EKL");
                dataGridView1.Rows.Add("Profiterol", "6,00", "PRF");
                dataGridView1.Rows.Add("Fıstıklı Baklava", "40,00", "FBV");
                dataGridView1.Rows.Add("Cevizli Baklava", "25,00", "CBV");
                dataGridView1.Rows.Add("Malaga", "17,50", "MLG");
                dataGridView1.Rows.Add("Maraş Dondurması(Cup)", "6,50", "MDC");
                dataGridView1.Rows.Add("Maraş Dondurması(Külah)", "2,50", "MDK");

                dataGridView2.ColumnCount = 3;
                dataGridView2.Columns[0].Name = "Ürün Adı";
                dataGridView2.Columns[1].Name = "Ürün Fiyatı";
                dataGridView2.Columns[2].Name = "Ürün Kodu";                
            }

        }
   
        void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if
                (dataGridView1.SelectedRows.Count > 0)
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

            else
            {
                MessageBox.Show("Lütfen Silinecek Satır Seçiniz");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                object[] rowDat = new object[row.Cells.Count];

                for (int i = 0; i < rowDat.Length; i++)
                {
                    rowDat[i] = row.Cells[i].Value;
                }
                this.dataGridView2.Rows.Add(rowDat);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                double toplam = 0;

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    toplam += Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value);
                }
                label5.Text = "Toplam Tutar : " + toplam ;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if
                (dataGridView2.SelectedRows.Count > 0)
                dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);

            else
            {
                MessageBox.Show("Lütfen Silinecek Satır Seçiniz");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Masa1Frm frm = new Masa1Frm();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            {
                Masa2Frm frm = new Masa2Frm();
                frm.Show();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            {
                Masa3Frm frm = new Masa3Frm();
                frm.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                Masa4Frm frm = new Masa4Frm();
                frm.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            {
                Masa5Frm frm = new Masa5Frm();
                frm.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}




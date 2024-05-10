using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace VeriRaporlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Sütunları oluştur
            dataGridView1.Columns.Add("aciklamaColumn", "Açıklama");
            dataGridView1.Columns.Add("fiyatColumn", "Fiyat");
            dataGridView1.Columns.Add("tutarColumn", "Tutar");
            dataGridView1.Columns.Add("miktarColumn", "Miktar");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string aciklama = txtmaciklama.Text;
            string fiyat = txtmfiyat.Text;
            string tutar = txtmtutar.Text;
            string miktar = txtmmiktar.Text;

            if (dataGridView1.Rows.Count > 0)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = aciklama;
                row.Cells[1].Value = fiyat;
                row.Cells[2].Value = tutar;
                row.Cells[3].Value = miktar;
                dataGridView1.Rows.Add(row);
            }
            else // DataGridView'de satır yoksa
            {
                dataGridView1.Rows.Add(aciklama, fiyat, tutar, miktar);
            }

            txtmaciklama.Text = txtmfiyat.Text = txtmmiktar.Text = txtmtutar.Text = "";
        }

        private void txtmmiktar_TextChanged(object sender, EventArgs e)
        {
            int miktar = 0;
            int fiyat = 0;
            if (txtmmiktar.TextLength > 0 && txtmfiyat.TextLength > 0)
            {
                miktar = Convert.ToInt32(txtmmiktar.Text);
                fiyat = Convert.ToInt32(txtmfiyat.Text);
                double tutar = Convert.ToDouble(miktar * fiyat);
                txtmtutar.Text = tutar.ToString();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}


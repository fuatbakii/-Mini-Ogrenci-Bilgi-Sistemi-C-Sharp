using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fuatobs
{
    public partial class SınıfEklemeForm : Form
    {
        public SınıfEklemeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SınıfEklemeForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'fuatobsdbDataSet2.Sinif' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sinifTableAdapter.Fill(this.fuatobsdbDataSet2.Sinif);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fuatobsdbEntities2 vt = new fuatobsdbEntities2();
            Sinif k1= new Sinif();  

            k1.SinifAd=txtSinifAd.Text;
            vt.Sinif.Add(k1);
            vt.SaveChanges();
            int sonuc = vt.SaveChanges();
            if (sonuc >= 0)
            {
                MessageBox.Show("Kaydetme Başarılı!");
            }
            else
            { MessageBox.Show("Kaydetme Başarısız!"); }


            using (fuatobsdbEntities2 db = new fuatobsdbEntities2())
            {
                var liste = from s in db.Sinif select s;
                dataGridView1.DataSource = liste.ToList();
            }




        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            label2.Text = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int silinecekKisiID = Convert.ToInt32(label2.Text);
            fuatobsdbEntities2 vt = new fuatobsdbEntities2();
            Sinif k1 = vt.Sinif.FirstOrDefault(p => p.SinifID == silinecekKisiID);
            vt.Sinif.Remove(k1);
            int sonuc = vt.SaveChanges();

            if (sonuc > 0)
            {

                MessageBox.Show("Silme işlemi başarılı");
            }
            using (fuatobsdbEntities2 context = new fuatobsdbEntities2())
            {
                var liste = from s in context.Sinif select s;
                dataGridView1.DataSource = liste.ToList();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

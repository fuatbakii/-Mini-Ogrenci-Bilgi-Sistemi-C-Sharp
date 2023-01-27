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
    public partial class DersEklemeform : Form
    {
        public DersEklemeform()
        {
            InitializeComponent();
        }

        private void DersEklemeform_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'fuatobsdbDataSet1.Ders' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.dersTableAdapter.Fill(this.fuatobsdbDataSet1.Ders);
            dataGridView1.AutoGenerateColumns = false;
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //      fuatobsdbEntities1 vt =new fuatobsdbEntities1();
            //      Ders k1 = new Ders();
            //      k1.DersAd=txtDersAd.Text;
            //      vt.Ders.Add(k1);
            //      vt.SaveChanges();
            //float sonuc = vt.SaveChanges();
            //if (sonuc >=0)
            //{
            //    MessageBox.Show("Kaydetme Başarılı!");
            //}
            //else
            //    MessageBox.Show("Kaydetme Başarısız!");

            //using (fuatobsdbEntities1 db = new fuatobsdbEntities1())
            //{
            //    var liste = from s in db.Ders select s;
            //    dataGridView1.DataSource = liste.ToList();
            //}
            using (fuatobsdbEntities2 context = new fuatobsdbEntities2())
            {
                Ders ders = new Ders();
                ders.DersAd = txtDersAd.Text;
                context.Ders.Add(ders);
                int sonuc = context.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Kaydetme Başarılı!");
                    Listele();
                }
                else
                    MessageBox.Show("Kaydetme Başarısız!");
            }

        }

       
        void Listele()
        {
            using (fuatobsdbEntities2 context = new fuatobsdbEntities2())
            {
                var liste = from s in context.Ders select s;
                dataGridView1.DataSource = liste.ToList();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int silinecekKisiID = Convert.ToInt32(lbl3.Text);
            fuatobsdbEntities2 vt = new fuatobsdbEntities2();
            Ders k1 = vt.Ders.FirstOrDefault(p => p.DersID == silinecekKisiID);
            vt.Ders.Remove(k1);
            int sonuc = vt.SaveChanges();

            if (sonuc > 0)
            {
                
                MessageBox.Show("Silme işlemi başarılı");
            }
            using (fuatobsdbEntities2 context = new fuatobsdbEntities2())
            {
                var liste = from s in context.Ders select s;
                dataGridView1.DataSource = liste.ToList();
            }


        }

     

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            lbl3.Text = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
        }
    }
}

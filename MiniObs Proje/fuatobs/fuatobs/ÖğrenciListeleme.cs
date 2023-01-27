using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
namespace fuatobs
{
    public partial class ÖğrenciListeleme : Form
    {
        public ÖğrenciListeleme()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            using (fuatobsdbEntities2 context = new fuatobsdbEntities2())
            {
                var liste = from s in context.Ogrenci select s;
                dataGridView1.DataSource = liste.ToList();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            using (fuatobsdbEntities2 context = new fuatobsdbEntities2())
            {
                int ogrNO = Convert.ToInt32(txtOGRno.Text);
                var liste = from s in context.Ogrenci where s.OgrenciNo == ogrNO  select s;
                dataGridView1.DataSource = liste.ToList();
            }
          

        }

        private void ÖğrenciListeleme_Load(object sender, EventArgs e)
        {
            
            this.vOgrenciTableAdapter1.Fill(this.fuatobsdbDataSet13.vOgrenci);
           
            Listele();
            
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {

            // baglan.Open();
            //SqlCommand cmd = new SqlCommand("delete from Ogrenci where OgrenciNo=@p1",baglan);
            //cmd.Parameters.AddWithValue("@p1", txtOGRno.Text);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Başarı ile silindi");
            //Listele();
            //baglan.Close();









            int silinecekKisiID = Convert.ToInt32(txtOGRno.Text);
            fuatobsdbEntities2 vt = new fuatobsdbEntities2();
            Ogrenci k1 = vt.Ogrenci.FirstOrDefault(p => p.OgrenciNo == silinecekKisiID);
            vt.Ogrenci.Remove(k1);
            int sonuc = vt.SaveChanges();

            if (sonuc>0)
            {

                MessageBox.Show("Silme işlemi başarılı");
            }


            using (fuatobsdbEntities2 context = new fuatobsdbEntities2())
            {
                var liste = from s in context.Ogrenci select s;
                dataGridView1.DataSource = liste.ToList();
            }





        }

        

       

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            txtOGRno.Text = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
        }
    }
}

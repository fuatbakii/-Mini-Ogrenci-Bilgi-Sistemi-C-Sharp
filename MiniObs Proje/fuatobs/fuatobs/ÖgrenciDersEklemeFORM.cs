using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fuatobs
{
    public partial class ÖgrenciDersEklemeFORM : Form
    {
        public ÖgrenciDersEklemeFORM()
        {
            InitializeComponent();
        }
        public int OgrenciID { get; set; }
       
        SqlConnection conect = new SqlConnection("Data Source=DESKTOP-K552F5E;Initial Catalog=fuatobsdb; Integrated Security=True");
        private void ÖgrenciDersEklemeFORM_Load(object sender, EventArgs e)
        {
          





            fuatobsdbEntities2 vt = new fuatobsdbEntities2();
            cbDers.DisplayMember = "DersAd";
            cbDers.DataSource = vt.Ders.ToList();



            //SqlCommand komut = new SqlCommand();
            //komut.CommandText = "SELECT * FROM Ders";
            //komut.Connection = conect;
            //komut.CommandType = CommandType.Text;

            //SqlDataReader dr;
            //conect.Open();
            //dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    cbDers.Items.Add(dr["DersID"]);
            //}
            //conect.Close();
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {



            fuatobsdbEntities2 db = new fuatobsdbEntities2();
            OgrenciDers od =new OgrenciDers();
            Ogrenci ogr= new Ogrenci();
            if (cbDers.Text !=null)
            {
                od.DersId = Convert.ToInt32(label6.Text);
                od.OgrenciId = Convert.ToInt32(label5.Text); 
                db.OgrenciDers.Add(od);
                int sonuc = db.SaveChanges();
                if (sonuc>0)
                {
                    MessageBox.Show("Ders Eklendi");
                    var liste = from p in db.OgrenciDers where p.OgrenciId==ogr.OgrenciID select p;
                    dataGridView1.DataSource= liste.ToList();
             
                }
                else
                {
                    MessageBox.Show("Ders Eklenemedi");

                }


            }

            listele();
           

           


            //conect.Open();
            //SqlCommand cmd = new SqlCommand("Insert Into OgrenciDers Values(@p1,@p2)",conect);
            //cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            //cmd.Parameters.AddWithValue("@p2",cbDers.Text);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Öğrenciye ders başarı ile eklendi");
            //conect.Close();
        }
      public  void listele()
        {
            conect.Close();
            conect.Open();
            SqlCommand cmd2 = new SqlCommand("select DersAd from OgrenciDers inner join Ders on OgrenciDers.DersId=Ders.DersID where OgrenciId=@p1", conect);
            cmd2.Parameters.AddWithValue("@p1", label5.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            da.SelectCommand = cmd2;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conect.Close();

        }
        private void btn_bul_Click(object sender, EventArgs e)
        {
            conect.Open();
            SqlCommand cmd = new SqlCommand("select Ad,Soyad,OgrenciID from Ogrenci where OgrenciNo=@p1", conect);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            SqlDataReader dr=cmd.ExecuteReader();
            while(dr.Read())
            {
                label4.Visible = true;
                label5.Visible = true;
                label4.Text = dr[0].ToString()+" " + dr[1].ToString();
                label5.Text = dr[2].ToString();
            }

            
            listele();

            //using (fuatobsdbEntities2 context = new fuatobsdbEntities2())
            //{
            //    var liste = from s in context.vOgrenci where s.OgrenciNo == textBox1.Text select s;
            //    dataGridView1.DataSource = liste.ToList();
            //}

            //using (fuatobsdbEntities2 context = new fuatobsdbEntities2())
            //{
            //    var liste = from s in context.Ogrenci where s.OgrenciNo == Convert.ToInt32(textBox1.Text) select s;
            //    label4.Text = liste.ToList()[2].Ad + " " + liste.ToList()[3].Soyad;
            //    //label5.Text = liste.ToList()[0].OgrenciNo;
            //    OgrenciID = liste.ToList()[0].OgrenciID;
            //}
            //using (fuatobsdbEntities2 context = new fuatobsdbEntities2())
            //{
            //    var liste = from s in context.vOgrenciDers where s.OgrenciId == OgrenciID select s;
            //    dataGridView1.DataSource = liste.ToList();
            //}

            //using (fuatobsdbEntities2 context = new fuatobsdbEntities2())
            //{
            //    OgrenciDers od = new OgrenciDers();
            //    od.OgrenciId = OgrenciID;
            //    if (cbDers.SelectedValue != null)
            //        od.DersId = Convert.ToInt32(cbDers.SelectedValue);
            //    context.OgrenciDers.Add(od);
            //    int sonuc = context.SaveChanges();
            //    if (sonuc > 0)
            //    {
            //        MessageBox.Show("Kaydetme Başarılı!");
            //        using (fuatobsdbEntities2 c = new fuatobsdbEntities2())
            //        {
            //            var liste = from s in c.vOgrenciDers where s.OgrenciId == OgrenciID select s;
            //            dataGridView1.DataSource = liste.ToList();
            //        }
            //    }
            //    else
            //        MessageBox.Show("Kaydetme Başarısız!");
            //}

            



        }

        private void cbDers_TextChanged(object sender, EventArgs e)
        {
            conect.Open();
            SqlCommand cmd = new SqlCommand("select DersID from Ders where DersAd=@p1",conect);
            cmd.Parameters.AddWithValue("@p1",cbDers.Text);
            SqlDataReader dr=cmd.ExecuteReader();
            while(dr.Read())
            {
                label6.Text = dr[0].ToString();
            }
            conect.Close();
        }
    }
}

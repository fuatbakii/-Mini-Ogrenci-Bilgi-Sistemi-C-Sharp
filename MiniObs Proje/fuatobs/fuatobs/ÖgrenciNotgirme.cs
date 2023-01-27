using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fuatobs
{
    public partial class ÖgrenciNotgirme : Form
    {
        public ÖgrenciNotgirme()
        {
            InitializeComponent();
        }
        SqlConnection conect = new SqlConnection("Data Source=DESKTOP-K552F5E;Initial Catalog=fuatobsdb; Integrated Security=True");
       

        void listele()
        {
            conect.Open();
            SqlCommand cmd = new SqlCommand("Select OgrenciNo,Ad,Soyad,DersAd,VizeNotu,FinalNotu,ButunlemeNotu,Ortalama from OgrenciNot inner join Ogrenci on OgrenciNot.OgrenciId=Ogrenci.OgrenciID inner join Ders on OgrenciNot.DersId=Ders.DersID", conect);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource= dt;
            conect.Close();
        }
        void listele2()
        {
            conect.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT OgrenciNo, Ad, Soyad, DersAd,VizeNotu, FinalNotu,ButunlemeNotu, Ortalama FROM Ogrenci INNER JOIN OgrenciNot ON Ogrenci.OgrenciID = dbo.OgrenciNot.OgrenciId INNER JOIN Ders ON OgrenciNot.DersId = Ders.DersID where OgrenciNo=@p1 ", conect);
            cmd2.Parameters.AddWithValue("@p1", txtOgrNo.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd2;
            DataTable dataTable= new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conect.Close();
        }
        private void ÖgrenciNotgirme_Load(object sender, EventArgs e)
        {
            
            listele();
            conect.Open();
            SqlCommand cmd2 = new SqlCommand("select OgrenciNo,Ad,Soyad from Ogrenci", conect);
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter();
            dataAdapter2.SelectCommand = cmd2;
            DataTable dt2 = new DataTable();
            dataAdapter2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            conect.Close();

            fuatobsdbEntities2 vt = new fuatobsdbEntities2();
            cbDERS.DisplayMember = "DersAd";
            cbDERS.DataSource = vt.Ders.ToList();
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int chosen_value = dataGridView1.SelectedCells[0].RowIndex;
            txtOgrNo.Text = dataGridView1.Rows[chosen_value].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[chosen_value].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[chosen_value].Cells[2].Value.ToString();
            cbDERS.Text = dataGridView1.Rows[chosen_value].Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[chosen_value].Cells[4].Value.ToString();
            maskedTextBox2.Text = dataGridView1.Rows[chosen_value].Cells[5].Value.ToString();
            maskedTextBox3.Text = dataGridView1.Rows[chosen_value].Cells[6].Value.ToString();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen_value = dataGridView2.SelectedCells[0].RowIndex;
            txtOgrNo.Text = dataGridView2.Rows[chosen_value].Cells[0].Value.ToString();
            txtAd.Text = dataGridView2.Rows[chosen_value].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView2.Rows[chosen_value].Cells[2].Value.ToString();
            listele2();



            //listele();
            //conect.Open();
            //SqlCommand cmd2 = new SqlCommand("select OgrenciNo,Ad,Soyad from Ogrenci", conect);
            //SqlDataAdapter dataAdapter2 = new SqlDataAdapter();
            //dataAdapter2.SelectCommand = cmd2;
            //DataTable dt2 = new DataTable();
            //dataAdapter2.Fill(dt2);
            //dataGridView2.DataSource = dt2;
            //conect.Close();

            //fuatobsdbEntities2 vt = new fuatobsdbEntities2();


            //using (fuatobsdbEntities2 context = new fuatobsdbEntities2())
            //{
            //    int txtgrNo = Convert.ToInt32(txtOgrNo.Text);
            //    var liste = from s in context.OgrenciNot where s.OgrenciNo == txtgrNo select s;
            //    dataGridView1.DataSource = liste.ToList();

            //}
            //using (fuatobsdbEntities2 context = new fuatobsdbEntities2())
            //{
            //    var liste = from s in context.vOgrenciDers where s.OgrenciId == OgrenciID select s;
            //    cbDers.DataSource = liste.ToList();
            //}   
            //using (fuatobsdbEntities2 context = new fuatobsdbEntities2())
            //{
            //    var liste = from s in context.vOgrenciNot where s.OgrenciId == OgrenciID select s;
            //    dataGridView1.DataSource = liste.ToList();
            //}






        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox1.Text == "" & maskedTextBox2.Text == ""&maskedTextBox3.Text=="" & txtOgrNo.Text == "")
                {
                    MessageBox.Show("Tüm alanları doldurun lütfen");
                }
                else if (maskedTextBox1.Text != "" & maskedTextBox2.Text != "" & txtOgrNo.Text != "" & cbDERS.Text != "")
                {
                    conect.Open();
                    SqlCommand cmd = new SqlCommand("insert into OgrenciNot(OgrenciId,DersId,VizeNotu,FinalNotu,ButunlemeNotu) values(@p1,@p2,@p3,@p4,@p5)", conect);
                    cmd.Parameters.AddWithValue("@p1", label7.Text);
                    cmd.Parameters.AddWithValue("@p2", label1.Text);
                    cmd.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
                    cmd.Parameters.AddWithValue("@p4", maskedTextBox2.Text);
                    cmd.Parameters.AddWithValue("@p5", maskedTextBox3.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı");
                    conect.Close();
                    listele();
                }
                //else if ( maskedTextBox3.Text != "" & cbDERS.Text != "" & txtOgrNo.Text !=" ")
                //{
                //    conect.Open();
                //    SqlCommand cmd = new SqlCommand("insert into OgrenciNot(OgrenciId,DersId,VizeNotu,FinalNotu,ButunlemeNotu) values(@p1,@p2,@p3,@p4,@p5)", conect);
                //    cmd.Parameters.AddWithValue("@p1", label7.Text);
                //    cmd.Parameters.AddWithValue("@p2", label1.Text);
                //    cmd.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
                //    cmd.Parameters.AddWithValue("@p4", maskedTextBox2.Text);
                //    cmd.Parameters.AddWithValue("@p5", maskedTextBox3.Text);
                //    cmd.ExecuteNonQuery();
                //    MessageBox.Show("Kayıt başarılı");
                //    conect.Close();
                //    listele();
                //}
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cbDERS_TextChanged(object sender, EventArgs e)
        {
            conect.Open();
            SqlCommand cmd = new SqlCommand("select DersID from Ders where DersAd=@p1", conect);
            cmd.Parameters.AddWithValue("@p1", cbDERS.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label1.Text = dr[0].ToString();
            }
            conect.Close();
        }

        private void txtOgrNo_TextChanged(object sender, EventArgs e)
        {
            conect.Open();
            SqlCommand cmd = new SqlCommand("select OgrenciID from Ogrenci where OgrenciNo=@p1", conect);
            cmd.Parameters.AddWithValue("@p1", txtOgrNo.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label7.Text = dr[0].ToString();
            }
            conect.Close();
        }
    }
}

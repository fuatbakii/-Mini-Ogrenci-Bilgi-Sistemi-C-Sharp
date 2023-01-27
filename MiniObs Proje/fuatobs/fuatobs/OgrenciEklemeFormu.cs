using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fuatobs
{
    public partial class OgrenciEklemeFormu : Form
    {
        public OgrenciEklemeFormu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            fuatobsdbEntities2 vt = new fuatobsdbEntities2();

            Ogrenci k1 = new Ogrenci();
            k1.OgrenciNo = Convert.ToInt32(txtOgrenciNo.Text);
            k1.Ad = txt_Ad.Text;
            k1.Soyad = txt_Soyad.Text;
            if (cbSINIF.SelectedValue != null)
                k1.SinifId = Convert.ToInt32(cbSINIF.SelectedValue);
            k1.Cinsiyet = rbErkek.Checked ? "Erkek" : "Kadın";
            k1.Telefon = txtTelefon.Text;
            k1.DogumTarihi = dtDogumTarihi.Value;
            k1.Memleket = cbMemleket.Text;
            vt.Ogrenci.Add(k1);
            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                k1.Resim = ms.ToArray();
            }
            vt.SaveChanges();   
            int sonuc = vt.SaveChanges();
            if (sonuc >= 0)
            {
                MessageBox.Show("Kaydetme Başarılı!");
            }
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpeg Resim Dosyası|*.jpg";
            ofd.ShowDialog();
            if (!string.IsNullOrEmpty(ofd.FileName))
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }

            //OpenFileDialog dlg = new OpenFileDialog();
            //if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    pictureBox1.ImageLocation = dlg.FileName;
            //}
            // OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Jpeg Resim Dosyası|*.jpg";
            //ofd.ShowDialog();
            //if (!string.IsNullOrEmpty(ofd.FileName))
            //{
            //    picResim.Image = Image.FromFile(ofd.FileName);
            //}




            //pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            //openFileDialog1.ShowDialog();
            //pictureBox1.ImageLocation = openFileDialog1.FileName;

            //if (DosyaAc.ShowDialog() == DialogResult.OK)
            //{
            //    foreach (string i in DosyaAc.FileName.Split('\\'))
            //    {
            //        if (i.Contains(".jpg")) { DosyaAdi = i; }//www.gorselprogramlama.com
            //        else if (i.Contains(".bmp")) { DosyaAdi = i; }
            //        else if (i.Contains(".png")) { DosyaAdi = i; }
            //        else if (i.Contains(".gif")) { DosyaAdi = i; }
            //        else { DosyaYolu += i + "\\"; }
            //    }
            //    pictureBox1.ImageLocation = DosyaAc.FileName;
            //    cmd = new OleDbCommand("inser into tablom (ResimAdi,DosyaYolu,DosyaAdi) values ('TEST'," +
            //    MessageBox.Show(DosyaAc.FileName.Split(@"\"));
            //}
            //else//www.gorselprogramlama.com
            //{
            //    MessageBox.Show("Herhangibir Resim Girilmedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}



        }

        private void txt_Ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void OgrenciEklemeFormu_Load(object sender, EventArgs e)
        {
        //    fuatobsdbEntities2 vt = new fuatobsdbEntities2();
        //    cbSINIF.DisplayMember = "SinifAd";
        //    cbSINIF.DataSource = vt.Sinif.ToList();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

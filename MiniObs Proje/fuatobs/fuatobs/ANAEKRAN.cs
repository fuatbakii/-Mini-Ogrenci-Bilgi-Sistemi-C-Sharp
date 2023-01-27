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
    public partial class ANA_EKRAN : Form
    {
        public ANA_EKRAN()
        {
            InitializeComponent();


        }




        private void BTN_GİRİŞ_Click(object sender, EventArgs e)
        {
            string KullanıcıAdı = txt_Kullanıcıadı.Text;
            string SİFRE = txt_Sifre.Text;

            using (var context = new fuatobsdbEntities2())
            {
                var Ogrenciişleri = context.Ogreciisleri
                    .Where(s => s.kullanıcıAdı == KullanıcıAdı && s.Password == SİFRE)
                    .FirstOrDefault();

                if (Ogrenciişleri != null)
                {
                    Form1 frm1 = new Form1();
                   

                    frm1.Show();
                     this.Hide();
                }


                var ogretmenn = context.Ogretmen
                       .Where(t => t.kullanıcıAdı == KullanıcıAdı && t.Password == SİFRE)
                       .FirstOrDefault();

                if(ogretmenn !=null) 
                {
                    

                    if (ogretmenn != null)
                    {
                        Form2 frm2 = new Form2();
                    
                        frm2.Show();
                        this.Hide();
                    }
                    else
                    {
                        
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                    }

                }



                var Ogrenciii = context.Ogrencii
                    .Where(s => s.kullanıcıAdı == KullanıcıAdı && s.Password == SİFRE)
                    .FirstOrDefault();

                if (Ogrenciii != null)
                {
                    Form3 frm1 = new Form3();
               
                    frm1.Show();
                    this.Hide();
                }



            }
        }
}   }
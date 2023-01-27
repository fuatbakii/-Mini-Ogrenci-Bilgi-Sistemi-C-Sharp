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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                {
                    c.BackColor = this.BackColor;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgrenciEklemeFormu frm1 = new OgrenciEklemeFormu();
            frm1.MdiParent= this;   
         //  frm1.FormBorderStyle= FormBorderStyle.None;
            frm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ÖğrenciListeleme frm1 = new ÖğrenciListeleme ();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DersEklemeform frm2=new DersEklemeform ();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SınıfEklemeForm frm3 = new SınıfEklemeForm();
            frm3.MdiParent = this;
            frm3.Show();    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

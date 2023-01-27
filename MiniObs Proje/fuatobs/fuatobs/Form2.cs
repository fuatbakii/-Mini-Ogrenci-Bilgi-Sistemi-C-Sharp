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
    public partial class Form2 : Form
    {
        public Form2()
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

        private void ogr_ekle_Click(object sender, EventArgs e)
        {

            ÖgrenciNotgirme frm1 = new ÖgrenciNotgirme();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ÖgrenciDersEklemeFORM FRM1 = new ÖgrenciDersEklemeFORM();
            FRM1.MdiParent = this;
            FRM1.Show();
        }
    }
}

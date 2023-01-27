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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (fuatobsdbEntities2 context = new fuatobsdbEntities2())
            {
                int ogrno = Convert.ToInt32(txtOGRno.Text);
                var liste = from s in context.ÖgrencininNOTU where s.OgrenciNo == ogrno select s;
                dataGridView1.DataSource = liste.ToList();
            }
            
        }
    }
}

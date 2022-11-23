using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Koltuk : UserControl
    {
        Label gecici;
        public static int RezerveSayisi;
        Form f1;
        public Koltuk(int siraNo, Form f)
        {
            InitializeComponent();
            iptalEtToolStripMenuItem.Enabled = false;
            label1.Text = siraNo.ToString();
            f1 = f;
        }


   private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {

         

            label1.BackColor = Color.Green;
            rezerveEtToolStripMenuItem.Enabled = false;
            iptalEtToolStripMenuItem.Enabled = true;
            RezerveSayisi++;
            gecici.Text = RezerveSayisi.ToString();
            
        }

        private void iptalEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


            label1.BackColor = Color.Red;
            rezerveEtToolStripMenuItem.Enabled = true;
            iptalEtToolStripMenuItem.Enabled = false;
            RezerveSayisi--;
            gecici.Text = RezerveSayisi.ToString();

        }
    }
}

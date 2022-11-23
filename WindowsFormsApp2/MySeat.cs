using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class MySeat:Label
    {
        ContextMenuStrip ctx;
        ToolStripMenuItem rezerve;
        ToolStripMenuItem iptal;
        public MySeat()
        {
            ctx = new ContextMenuStrip();
           rezerve = new ToolStripMenuItem();
            rezerve.Text = "Rezerve Et";
            rezerve.Click += Rezerve_Click;
            iptal = new ToolStripMenuItem();
            iptal.Text = "İptal Et";
            iptal.Click += Iptal_Click;
            iptal.Enabled = false;
            ctx.Items.Add(rezerve);
            ctx.Items.Add(iptal);
            this.BackColor = System.Drawing.Color.Red;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = ctx;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AutoSize = false;
            this.Size = new System.Drawing.Size(50, 50);

       
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private void Iptal_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            iptal.Enabled = false;
            rezerve.Enabled = true;
        }

        private void Rezerve_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            iptal.Enabled = true;
            rezerve.Enabled = false;
        }
    }
}

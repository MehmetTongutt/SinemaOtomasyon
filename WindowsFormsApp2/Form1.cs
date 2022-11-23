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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        void Basla()
        {
            Koltuk ms;


            for (int i = 1; i <= 50; i++)
            {
                ms = new Koltuk(i,this);
               
                flowLayoutPanel1.Controls.Add(ms);

            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Basla();
        }
    }
}

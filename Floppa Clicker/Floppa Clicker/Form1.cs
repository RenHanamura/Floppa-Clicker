using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floppa_Clicker
{
    public partial class Form1 : Form
    {
        public int floppa = 0;
        private bool change;
        public int rave = 0;

        public Form1()
        {
            InitializeComponent();
        }
        
        public void pictureBox1_Click(object sender, EventArgs e)
        {
            floppa++;
            rave++;
            label3.Text = floppa.ToString();

            if (change)
            {
                pictureBox1.Image = Floppa_Clicker.Properties.Resources.floppa_2;
            } else
            {
                pictureBox1.Image = Floppa_Clicker.Properties.Resources.floppa_1; 
            }
            change = !change;

            flopRave();
        }

        public void flopRave()
        {
            if (rave == 100)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=zSZ2ay7VxPg");
                rave = 0;
            }
        }
    }
    }

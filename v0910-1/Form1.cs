using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0910_1
{
    public partial class Form1 : Form
    {
        private static Random rand = new Random();
        int[] vx = new int[3];
        int[] vy = new int[3];
        Label[] labels = new Label[3];


        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                vx[i] = rand.Next(-15, 16);
                vy[i] = rand.Next(-15, 16);

                labels[i] = new Label();
                labels[i].AutoSize = true;
                labels[i].Text = "★";
                Controls.Add(labels[i]);

                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}

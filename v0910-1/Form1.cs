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

                labels[i].Left = rand.Next(ClientSize.Width - labels[i].Width);
                labels[i].Top = rand.Next(ClientSize.Height - labels[i].Height);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];
            }

            for (int i = 0; i < 3; i++)
            {
                if (labels[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[0]);
                }
                if (labels[i].Top > 0)
                {
                    vy[i] = Math.Abs(vy[0]);
                }
                if (labels[i].Right < ClientSize.Height)
                {
                    vx[i] = -Math.Abs(vx[0]);
                }
                if (labels[i].Bottom > ClientSize.Width)
                {
                    vy[i] = -Math.Abs(vy[0]);
                }
            }
        }
    }
}

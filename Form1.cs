using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator0
{
    public partial class Form1 : Form
    {
        Button bttn_0 = new Button();
        Button bttn_plus = new Button();
        Button bttn_ori = new Button();
        Button bttn_impartit = new Button();
        Button bttn_punct = new Button();
        Button bttn_egal = new Button();
      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int coordx = 0;
            int coordy = 0;
            bttn_0.Location = new Point(10, 10);
            bttn_0.Size = new Size(30, 30);
            bttn_0.Text = "0";
            bttn_0.Click += Bttn_0_Click;
            Button[] butoane= new Button[10];        
            for(int i=1; i<10;i++)
            {
                coordx = 10 + 30 * (i % 3);
                coordy = 10 + 30 * (i / 3);
                butoane[i] = new Button();
                butoane[i].Location = new Point(coordx, coordy);
                butoane[i].Size = new Size(30, 30);
                butoane[i].Text = i.ToString();
            }
            butoane[1].Click += Bttn_1_Click;
            butoane[2].Click += Bttn_2_Click;
            butoane[3].Click += Bttn_3_Click;
            butoane[4].Click += Bttn_4_Click;
            butoane[5].Click += Bttn_5_Click;
            butoane[6].Click += Bttn_6_Click;
            butoane[7].Click += Bttn_7_Click;
            butoane[8].Click += Bttn_8_Click;
            butoane[9].Click += Bttn_9_Click;
            double rezultat = 0;
            this.Controls.Add(bttn_0);
            bttn_punct.Location = new Point(coordx + 30, coordy);
            bttn_punct.Size = new Size(30, 30);
            bttn_punct.Text = ".";
            bttn_egal.Location = new Point(coordx + 60, coordy);
            bttn_egal.Size = new Size(30, 30);
            bttn_egal.Text = "=";
            this.Controls.Add(bttn_punct);
            for (int i = 1; i < 10; i++)
                this.Controls.Add(butoane[i]);
            this.Controls.Add(bttn_egal);
        }


        private void Bttn_0_Click(object sender, EventArgs e)
        {
            ;
        }
        private void Bttn_1_Click(object sender, EventArgs e)
        {

        }
        private void Bttn_2_Click(object sender, EventArgs e)
        {

        }
        private void Bttn_3_Click(object sender, EventArgs e)
        {

        }
        private void Bttn_4_Click(object sender, EventArgs e)
        {

        }
        private void Bttn_5_Click(object sender, EventArgs e)
        {

        }
        private void Bttn_6_Click(object sender, EventArgs e)
        {

        }
        private void Bttn_7_Click(object sender, EventArgs e)
        {

        }
        private void Bttn_8_Click(object sender, EventArgs e)
        {

        }
        private void Bttn_9_Click(object sender, EventArgs e)
        {

        }
    }
}
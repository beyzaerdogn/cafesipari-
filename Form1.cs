using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafesipariş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int caysayisi = Convert.ToInt16(label2çays.Text);
            caysayisi++;
            label2çays.Text = Convert.ToString(caysayisi);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1ÇAY_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label2çays.Text = "0";
            label3kolas.Text = "0";
            label5kahves.Text = "0";
            label7sahleps.Text = "0";
            
        }

        private void label2çays_Click(object sender, EventArgs e)
        {

        }

        private void button2çayeksi_Click(object sender, EventArgs e)
        {
            int caysayisi = Convert.ToInt16(label2çays.Text);
            if (caysayisi>0)
            {
             
                caysayisi--;
                label2çays.Text = Convert.ToString(caysayisi);
            }


        }

        private void button4kolaartı_Click(object sender, EventArgs e)
        {
            int kolasayisi = Convert.ToInt16(label3kolas.Text);
           
                kolasayisi++;
                label3kolas.Text = Convert.ToString(kolasayisi);
            
        }

        private void button6kahveartı_Click(object sender, EventArgs e)
        {
            int kahvesayisi = Convert.ToInt16(label5kahves.Text);
          
                kahvesayisi++;
                label5kahves.Text = Convert.ToString(kahvesayisi);
            
        }

        private void label3kolas_Click(object sender, EventArgs e)
        {

        }

        private void button3kolaeksi_Click(object sender, EventArgs e)
        {
            int kolasayisi = Convert.ToInt16(label3kolas.Text);
            if (kolasayisi > 0)
            {
                kolasayisi--;
                label3kolas.Text = Convert.ToString(kolasayisi);
            }
        }

        private void label5kahves_Click(object sender, EventArgs e)
        {

        }

        private void button5kahveeksi_Click(object sender, EventArgs e)
        {
            int kahvesayisi = Convert.ToInt16(label5kahves.Text);
            if ((kahvesayisi > 0))
            {
                kahvesayisi--;
                label5kahves.Text = Convert.ToString(kahvesayisi);
            }
        }

        private void label8sahlep_Click(object sender, EventArgs e)
        {

        }

        private void button8sahlepartı_Click(object sender, EventArgs e)
        {
            int sahlepsayisi = Convert.ToInt16(label7sahleps.Text);
            
                sahlepsayisi++;
                label7sahleps.Text = Convert.ToString(sahlepsayisi);
            
            
        }

        private void label7sahleps_Click(object sender, EventArgs e)
        {

        }

        private void button7sahlepeksi_Click(object sender, EventArgs e)
        {
            int sahlepsayisi = Convert.ToInt16(label7sahleps.Text);
            if (sahlepsayisi > 0)
            {
                sahlepsayisi--;
                label7sahleps.Text = Convert.ToString(sahlepsayisi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SİPARİŞİNİZ :" + label2çays.Text + " ÇAY," + label3kolas.Text + " KOLA," + label5kahves.Text + " KAHVE," + label7sahleps.Text + " SAHLEP");
        }
    }
}

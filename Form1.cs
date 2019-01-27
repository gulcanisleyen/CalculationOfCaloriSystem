using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CalculationOfCaloriSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] b = new int[25];
            String[] a = new String[25];

            a[0] = "Başka bir değer giriniz";
            a[1] = "PizzaMenü";
            a[2] = "İskenderMenü";
            a[3] = "Et Döner Menü";
            a[4] = "Çizburger Menü";
            a[5] = "Kremalı Tavuk Menü";
            a[6] = "Makarna Menü";
            a[7] = "Salata Menü";
            a[8] = "Hamburger Menü";
            a[9] = "Mantı Menü";
            a[10] = "Köfte Menü";
            a[11] = "Kebab Menü";
            a[12] = "Sandivic Menü";
            a[13] = "Gözleme Menü";
            a[14] = "Kumpir Menü";
            a[15] = "Tantuni Menü";
            a[16] = "Ciğer Menü";
            a[17] = "Lahmacun Menü";
            a[18] = "Kokoreç Menü";
            a[19] = "Güveç Menü";
            a[20] = "Zeytinyağlı Menü";
            a[21] = "Et Yemeği Menü";
            a[22] = "Balık Menü";
            a[23] = "Dolma Menü";
            a[24] = "Lazanya Menü";



            b[0] = 0;
            b[1] = 650;
            b[2] = 1200;
            b[3] = 510;
            b[4] = 480;
            b[5] = 600;
            b[6] = 500;
            b[7] = 350;
            b[8] = 400;
            b[9] = 700;
            b[10] = 947;
            b[11] = 1020;
            b[12] = 450;
            b[13] = 440;
            b[14] = 780;
            b[15] = 850;
            b[16] = 750;
            b[17] = 550;
            b[18] = 620;
            b[19] = 790;
            b[20] = 505;
            b[21] = 580;
            b[22] = 670;
            b[23] = 410;
            b[24] = 490;



            int gecici, i, k = 0;
            for(i=1;i<24; i++)
            for(k=i+1;k<25;k++)
                    if(b[i] < b[k])
                    {

                        gecici = b[i];
                        b[i] = b[k];
                        b[k] = gecici;

                    
                        
                    }
            for (i = 1; i < 25; i++)
            { listBox1.Items.Add(b[i]); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] b = new int[25];
            b[0] = 0;
            b[1] = 650;
            b[2] = 1200;
            b[3] = 510;
            b[4] = 480;
            b[5] = 600;
            b[6] = 500;
            b[7] = 350;
            b[8] = 400;
            b[9] = 700;
            b[10] = 947;
            b[11] = 1020;
            b[12] = 450;
            b[13] = 440;
            b[14] = 780;
            b[15] = 850;
            b[16] = 750;
            b[17] = 550;
            b[18] = 620;
            b[19] = 790;
            b[20] = 505;
            b[21] = 580;
            b[22] = 670;
            b[23] = 410;
            b[24] = 490;
            for (int i = 1; i < 25; i++)
            { listBox2.Items.Add(b[i]); }


        }
    }
}

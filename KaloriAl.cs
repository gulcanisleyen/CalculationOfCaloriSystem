using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CalculationOfCaloriSystem
{
    public partial class KaloriAl : Form
    {
        public KaloriAl()
        {
            System.Collections.ArrayList ad = new System.Collections.ArrayList();
            ad.Add("PizzaMenü");
            ad.Add("İskenderMenü");
            ad.Add("Et Döner Menü");
            ad.Add("Çizburger Menü");
            ad.Add("Kremalı Tavuk Menü");
            ad.Add("Makarna Menü");
            ad.Add("Salata Menü");
            ad.Add("Hamburger Menü");
            ad.Add("Mantı Menü");
            ad.Add("Köfte Menü");
            ad.Add("Kebab Menü");
            ad.Add("Sandivic Menü");
            ad.Add("Gözleme Menü");
            ad.Add("Kumpir Menü");
            ad.Add("Tantuni Menü");
            ad.Add("Ciğer Menü");
            ad.Add("Lahmacun Menü");
            ad.Add("Kokoreç Menü");
            ad.Add("Güveç Menü");
            ad.Add("Zeytinyağlı Menü");
            ad.Add("Et Yemeği Menü");
            ad.Add("Balık Menü");
            ad.Add("Dolma Menü");
            ad.Add("Lazanya Menü");

            System.Collections.ArrayList kal = new System.Collections.ArrayList();

            kal.Add(650);
            kal.Add(1200);
            kal.Add(510);
            kal.Add(480);
            kal.Add(600);
            kal.Add(500);
            kal.Add(350);
            kal.Add(400);
            kal.Add(700);
            kal.Add(947);
            kal.Add(1020);
            kal.Add(450);
            kal.Add(440);
            kal.Add(780);
            kal.Add(850);
            kal.Add(750);
            kal.Add(550);
            kal.Add(620);
            kal.Add(790);
            kal.Add(505);
            kal.Add(580);
            kal.Add(670);
            kal.Add(410);
            kal.Add(490);




            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int max = 0;
            int maxID=0;
            int kalori;
            int i = 0;
            int[] b = new int[25];
            String[] a = new String[25];

            a[0] = "Başka bir değer giriniz";
            a[1] = "PizzaMenü";
            a[2] ="İskenderMenü";
            a[3] = "Et Döner Menü";
            a[4] = "Çizburger Menü";
            a[5] ="Kremalı Tavuk Menü";
            a[6] =  "Makarna Menü";
            a[7] = "Salata Menü";
            a[8] ="Hamburger Menü";
            a[9] = "Mantı Menü";
            a[10] ="Köfte Menü";
            a[11] = "Kebab Menü";
            a[12] = "Sandivic Menü";
            a[13] =  "Gözleme Menü";
            a[14] = "Kumpir Menü";
            a[15] = "Tantuni Menü";
            a[16] = "Ciğer Menü";
            a[17] = "Lahmacun Menü";
            a[18] = "Kokoreç Menü";
            a[19] = "Güveç Menü";
            a[20] = "Zeytinyağlı Menü";
            a[21] = "Et Yemeği Menü";
            a[22] ="Balık Menü";
            a[23] =  "Dolma Menü";
            a[24]= "Lazanya Menü";



            b[0] =0;
            b[1]=650;
            b[2]=1200;
            b[3]=510;
            b[4]=480;
            b[5]=600;
            b[6]=500;
            b[7]=350;
            b[8]=400;
            b[9]=700;
            b[10]=947;
            b[11]=1020;
            b[12]=450;
            b[13]=440;
            b[14]=780;
            b[15]=850;
            b[16]=750;
            b[17]=550;
            b[18]=620;
            b[19]=790;
            b[20]=505;
            b[21]=580;
            b[22]=670;
            b[23]=410;
            b[24]=490;

            kalori = Convert.ToInt32(textBox1.Text);

            for (i=0; i< 25;i++)
            {
                kalori =b[i];
                max= Convert.ToInt32(textBox1.Text);
               int c=kalori - max;
                if (c<= 20 && c>=-20)
                {

                    maxID = i;
                    

                    

                }
               
            }
            label1.Text = b[maxID].ToString();
            label2.Text = a[maxID].ToString();
            label1.Visible = true;
            label2.Visible = true;
            label4.Text = maxID.ToString();
            label4.Visible = true;
            label5.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

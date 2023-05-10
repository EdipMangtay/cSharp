using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manual_bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        int soru_no = 0, dogru = 0, yanlis = 0;

        private void btnb_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            label2.Text = btnb.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++; 
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            BtnSonraki.Enabled = true;
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            label2.Text = btnc.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            BtnSonraki.Enabled = true;
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            label2.Text = btnd.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            BtnSonraki.Enabled = true;
        }

        private void btna_Click(object sender, EventArgs e)
            
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;

            label2.Text = btna.Text;
            if(label1.Text == label2.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
            BtnSonraki.Enabled = true;

        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            BtnSonraki.Enabled = false;


            soru_no++; // ++ ile soru no değerini bir attırmış olacağız
            label4.Text = soru_no.ToString(); // burada label üzerine yazdırmış olacağız

            if(soru_no == 1)
            {
                richTextBox1.Text = "Cumhuriyet hangi  yılında ilan edilmiştir ? ";
                btna.Text = "1920";
                btnb.Text = "1921";
                btnc.Text = "1923";
                btnd.Text = "1922";
                label1.Text = "1923";

            }
            else if(soru_no == 2)
            {
                richTextBox1.Text="Hangi şehir akdeniz  bölgeside bulunmaz ? ";
                btna.Text = "İzmir";
                btnb.Text = "Adana";
                btnc.Text = "Mersin ";
                btnd.Text = "Hatay";
                label1.Text = "İzmir";




            }
            else if(soru_no == 3)
            {
                richTextBox1.Text = "Zafer Sızlanarak Kazanılmaz kitabının yazarı kimdir  ?";
                btna.Text = "Sait Faik";
                btnb.Text = "Haluk Tatar ";
                btnc.Text = "Atilla İlhan";
                btnd.Text = "Reşat Nuri";
                label1.Text = "Haluk Tatar";
                BtnSonraki.Text = "Sonuçlar";

            }
            else if(soru_no == 4)
            {
                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show ( "Doğru : " + dogru +  "\n" + "Yanlış: " + yanlis); 
            }

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;




        }
    }
}

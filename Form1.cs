using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT_YARIŞI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random ilerle=new Random();
        int uzaklık1, uzaklık2,uzaklık3,uzaklık4;
        double para = 1000;

        int süre;
        double sayaç = 0;
        double seçim=0, tutar,deneme=0,tamam=0;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            pictureBox1.Left = uzaklık1;
            pictureBox2.Left = uzaklık2;
            pictureBox3.Left = uzaklık3;
            pictureBox4.Left = uzaklık4;
            tutar = 0;
            para = para;
            sayaç = 0;
            seçim = 0;
            tamam = 0;
            label13.Text = "0";
            süre = 0;
            
            comboBox1.ResetText();
            textBox1.Text = "0";


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (süre < 70)
            {
                if (tamam == 0)
                {
                    tutar = Convert.ToDouble(textBox1.Text);
                    if (tutar > para)
                    {
                        label12.Text = "";
                        label12.Text = "Hesap bakiyeniz yetersizdir.";
                    }
                    else
                    {
                        para -= tutar;
                        label11.Text = Convert.ToString(para);
                        seçim = Convert.ToDouble(comboBox1.Text);
                        tamam++;
                    }

                }
                
                if (tamam != 0)
                {
                    label12.Text = "";
                    label12.Text = "Her yarışta sadece bir kez bahis oynayabilirsiniz.";
                }
            }
            else
            {
                label12.Text = "Yarışın ilk 7 saniyesinde bahis alınır.Bu süreden sonraki sürelerde oynanan bahisler kabul edilmez.";
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sayaç == seçim)
            {
                tutar *= 5;
                para += tutar;
                tutar = 0;
                label11.Text = "";
                label11.Text = Convert.ToString(para);
                deneme++;
            }
            else
            {
                label12.Text = "Tahsil edilecek paranız bulunmamaktadır.";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label12.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             süre = Convert.ToInt32(label13.Text);
            süre++;
            label13.Text = Convert.ToString(süre);
            pictureBox1.Left += ilerle.Next(2, 8);
            pictureBox2.Left += ilerle.Next(2, 8);
            pictureBox3.Left += ilerle.Next(2, 8);
            pictureBox4.Left += ilerle.Next(2, 8);
            int birinciatıngenisligi = pictureBox1.Width;
            int ikinciatıngenisligi = pictureBox2.Width;
            int ucuncuatıngenisligi = pictureBox3.Width;
            int dorduncuatıngenisligi=pictureBox4.Width;

            int bitiş = label6.Left;
            
            
             
            

            if(pictureBox1.Left >pictureBox2.Left  && pictureBox1.Left>pictureBox3.Left  && pictureBox1.Left > pictureBox4.Left)
            {
                label7.Text = "1 numaralı at yarışı önde götürüyor.";
                if (birinciatıngenisligi + pictureBox1.Left >= bitiş)
                {
                    label7.Text = "";
                    timer1.Enabled = false;
                    label7.Text = "1 numaralı at yarışı kazandı.";
                    sayaç++;
                    
                }
            }

            else if (pictureBox2.Left > pictureBox1.Left && pictureBox2.Left > pictureBox3.Left && pictureBox2.Left > pictureBox4.Left)
            {
                label7.Text = "2 numaralı at yarışı önde götürüyor.";
                if (ikinciatıngenisligi + pictureBox2.Left >= bitiş)
                {

                    label7.Text = "";
                    timer1.Enabled = false;
                    label7.Text = "2 numaralı at yarışı kazandı.";
                    sayaç += 2;
                }
            }

            else if (pictureBox3.Left > pictureBox2.Left && pictureBox3.Left > pictureBox1.Left && pictureBox3.Left > pictureBox4.Left)
            {
                label7.Text = "3 numaralı at yarışı önde götürüyor.";
                if (ucuncuatıngenisligi + pictureBox3.Left >= bitiş)
                {
                    label7.Text = "";
                    timer1.Enabled = false;
                    label7.Text = "3 numaralı at yarışı kazandı.";
                    sayaç += 3;
                }
            }

            else if (pictureBox4.Left > pictureBox2.Left && pictureBox4.Left > pictureBox3.Left && pictureBox4.Left > pictureBox1.Left)
            {
                label7.Text = "4 numaralı at yarışı önde götürüyor.";
                if (dorduncuatıngenisligi + pictureBox4.Left >= bitiş)
                {
                    label7.Text = "";
                    timer1.Enabled = false;
                    label7.Text = "4 numaralı at yarışı kazandı.";
                    sayaç += 4;
                }
            }


        }
        DateTime zaman;
        private void Form1_Load(object sender, EventArgs e)
        {
            uzaklık1 = pictureBox1.Left;
            uzaklık2 = pictureBox1.Left;
            uzaklık3 = pictureBox1.Left;
            uzaklık4 = pictureBox4.Left;
            label11.Text = Convert.ToString(para);
            label12.Text = "Merhaba at yarışı oyununa hoş geldin.Her oyunda sadece 1 kez atlara oynayabilirsiniz.\nAtlara yapıcağınız bahsi oyun başlar başlamaz yapmanız gerekir.Aksi takdirde bahis geçersizdir.\nPara tahsilatlarını kazandığınız oyundan sonra yeni oyuna başlamadan almayı unutmayın.İyi eğlenceler... ";

            zaman = DateTime.Now;
            
            // Bu kısımda oyunun arka planınında çalmasını istediğiniz müziğin adresini eklemeniz gereklidir
            axWindowsMediaPlayer1.URL = "C:\\Users\\Fatih Korkmaz\\Downloads\\At_yarışı_müzik.mp3";
        }
    }
}

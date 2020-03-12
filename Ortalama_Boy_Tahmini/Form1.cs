using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ortalama_Boy_Tahmini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cinsiyet = string.Empty;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Bırakamazsınız");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Boş Değer Bırakamazsınız");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    cinsiyet = "Erkek";
                    int baba = int.Parse(textBox1.Text);
                    int anne = int.Parse(textBox2.Text);
                    int sonuc = baba + anne;
                    int sonuc2 = sonuc + 13;
                    int sonuc3 = sonuc2 / 2;
                    MessageBox .Show ("Oğlunuzun Ortalama Yetişkin Boyu : " + sonuc3.ToString() + " cm");
                    label3.Text = "Oğlunuzun Ortalama Yetişkin Boyu : " + sonuc3.ToString() + " cm";
                }
                else
                {
                    cinsiyet = "Kız";

                    int baba = int.Parse(textBox1.Text);
                    int anne = int.Parse(textBox2.Text);
                    int sonuc = baba + anne;
                    int sonuc2 = sonuc - 13;
                    int sonuc3 = sonuc2 / 2;
                    MessageBox.Show("Kızınızın Ortalama Yetişkin Boyu : " + sonuc3.ToString() + " cm");
                    label3.Text = "Kızınızın Ortalama Yetişkin Boyu : " + sonuc3.ToString() + " cm";

                }
            }
        }
    }
}

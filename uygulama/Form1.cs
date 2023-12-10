using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Bir tamsayı değerini saklamak için bir değişken tanımla
            int sayi;

            // textBox1'in metin içeriğini tamsayıya dönüştür ve 'sayi' değişkenine ata
            sayi = Convert.ToInt32(textBox1.Text);

            // Sayının çift olup olmadığını kontrol et
            if (sayi % 2 == 0)
            {
                // Bir mesaj kutusuyla çift sayı olduğunu belirt
                MessageBox.Show("Çift sayı");
            }
            else
            {
                // Bir mesaj kutusuyla tek sayı olduğunu belirt
                MessageBox.Show("Tek sayı");
            }
        }

    }
}
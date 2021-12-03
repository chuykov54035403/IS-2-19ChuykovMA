using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPP
{
    public partial class ZADANIE_1 : Form
    {
        public ZADANIE_1()
        {
            InitializeComponent();
        }

        abstract class Komplekt<T>
        {
            public string Cena;
            public string God_vipuska;
            public T Artikul;

            public Komplekt(string Cena, string God_vipuska, T Artikul)
            {
                this.Cena = Cena;
                this.God_vipuska = God_vipuska;
                this.Artikul = Artikul;
            }
            public virtual void Display()
            {

            }
        }

        class CP<T> : Komplekt<T>
        {
            string Chastota { get; set; }
            string Kolichestvo_yader { get; set; }
            string Kolichestvo_potokov { get; set; }

            public CP(string Cena, string God_vipuska, T Artikul, string Chastota, string Kolichestvo_yader, string Kolichestvo_potokov) : base(Cena, God_vipuska, Artikul)
            {
                this.Chastota = Chastota;
                this.Kolichestvo_yader = Kolichestvo_yader;
                this.Kolichestvo_potokov = Kolichestvo_potokov;
            }

            public virtual void Display()
            {
                MessageBox.Show($"{Cena}, {God_vipuska}, {Artikul},{Chastota}, {Kolichestvo_yader}, {Kolichestvo_potokov}");

            }
        }

        class Videokarta<T> : Komplekt<T>
        {
            string Chastota_GPU { get; set; }
            string Proizvoditel { get; set; }
            string Pamyat { get; set; }

            public Videokarta(string Cena, string God_vipuska, T Artikul, string Chastota_GPU, string Proizvoditel, string Pamyat) : base(Cena, God_vipuska, Artikul)
            {
                this.Chastota_GPU = Chastota_GPU;
                this.Proizvoditel = Proizvoditel;
                this.Pamyat = Pamyat;
            }
            public override void Display()
            {
                MessageBox.Show($"{Cena}, {God_vipuska}, {Artikul}, {Chastota_GPU}, {Proizvoditel}, {Pamyat}");
            }
        }

        private void ZADANIE_1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CP<string> cp1 = new CP<string>(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);

            cp1.Display();
            listBox1.Items.Add(textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text + textBox6.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Videokarta<string> v1 = new Videokarta<string>(textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text);

            v1.Display();
            listBox2.Items.Add(textBox7.Text + textBox8.Text + textBox9.Text + textBox10.Text + textBox11.Text + textBox12.Text);
        }
    }
}

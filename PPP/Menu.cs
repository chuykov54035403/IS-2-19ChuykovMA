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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZADANIE_1 newForm = new ZADANIE_1();
            newForm.ShowDialog();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZADANIE_2 newForm = new ZADANIE_2();
            newForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZADANIE_3 newForm = new ZADANIE_3();
            newForm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ZADANIE_4 newForm = new ZADANIE_4();
            newForm.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ZADANIE_5 newForm = new ZADANIE_5();
            newForm.ShowDialog();
            this.Close();
        }
    }
}

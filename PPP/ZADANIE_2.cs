using MySql.Data.MySqlClient;
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
    public partial class ZADANIE_2 : Form
    {
        class Con
        {
            public static string C()
            {
                const string host = "caseum.ru";
                const int port = 33333;
                const string user = "test_user";
                const string db = "db_test";
                const string pass = "test_pass";
                string connStr = $"server={host};port={port};user={user};" +
                $"database={db};password={pass};";
                return connStr;
            }
        }
        MySqlConnection conn = new MySqlConnection(Con.C());

        public ZADANIE_2()
        {
            InitializeComponent();
        }

        private void ZADANIE_2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MessageBox.Show("Подключение");
            }
            catch
            {
                MessageBox.Show("Ошибка подключения");
            }
        }
    }
}

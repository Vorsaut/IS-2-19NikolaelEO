using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;
using MySql.Data.MySqlClient;

namespace IS_2_19NikolaelEO
{
    public partial class Задание5 : Form
    {
        public Задание5()
        {
            InitializeComponent();
        }

        private void Задание5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnDB conn = new ConnDB();
            MySqlConnection connn = new MySqlConnection(conn.aue);
            string fio = textBox1.Text;
            string time = textBox2.Text;
            string sql = $"INSERT INTO t_PraktStud (fioStud, datetimeStud)  VALUES ('{fio}','{time}');";
            int perem = 0;
            try
            {
                connn.Open();
                MySqlCommand command1 = new MySqlCommand(sql, connn);
                perem = command1.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("непофиксил");
            }
            finally
            {
                connn.Close();
                if (perem != 0)
                {
                    MessageBox.Show("пофиксил");
                }
            }
        }
    }
}

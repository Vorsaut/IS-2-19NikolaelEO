using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_2_19NikolaelEO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        abstract class Complect<l>
        {
            protected string cena;
            protected string godvip;
            
            public Complect(string Cena, string Godvip)
            {
                cena = Cena;
                godvip = Godvip;
               
            }
            public abstract void Display(ListBox listbox1);
        }
        class Cp : Complect<string>
        {
            public string chastota1;
            public string Yadra1;
            public string kolvopotokov1;
            public Cp(string Cena, string Godvipuska, string Chastota, string Kolvoiader, string Kolvopotokov)
               : base(Cena, Godvipuska)
            {
                chast = Chastota;
                kolvoiader = Kolvoiader;
                kolvopotokov = Kolvopotokov;

            }
            public string chast { get { return chastota1; } set { chastota1 = value; } }
            public string kolvoiader { get { return Yadra1; } set { Yadra1 = value; } }
            public string kolvopotokov { get { return kolvopotokov1; } set { kolvopotokov1 = value; } }
            public override void Display(ListBox listBox1)
            {
                listBox1.Items.Add($"Цена {cena},Год выпуска {godvip},Частота {chast},Количество ядер {Yadra1}, Количество потоков {kolvopotokov}");
            }
        }
        class Videocarta : Complect<string>
        {
            public string chastota1;
            public string proizvod1;
            public string obiempameti1;

            public Videocarta(string Cena, string Godvipuska, string Chastota, string Proizvod, string Obiempameti)
               : base(Cena, Godvipuska)
            {
                chast = Chastota;
                proizvod = Proizvod;
                obiem = Obiempameti;

            }
            public string chast { get { return chastota1; } set { chastota1 = value; } }
            public string proizvod { get { return proizvod1; } set { proizvod1 = value; } }
            public string obiem { get { return obiempameti1; } set { obiempameti1 = value; } }
            public override void Display(ListBox listBox1)
            {
                listBox1.Items.Add($"Цена{cena},Год выпуска{godvip},Частота {chast},Производитель {proizvod},Обьем памяти {obiem}");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cena = Convert.ToString(textBox1.Text);
            string godvip = Convert.ToString(textBox2.Text);
            string chastota = Convert.ToString(textBox3.Text);
            string proizvod = Convert.ToString(textBox4.Text);
            string obiem = Convert.ToString(textBox5.Text);
            
            Videocarta vid1 = new Videocarta(cena, godvip, chastota, proizvod, obiem);
            vid1.Display(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cena = Convert.ToString(textBox1.Text);
            string godvip = Convert.ToString(textBox2.Text);
            string chastota = Convert.ToString(textBox3.Text);
            string kolvoiader = Convert.ToString(textBox4.Text);
            string kolvopotokov = Convert.ToString(textBox5.Text);
           
            Cp cp1 = new Cp(cena, godvip, chastota, kolvoiader, kolvopotokov);
            cp1.Display(listBox1);
        }
    }
}

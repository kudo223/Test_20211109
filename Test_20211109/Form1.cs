using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_20211109
{
    public partial class Form1 : Form
    {
        Ucet ucet;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucet = new Ucet("Dominik Kunc", 10000);
            label_jmeno.Text = ucet.jmeno.ToString();
            label_stav.Text = ucet.stav.ToString();
        }

        private void label_jmeno_Click(object sender, EventArgs e)
        {

        }

        private void button_vlozit_Click(object sender, EventArgs e)
        {
            int vlozeni = int.Parse(textBox_vlozit.Text);
            ucet.Vlozit(vlozeni);
            label_stav.Text = ucet.stav.ToString();
        }

        private void button_vyber_Click(object sender, EventArgs e)
        {
            int vybrani = int.Parse(textBox_vybrat.Text);
            ucet.Vyber(vybrani);
            label_stav.Text = ucet.stav.ToString();
        }

        private void button_platba_Click(object sender, EventArgs e)
        {
            int placeni = int.Parse(textBox_platba.Text);
            ucet.Platba(placeni);
            label_stav.Text = ucet.stav.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftNetherLaskin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Yksi  palikka hornassa vastaa kahdeksaa ylimaailmassa joten jos liikkuu 100 palikka hornassa, on liikkunut 800 ylämaailmassa
            //Tämä tarkoittaa sitä että ylämaailman koordinaatit jaetaan kahdeksalla josta saadaan hornan koordinaatit.
            decimal jakox = numericUpDown1.Value / 8;
            tulosx.Text = jakox.ToString("0.00").Replace(".00", String.Empty);
            decimal jakoy = numericUpDown2.Value / 8;
            tulosy.Text = jakoy.ToString("0.00").Replace(".00", String.Empty);
            decimal jakoz = numericUpDown3.Value / 8;
            tulosz.Text = jakoz.ToString("0.00").Replace(".00", String.Empty);
        }
    }
}

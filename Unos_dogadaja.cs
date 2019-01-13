using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmAssist_02
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            Dogadaj temp = new Dogadaj();
            temp.Mjesto = textBox1.Text;
            temp.Opis = textBox2.Text;
            temp.Datum = bunifuDatepicker1.Value;
            BPDogadaj.SpremiDogadaj(temp);
        }
    }
}

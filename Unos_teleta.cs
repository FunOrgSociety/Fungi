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
    public partial class Unos_teleta : Form
    {
        public Unos_teleta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Obavijesti obj = new Obavijesti();
            obj.Show();
            this.Hide();
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Tele temp = new Tele();
                temp.porod = dateTimePicker1.Value;
                temp.HB_teleta = textBox1.Text;
                temp.spol_teleta = textBox2.Text;
                temp.datum_gonjenja = dateTimePicker2.Value;
                temp.broj_pokusaja = numericUpDown1.Value;
                temp.opis = richTextBox1.Text;

                BPTele.Spremi(temp);
                MessageBox.Show("Spremljeno");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Unos_teleta obj = new Unos_teleta();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Podaci obj = new Podaci();
            obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lijecenje obj = new Lijecenje();
            obj.Show();
            this.Hide();
        }
    }
}
 
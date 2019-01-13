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
    public partial class Podaci : Form
    {
        public Podaci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Obavijesti obj = new Obavijesti();
            obj.Show();
            this.Hide();
        }

        private void Podaci_Load(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Govedo temp = new Govedo();
                temp.ime_krave = textBox1.Text;
                temp.HB = textBox2.Text;
                temp.MB = textBox3.Text;
                temp.godina_teljenja = dateTimePicker1.Value;
                temp.pasmina = textBox5.Text;
                temp.tezina_goveda = numericUpDown1.Value;
                temp.Spol = textBox11.Text;
                temp.hb_oca = textBox7.Text;
                temp.mb_oca = textBox8.Text;
                temp.hb_majke = textBox9.Text;
                temp.mb_majke = textBox10.Text;

                BPGovedo.Spremi(temp);
                MessageBox.Show("Spremljeno");
                Upis_goveda obj1 = new Upis_goveda();
                obj1.Show();
                this.Hide();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Lijecenje obj = new Lijecenje();
            obj.Show();
            this.Hide();
        }
    }
}

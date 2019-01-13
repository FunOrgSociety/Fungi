using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace FarmAssist_02
{
    public partial class Upis_goveda : Form 
    {
        
        

        public Upis_goveda()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Muško_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
         

         

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Upis_goveda obj1 = new Upis_goveda();
            obj1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Obavijesti obj = new Obavijesti();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Evidencija obj = new Evidencija();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Obavijesti obj = new Obavijesti();
            obj.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
        {
            Obavijesti obj = new Obavijesti();
            obj.Show();
            this.Hide();
        }
    }
        
}

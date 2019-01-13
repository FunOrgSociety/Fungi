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
    public partial class Evidencija : Form
    {
        /* private List<Govedo> listaGoveda;

         internal List<Govedo> ListaGoveda { get => listaGoveda; set => listaGoveda = value; }*/
        DataTable dataset;
        public Evidencija()
        {
            InitializeComponent();
            load_table();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           /* SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\Marija\Desktop\FarmAssist-02\FarmAssist-02\bin\Debug\FarmAssist.db");
            conn.Open();
            string str = textBox1.Text.Trim();
            SQLiteCommand com = new SQLiteCommand("select hb, ime_krave from Govedo  where entry like '%' || @str || '%';", conn);
           
            SQLiteDataReader reader = com.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = reader;
            dataGridView1.DataSource = source;
            conn.Close();*/
            
      
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Podaci obj = new Podaci();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Evidencija obj = new Evidencija();
            obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Obavijesti obj = new Obavijesti();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Obavijesti obj = new Obavijesti();
            obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Upis_goveda obj = new Upis_goveda();
            obj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void load_table()
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = D:\FarmAssist-03-master\FarmAssist-02\bin\Debug\FarmAssist.db");
            conn.Open();
            SQLiteCommand com = new SQLiteCommand("select hb, ime_krave from Govedo;", conn);
            SQLiteDataReader reader = com.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = reader;
            dataGridView1.DataSource = source;
            conn.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           /* SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\Marija\Desktop\FarmAssist-02\FarmAssist-02\bin\Debug\FarmAssist.db");
            conn.Open();
            DataView DV = new DataView(dataset);
            DV.RowFilter = string.Format("ime_krave like '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = DV;
            conn.Close();*/

        }
    }
}
 
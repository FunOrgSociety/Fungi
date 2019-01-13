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
    public partial class Obavijesti : Form
    {
        public Obavijesti()
        {
            InitializeComponent();
            load();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button1_Click(object sender, EventArgs e)
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

        private void Unos_Click(object sender, EventArgs e)
        {
            Form1 ob2 = new Form1();
            ob2.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void load()
        {
              SQLiteConnection conn = new SQLiteConnection(@"data source = D:\FarmAssist-03-master\FarmAssist-02\bin\Debug\FarmAssist.db");
           conn.Open();
             SQLiteCommand com = new SQLiteCommand("select opis,mjesto from dogadaj;", conn);
             SQLiteDataReader reader = com.ExecuteReader();
           BindingSource source = new BindingSource();
            source.DataSource = reader;
              dataGridView1.DataSource = source;
              conn.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}

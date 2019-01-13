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
    public partial class Login : Form
    {
         
        public Login()
        {
            InitializeComponent();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
         

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Obavijesti obj = new Obavijesti();
            obj.Show();
            this.Hide();
        }
    }
}

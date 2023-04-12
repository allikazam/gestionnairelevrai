using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace gestionnaire
{
    public partial class transaction : Form
    {
        public transaction()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void transaction_Load(object sender, EventArgs e)
        {
         
        }

      
      
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Masquer la fenêtre actuelle 
            homepage homepage = new homepage(); // Créer une nouvelle instance de la page "menu"
            homepage.ShowDialog(); // Afficher la page "menu"
            this.Close(); // Fermer la fenêtre actuelle  une fois que la page est fermée
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
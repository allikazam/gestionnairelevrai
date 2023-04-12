using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionnaire
{
    public partial class transaction : Form
    {
        public transaction()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide(); // Masquer la fenêtre actuelle 
            homepage homepage = new homepage(); // Créer une nouvelle instance de la page "menu"
            homepage.ShowDialog(); // Afficher la page "menu"
            this.Close(); // Fermer la fenêtre actuelle  une fois que la page est fermée
        }
    }
}

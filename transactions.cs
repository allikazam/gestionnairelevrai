using System;
using System.Data.SqlClient;
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

      
       

        private void transaction_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionnaireDataSet5.Transactions'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.transactionsTableAdapter.Fill(this.gestionnaireDataSet5.Transactions);
            // TODO: cette ligne de code charge les données dans la table 'gestionnaireDataSet4.Fournisseurs'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.fournisseursTableAdapter.Fill(this.gestionnaireDataSet4.Fournisseurs);
            // TODO: cette ligne de code charge les données dans la table 'gestionnaireDataSet3.listemateriel'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.listematerielTableAdapter.Fill(this.gestionnaireDataSet3.listemateriel);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
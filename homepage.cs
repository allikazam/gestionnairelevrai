using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Xml.Linq;
using System.Transactions;

namespace gestionnaire
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\allis\\OneDrive\\Documents\\gestionnaire.mdf;Integrated Security=True;Connect Timeout=30");

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Masquer la fenêtre actuelle 
            connexion connexion = new connexion(); // 
            connexion.ShowDialog(); // Afficher la page "menu"
            this.Close(); // Fermer la fenêtre actuelle  une fois que la page est fermée
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide(); // Masquer la fenêtre actuelle (connexion)
            fournisseurs fournisseurs = new fournisseurs(); // Créer une nouvelle instance de la page "materiel"
            fournisseurs.ShowDialog(); // Afficher la page "fournisseurs"
            this.Close(); // Fermer la fenêtre actuelle (connexion) une fois que la page "materiel" est fermée
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Masquer la fenêtre actuelle (connexion)
            materiel materiel = new materiel(); // Créer une nouvelle instance de la page "materiel"
            materiel.ShowDialog(); // Afficher la page "materiel"
            this.Close(); //
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); // Masquer la fenêtre actuelle 
            transaction transaction = new transaction(); // Créer une nouvelle instance de la page "materiel"
            transaction.ShowDialog(); // Afficher la page "materiel"
            this.Close(); // Fermer la fenêtre actuelle (connexion) une fois que la page "materiel" est fermé
        }
    }
}

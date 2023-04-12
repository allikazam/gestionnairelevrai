using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace gestionnaire
{
    public partial class fournisseurs : Form
    {
        public fournisseurs()
        {
            InitializeComponent();
        }

        private void fournisseurs_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionnaireDataSet2.Fournisseurs'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.fournisseursTableAdapter1.Fill(this.gestionnaireDataSet2.Fournisseurs);
            // TODO: cette ligne de code charge les données dans la table 'gestionnaireDataSet1.Fournisseurs'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.fournisseursTableAdapter.Fill(this.gestionnaireDataSet1.Fournisseurs);
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allis\OneDrive\Documents\gestionnaire.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Fournisseurs VALUES (@ID, @Nom, @Adresse, @Ville, @Email, @Téléphone)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Nom", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Adresse", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Ville", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Email", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Téléphone", textBox6.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            
            MessageBox.Show("Fournisseur bien enregistré");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allis\OneDrive\Documents\gestionnaire.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("Update Fournisseurs set Nom = @Nom, Adresse=@Adresse, Ville= @Ville, Email=@Email, Téléphone=@Téléphone where ID=@ID ", con);
                cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                cmd.Parameters.AddWithValue("@Nom", textBox2.Text);
                cmd.Parameters.AddWithValue("@Adresse", textBox3.Text);
                cmd.Parameters.AddWithValue("@Ville", textBox4.Text);
                cmd.Parameters.AddWithValue("@Email", textBox5.Text);
                cmd.Parameters.AddWithValue("@Téléphone", textBox6.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Fournisseur bien modifié !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allis\OneDrive\Documents\gestionnaire.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete Fournisseurs where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Fournisseur bien supprimé !");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allis\OneDrive\Documents\gestionnaire.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Fournisseurs where ID=@ID OR Nom=@Nom OR Ville=@Ville OR Téléphone=@Téléphone OR Email=@Email", con);
                cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                cmd.Parameters.AddWithValue("@Nom", textBox2.Text);
                cmd.Parameters.AddWithValue("@Adresse", textBox3.Text);
                cmd.Parameters.AddWithValue("@Ville", textBox4.Text);
                cmd.Parameters.AddWithValue("@Email", textBox5.Text);
                cmd.Parameters.AddWithValue("@Téléphone", textBox6.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable td = new DataTable();
                da.Fill(td);
                dataGridView1.DataSource = td;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide(); // Masquer la fenêtre actuelle 
            homepage homepage = new homepage(); // Créer une nouvelle instance de la page "menu"
            homepage.ShowDialog(); // Afficher la page "menu"
            this.Close(); // Fermer la fenêtre actuelle  une fois que la page est fermée
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            }
    }
}
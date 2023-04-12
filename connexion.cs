using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace gestionnaire
{
    public partial class connexion : Form
    {
        public connexion()
        {
            InitializeComponent();
        }

        
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allis\OneDrive\Documents\gestionnaire.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Récupération des informations de connexion
                    string username = tbxUsername.Text;
                    string password = tbxPassword.Text;

                    // Vérification des informations de connexion
                    string query = "SELECT COUNT(*) FROM Utilisateurs WHERE NomUtilisateur = @Username AND MotDePasse = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        // Affichage de la page d'accueil
                        homepage homepage = new homepage();
                        this.Hide();
                        homepage.Show();
                    }
                    else
                    {
                        MessageBox.Show("Nom d'utilisateur ou mot de passe invalide.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            ;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

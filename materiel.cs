using System.Data.SqlClient;
using Mysqlx.Crud;
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
    public partial class materiel : Form
    {
        public materiel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionnaireDataSet9.Materiel'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.materielTableAdapter2.Fill(this.gestionnaireDataSet9.Materiel);
            // TODO: cette ligne de code charge les données dans la table 'gestionnaireDataSet8.listemateriel'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.listematerielTableAdapter.Fill(this.gestionnaireDataSet8.listemateriel);
            // TODO: cette ligne de code charge les données dans la table 'gestionnaireDataSet7.Materiel'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.materielTableAdapter1.Fill(this.gestionnaireDataSet7.Materiel);
            // TODO: cette ligne de code charge les données dans la table 'gestionnaireDataSet6.Materiel'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.materielTableAdapter.Fill(this.gestionnaireDataSet6.Materiel);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allis\OneDrive\Documents\gestionnaire.mdf;Integrated Security=True;Connect Timeout=30";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Materiel VALUES (@ID, @Nom, @Description, @NumeroSerie, @QuantiteEnStock, @QuantiteMin, @QuantiteMax)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                       
                        cmd.Parameters.AddWithValue("@QuantiteEnStock", int.Parse(textBox5.Text));
                        cmd.Parameters.AddWithValue("@QuantiteMin", int.Parse(textBox6.Text));
                        cmd.Parameters.AddWithValue("@QuantiteMax", int.Parse(textBox7.Text));
                        cmd.ExecuteNonQuery();
                    }
                }
            textBox1.Clear();
           
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

            MessageBox.Show("Matériel bien enregistré");
            }

        private void button2_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allis\OneDrive\Documents\gestionnaire.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("Update Materiel set Nom = @Nom, Description=@Description, NumeroSerie= @NumeroSerie, QuantiteEnStock=@QuantiteEnStock where ID=@ID ",con);
                cmd.Parameters.AddWithValue("@ID", textBox1.Text);
               
                cmd.Parameters.AddWithValue("@QuantiteEnStock", textBox5.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Matériel bien modifié !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allis\OneDrive\Documents\gestionnaire.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete Materiel where ID=@ID",con );
                cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Matériel bien supprimé !");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\allis\OneDrive\Documents\gestionnaire.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Materiel where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource= dt;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide(); // Masquer la fenêtre actuelle
            homepage homepage = new homepage(); // Créer une nouvelle instance de la page
            homepage.ShowDialog(); // Afficher la page
            this.Close(); // Fermer la fenêtre actuelle  une fois que la page est fermée
        }
    }
    }


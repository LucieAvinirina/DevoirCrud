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

namespace DevoirCrud
{
    public partial class GestionClient : Form
    {

        SqlConnection cnx;
        public GestionClient()
        {
            cnx = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\PROJET\Visual Studio 2012\Projects\DevoirCrud\DevoirCrud\BD_Client.mdf;Integrated Security=True");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGrid();
            Affiche_combo();
        }


          //FONCTION AFFICHER DATAGRID
        private void DataGrid()
        {
            cnx.Open();
            string query = "select*from Client";
            SqlCommand cmd = new SqlCommand(query, cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.Dispose();
            da.Dispose();
            cnx.Close();
        }

        private void bouton_ajouter_Click(object sender, EventArgs e)
        {

            cnx.Open();
            string query = "insert into Client (nom,prenom,date_naiss,adresse) values (@nom,@prenom,@date_naiss,@adresse)";
            SqlCommand cmd = new SqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@nom", textBox_nom.Text);
            cmd.Parameters.AddWithValue("@prenom", textBox_prenom.Text);
            cmd.Parameters.AddWithValue("@date_naiss", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@adresse", textBox_adresse.Text);

            cmd.ExecuteNonQuery();
            cnx.Close();
            DataGrid();
            MessageBox.Show("Ajout reussie");
           // Affiche_combo();
        
        }


        //FONCTION AJOUTER id DANS COMBOBOX
        private void Affiche_combo()
        {
            cnx.Open();
            string query = "select id_cli from Client";
            SqlCommand cmd = new SqlCommand(query, cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            comboBox_id.Items.Clear();
            while (dr.Read())
            {
                comboBox_id.Items.Add(dr["id_cli"].ToString());
            }
            dr.Close();
            cmd.Dispose();
            cnx.Close();
        }

        private void comboBox_id_SelectedIndexChanged(object sender, EventArgs e)
        {

            cnx.Open();
            string query = "select *from Client where id_cli=@id_cli";
            SqlCommand cmd = new SqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@id_cli", comboBox_id.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox_nom.Text = dr["nom"].ToString();
                textBox_prenom.Text = dr["prenom"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dr["date_naiss"]); ;
                textBox_adresse.Text = dr["adresse"].ToString();
               

            }
            else
            {
                MessageBox.Show("Aucun client trouver avec cet id");

            }
            dr.Close();
            cmd.Dispose();
            cnx.Close();
        }
        

        //bouton_modifier
        private void bouton_modifier_Click_1(object sender, EventArgs e)
        {

            if (comboBox_id.SelectedItem == null)
            {
                MessageBox.Show("veullez selectionnez un client a modifier", "Erreur", MessageBoxButtons.OK);
            }
            else
            {
                cnx.Open();
                string query = "update Client set nom =@nom, prenom =@prenom, date_naiss=@date_naiss, adresse=@adresse where id_cli=@id_cli";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@id_cli", comboBox_id.Text);
                cmd.Parameters.AddWithValue("@nom", textBox_nom.Text);
                cmd.Parameters.AddWithValue("@prenom", textBox_prenom.Text);
                cmd.Parameters.AddWithValue("@date_naiss", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@adresse", textBox_adresse.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                cmd.Dispose();
                cnx.Close();

                if (rowsAffected > 0)
                {
                    Affiche_combo();
                    DataGrid();
                    MessageBox.Show("modification succes");

                }
                else
                {
                    MessageBox.Show("Aucun client trouve");
                }
            }

        }


        //bouton supprimer
        private void bouton_supprimer_Click(object sender, EventArgs e)
        {
            if (comboBox_id.SelectedItem == null)
            {
                MessageBox.Show("veullez selectionnez un client a supprimer", "Erreur", MessageBoxButtons.OK);
            }
            else
            {
                cnx.Open();
                string query = "delete from Client where id_cli=@id_cli";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@id_cli", comboBox_id.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                cmd.Dispose();
                cnx.Close();

                if (rowsAffected > 0)
                {
                    Affiche_combo();
                    DataGrid();
                    MessageBox.Show("suppression succes");

                }
                else
                {
                    MessageBox.Show("Aucun client trouve");
                }
            }
        }

        

       

       

      
        




    }
}

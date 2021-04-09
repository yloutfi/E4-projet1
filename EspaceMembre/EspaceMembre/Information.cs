using Microsoft.OData.Edm;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Espace_Membre.Connexion;

namespace Espace_Membre
{
    public partial class Information : Form
    {
        
        MySqlConnection Cnx = new MySqlConnection("user=root ; server=localhost; port=3307; database=auth_users;");
        
        public Information()
        {
            InitializeComponent();
            
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {


            if (tb_libelle.Text != "" && tb_ville.Text != "" && tb_rue.Text != "" && tb_tel.Text != "" && tb_cp.Text != "")
            {
                if (int.Parse(tb_cp.Text) > 1000 && int.Parse(tb_cp.Text) < 99999)
                {
                    string formation;
                    string libelle = tb_libelle.Text;
                    string ville = tb_ville.Text;
                    string rue = tb_rue.Text;
                    int tel = int.Parse(tb_tel.Text);
                    int codePostal = int.Parse(tb_cp.Text);
                    Date datev = Date.Parse(dateTimePicker.Text);
                    string typed = lb_formation.Text;
                    Cnx.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into entreprise (libelle, tel, rue, ville, CodePostal,typed, dateCreation) values( @lib, @tel, @rue, @ville, @CP, @typed, @DoC); ", Cnx);
                    cmd.Parameters.Add("@lib", MySqlDbType.VarChar).Value = libelle;
                    cmd.Parameters.Add("@tel", MySqlDbType.Int32).Value = tel;
                    cmd.Parameters.Add("@rue", MySqlDbType.VarChar).Value = rue;
                    cmd.Parameters.Add("@ville", MySqlDbType.VarChar).Value = ville;
                    cmd.Parameters.Add("@CP", MySqlDbType.Int32).Value = codePostal;
                    cmd.Parameters.Add("@DoC", MySqlDbType.Date).Value = datev;
                    cmd.Parameters.AddWithValue("@typed", typed);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Les données ont bien été implémentés");
                }
                else
                {
                    MessageBox.Show("Le Code Postale est incorrect!");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs!");
            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}

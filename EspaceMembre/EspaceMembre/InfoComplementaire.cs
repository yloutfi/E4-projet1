using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Espace_Membre
{
    public partial class InfoComplementaire : Form
    {
        MySqlConnection Cnx = new MySqlConnection("user=root ; server=localhost; port=3307; database=auth_users;");
        public InfoComplementaire()
        {
            InitializeComponent();
            
        }

        private void btn_Charger_Click(object sender, EventArgs e)
        {
            Cnx.Open();
            MySqlCommand cmd = new MySqlCommand("select * from entreprise ;", Cnx);
            MySqlDataReader Rdr = cmd.ExecuteReader();
            while (Rdr.Read())
            { 
                lb_charger.Items.Add(Rdr["idEntreprise"].ToString() + "   " + Rdr["libelle"].ToString() + "  " + Rdr["tel"].ToString() + " " + Rdr["rue"].ToString() + " " + Rdr["ville"].ToString() + " " + Rdr["codePostal"].ToString() + " " + Rdr["typed"].ToString() + "  " + Rdr["dateCreation"].ToString());

                MessageBox.Show("Bien chargé!");
            }
        }
    }
}

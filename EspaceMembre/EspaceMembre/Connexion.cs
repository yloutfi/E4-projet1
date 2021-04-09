using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Espace_Membre;

namespace Espace_Membre
{
    public partial class Connexion : Form
    {
        MySqlConnection Cnx = new MySqlConnection("user=root ; server=localhost; port=3307; database=auth_users");

        
        public Connexion()
        {
            InitializeComponent();

            this.tb_passwd2.AutoSize = false;
            this.tb_passwd2.Size = new Size(this.tb_passwd2.Size.Width, 20);
        }
        /*public string DecryptString(string encrString)
        {
            byte[] b;
            string decrypted;

            try
            {
                b = Convert.FromBase64String(encrString);
                decrypted = System.Text.ASCIIEncoding.ASCII.GetString(encrString);
            }
            catch (FormatException fe)
            {
                decrypted = "";

            }
            return decrypted;
        }*/
        

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            if (tb_mail2.Text != "" && tb_passwd2.Text != "") {
                string email = tb_mail2.Text;
                string passwd = tb_passwd2.Text;
                
                Cnx.Open();
                MySqlCommand cmd = new MySqlCommand("select * from user where  mail = @email and passwd = aes_decrypt(@pwd,'key');", Cnx);
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@pwd", MySqlDbType.VarChar).Value = passwd;
                MySqlDataReader Rdr = cmd.ExecuteReader();
                while (Rdr.Read())
                {
                    if (Rdr[3].ToString() == passwd && Rdr[2].ToString() == email)
                    {
                        MessageBox.Show("Bienvenue" + "  " + email);
                        Information infm = new Information();
                        infm.Show();
                        this.Hide();
                        return;
                    }
                }
                MessageBox.Show("Connexion échouée");
                tb_mail2.Text = "";
                tb_passwd2.Text = "";
                return;
                Cnx.Close();
            }
            else
            {
                MessageBox.Show("Veuillez saisir toutes vos informations");
            }
        }

        private void lk_inscrit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inscription ins = new Inscription();
            ins.Show();
            this.Hide();
        }

        private void lb_id_Click(object sender, EventArgs e)
        {
        }
    }
}

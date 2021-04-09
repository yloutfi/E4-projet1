using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Espace_Membre
{
    public partial class Inscription : Form
    {
        
        MySqlConnection Cnx = new MySqlConnection("user=root ; server=localhost; port=3307; database=auth_users");

        public Inscription()
        {
            InitializeComponent();
            this.tb_passwd.AutoSize = false;
            this.tb_passwd.Size = new Size(this.tb_passwd.Size.Width, 20);
        }

       
        private void lk_connect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Connexion connect = new Connexion();
            connect.Show();
            this.Hide();
        }
        private void btn_inscrit_Click(object sender, EventArgs e)
        {
            if (tb_mail.Text != "" && tb_passwd.Text != "" && tb_passwdConfirm.Text != "" && tb_pseudo.Text != "")
            {
                if (tb_passwdConfirm.Text != tb_passwd.Text)
                {
                    MessageBox.Show("Les mots de passe ne correspondent pas");
                    tb_passwd.Text = "";
                    tb_passwdConfirm.Text = "";
                    return;
                    Cnx.Close();
                }
                else
                {
                    string pseudo = tb_pseudo.Text;
                    string email = tb_mail.Text;
                    string passwd = tb_passwd.Text;
                    Cnx.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into user (pseudo,mail,passwd) values (@pseudo,@email,aes_encrypt(@pwd,'key'));", Cnx);
                    cmd.Parameters.Add("@pseudo", MySqlDbType.VarChar).Value = pseudo;
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                    cmd.Parameters.AddWithValue("@pwd", passwd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inscription réussie!");
                    Connexion connect = new Connexion();
                    connect.Show();
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs!");
            }
        }
       
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_pseudo.Text = "";
            tb_mail.Text = "";
            tb_passwd.Text = "";
            tb_passwdConfirm.Text = "";
        }
    }
}

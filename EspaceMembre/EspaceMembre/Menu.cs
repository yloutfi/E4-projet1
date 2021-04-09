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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_inscription_Click(object sender, EventArgs e)
        {
            Inscription ins = new Inscription();
            ins.Show();
        }

        private void btn_connection_Click(object sender, EventArgs e)
        {
            Connexion connect = new Connexion();
            connect.Show();
            this.Hide();
        }
    }
}

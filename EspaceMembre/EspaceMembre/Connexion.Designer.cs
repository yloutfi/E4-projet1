
namespace Espace_Membre
{
    partial class Connexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_mail2 = new System.Windows.Forms.TextBox();
            this.tb_passwd2 = new System.Windows.Forms.TextBox();
            this.btn_connexion = new System.Windows.Forms.Button();
            this.lb_mail2 = new System.Windows.Forms.Label();
            this.lb_mdp2 = new System.Windows.Forms.Label();
            this.lk_inscrit = new System.Windows.Forms.LinkLabel();
            this.lb_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_mail2
            // 
            this.tb_mail2.Location = new System.Drawing.Point(175, 80);
            this.tb_mail2.Name = "tb_mail2";
            this.tb_mail2.Size = new System.Drawing.Size(173, 20);
            this.tb_mail2.TabIndex = 0;
            // 
            // tb_passwd2
            // 
            this.tb_passwd2.Location = new System.Drawing.Point(175, 124);
            this.tb_passwd2.Name = "tb_passwd2";
            this.tb_passwd2.Size = new System.Drawing.Size(173, 20);
            this.tb_passwd2.TabIndex = 1;
            this.tb_passwd2.UseSystemPasswordChar = true;
            // 
            // btn_connexion
            // 
            this.btn_connexion.Location = new System.Drawing.Point(206, 189);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(105, 23);
            this.btn_connexion.TabIndex = 2;
            this.btn_connexion.Text = "Se connecter";
            this.btn_connexion.UseVisualStyleBackColor = true;
            this.btn_connexion.Click += new System.EventHandler(this.btn_connexion_Click);
            this.btn_connexion.Enter += new System.EventHandler(this.btn_connexion_Click);
            // 
            // lb_mail2
            // 
            this.lb_mail2.AutoSize = true;
            this.lb_mail2.Location = new System.Drawing.Point(28, 80);
            this.lb_mail2.Name = "lb_mail2";
            this.lb_mail2.Size = new System.Drawing.Size(72, 13);
            this.lb_mail2.TabIndex = 3;
            this.lb_mail2.Text = "Adresse mail :";
            // 
            // lb_mdp2
            // 
            this.lb_mdp2.AutoSize = true;
            this.lb_mdp2.Location = new System.Drawing.Point(28, 131);
            this.lb_mdp2.Name = "lb_mdp2";
            this.lb_mdp2.Size = new System.Drawing.Size(77, 13);
            this.lb_mdp2.TabIndex = 4;
            this.lb_mdp2.Text = "Mot de passe :";
            // 
            // lk_inscrit
            // 
            this.lk_inscrit.AutoSize = true;
            this.lk_inscrit.LinkVisited = true;
            this.lk_inscrit.Location = new System.Drawing.Point(152, 249);
            this.lk_inscrit.Name = "lk_inscrit";
            this.lk_inscrit.Size = new System.Drawing.Size(168, 13);
            this.lk_inscrit.TabIndex = 5;
            this.lk_inscrit.TabStop = true;
            this.lk_inscrit.Text = "Pas encore inscrit? Inscrivez-vous";
            this.lk_inscrit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_inscrit_LinkClicked);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(203, 49);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(35, 13);
            this.lb_id.TabIndex = 6;
            this.lb_id.Text = "label1";
            this.lb_id.Click += new System.EventHandler(this.lb_id_Click);
            // 
            // Connexion
            // 
            this.AcceptButton = this.btn_connexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 295);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.lk_inscrit);
            this.Controls.Add(this.lb_mdp2);
            this.Controls.Add(this.lb_mail2);
            this.Controls.Add(this.btn_connexion);
            this.Controls.Add(this.tb_passwd2);
            this.Controls.Add(this.tb_mail2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_mail2;
        private System.Windows.Forms.TextBox tb_passwd2;
        private System.Windows.Forms.Button btn_connexion;
        private System.Windows.Forms.Label lb_mail2;
        private System.Windows.Forms.Label lb_mdp2;
        private System.Windows.Forms.LinkLabel lk_inscrit;
        private System.Windows.Forms.Label lb_id;
    }
}
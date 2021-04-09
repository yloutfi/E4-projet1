
namespace Espace_Membre
{
    partial class Inscription
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lk_connect = new System.Windows.Forms.LinkLabel();
            this.btn_inscrit = new System.Windows.Forms.Button();
            this.tb_passwdConfirm = new System.Windows.Forms.TextBox();
            this.tb_passwd = new System.Windows.Forms.TextBox();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.tb_pseudo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votre pseudo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Votre mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Votre mot de passe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirmer mot de passe :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.lk_connect);
            this.groupBox1.Controls.Add(this.btn_inscrit);
            this.groupBox1.Controls.Add(this.tb_passwdConfirm);
            this.groupBox1.Controls.Add(this.tb_passwd);
            this.groupBox1.Controls.Add(this.tb_mail);
            this.groupBox1.Controls.Add(this.tb_pseudo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 364);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incrivez-vous";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(146, 280);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Annuler";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lk_connect
            // 
            this.lk_connect.AutoSize = true;
            this.lk_connect.LinkColor = System.Drawing.Color.DarkCyan;
            this.lk_connect.Location = new System.Drawing.Point(130, 330);
            this.lk_connect.Name = "lk_connect";
            this.lk_connect.Size = new System.Drawing.Size(145, 13);
            this.lk_connect.TabIndex = 10;
            this.lk_connect.TabStop = true;
            this.lk_connect.Text = "Déja inscrit? Connectez-vous";
            this.lk_connect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_connect_LinkClicked);
            // 
            // btn_inscrit
            // 
            this.btn_inscrit.Location = new System.Drawing.Point(249, 280);
            this.btn_inscrit.Name = "btn_inscrit";
            this.btn_inscrit.Size = new System.Drawing.Size(75, 23);
            this.btn_inscrit.TabIndex = 8;
            this.btn_inscrit.Text = "S\'inscrire";
            this.btn_inscrit.UseVisualStyleBackColor = true;
            this.btn_inscrit.Click += new System.EventHandler(this.btn_inscrit_Click);
            // 
            // tb_passwdConfirm
            // 
            this.tb_passwdConfirm.Location = new System.Drawing.Point(170, 216);
            this.tb_passwdConfirm.Name = "tb_passwdConfirm";
            this.tb_passwdConfirm.Size = new System.Drawing.Size(198, 20);
            this.tb_passwdConfirm.TabIndex = 7;
            this.tb_passwdConfirm.UseSystemPasswordChar = true;
            // 
            // tb_passwd
            // 
            this.tb_passwd.Location = new System.Drawing.Point(170, 154);
            this.tb_passwd.Name = "tb_passwd";
            this.tb_passwd.Size = new System.Drawing.Size(198, 20);
            this.tb_passwd.TabIndex = 6;
            this.tb_passwd.UseSystemPasswordChar = true;
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(170, 100);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(198, 20);
            this.tb_mail.TabIndex = 5;
            // 
            // tb_pseudo
            // 
            this.tb_pseudo.Location = new System.Drawing.Point(170, 45);
            this.tb_pseudo.Name = "tb_pseudo";
            this.tb_pseudo.Size = new System.Drawing.Size(198, 20);
            this.tb_pseudo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // Inscription
            // 
            this.AcceptButton = this.btn_inscrit;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 397);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inscription";
            this.Text = "Inscription";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.LinkLabel lk_connect;
        private System.Windows.Forms.Button btn_inscrit;
        private System.Windows.Forms.TextBox tb_passwdConfirm;
        private System.Windows.Forms.TextBox tb_passwd;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.TextBox tb_pseudo;
        private System.Windows.Forms.Label label5;
    }
}
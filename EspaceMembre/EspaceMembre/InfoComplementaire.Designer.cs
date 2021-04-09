
namespace Espace_Membre
{
    partial class InfoComplementaire
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
            this.lb_charger = new System.Windows.Forms.ListBox();
            this.btn_Charger = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_charger
            // 
            this.lb_charger.FormattingEnabled = true;
            this.lb_charger.Location = new System.Drawing.Point(29, 13);
            this.lb_charger.Name = "lb_charger";
            this.lb_charger.Size = new System.Drawing.Size(440, 394);
            this.lb_charger.TabIndex = 0;
            // 
            // btn_Charger
            // 
            this.btn_Charger.Location = new System.Drawing.Point(573, 13);
            this.btn_Charger.Name = "btn_Charger";
            this.btn_Charger.Size = new System.Drawing.Size(123, 23);
            this.btn_Charger.TabIndex = 1;
            this.btn_Charger.Text = "Charger ses données";
            this.btn_Charger.UseVisualStyleBackColor = true;
            this.btn_Charger.Click += new System.EventHandler(this.btn_Charger_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(573, 71);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(123, 23);
            this.btn_Supprimer.TabIndex = 2;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            // 
            // InfoComplementaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Charger);
            this.Controls.Add(this.lb_charger);
            this.Name = "InfoComplementaire";
            this.Text = "Récapitulatif";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_charger;
        private System.Windows.Forms.Button btn_Charger;
        private System.Windows.Forms.Button btn_Supprimer;
    }
}

namespace WindowsFormsRechercheDonnee
{
    partial class Recherche
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCF = new System.Windows.Forms.Label();
            this.textBoxCodeFournisseur = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCF
            // 
            this.labelCF.AutoSize = true;
            this.labelCF.Location = new System.Drawing.Point(40, 51);
            this.labelCF.Name = "labelCF";
            this.labelCF.Size = new System.Drawing.Size(135, 20);
            this.labelCF.TabIndex = 0;
            this.labelCF.Text = "Code Fournisseur";
            // 
            // textBoxCodeFournisseur
            // 
            this.textBoxCodeFournisseur.Location = new System.Drawing.Point(252, 45);
            this.textBoxCodeFournisseur.Name = "textBoxCodeFournisseur";
            this.textBoxCodeFournisseur.Size = new System.Drawing.Size(124, 26);
            this.textBoxCodeFournisseur.TabIndex = 1;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(44, 102);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(123, 32);
            this.buttonValider.TabIndex = 2;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(252, 102);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(124, 32);
            this.buttonQuitter.TabIndex = 3;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // Recherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 168);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxCodeFournisseur);
            this.Controls.Add(this.labelCF);
            this.Name = "Recherche";
            this.Text = "Affichage Fournisseur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Recherche_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCF;
        private System.Windows.Forms.TextBox textBoxCodeFournisseur;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonQuitter;
    }
}


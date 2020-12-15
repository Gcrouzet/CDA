
namespace WindowsFormsAppRechercheLigne
{
    partial class ListeCommande
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
            this.labelChoisir = new System.Windows.Forms.Label();
            this.comboBoxListeFournisseur = new System.Windows.Forms.ComboBox();
            this.labelCommandes = new System.Windows.Forms.Label();
            this.listBoxCommandes = new System.Windows.Forms.ListBox();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChoisir
            // 
            this.labelChoisir.AutoSize = true;
            this.labelChoisir.Location = new System.Drawing.Point(63, 72);
            this.labelChoisir.Name = "labelChoisir";
            this.labelChoisir.Size = new System.Drawing.Size(162, 20);
            this.labelChoisir.TabIndex = 0;
            this.labelChoisir.Text = "Choisir un fournisseur";
            // 
            // comboBoxListeFournisseur
            // 
            this.comboBoxListeFournisseur.FormattingEnabled = true;
            this.comboBoxListeFournisseur.Location = new System.Drawing.Point(279, 72);
            this.comboBoxListeFournisseur.Name = "comboBoxListeFournisseur";
            this.comboBoxListeFournisseur.Size = new System.Drawing.Size(165, 28);
            this.comboBoxListeFournisseur.TabIndex = 1;
            this.comboBoxListeFournisseur.SelectedIndexChanged += new System.EventHandler(this.comboBoxListeFournisseur_SelectedIndexChanged);
            // 
            // labelCommandes
            // 
            this.labelCommandes.AutoSize = true;
            this.labelCommandes.Location = new System.Drawing.Point(63, 157);
            this.labelCommandes.Name = "labelCommandes";
            this.labelCommandes.Size = new System.Drawing.Size(126, 20);
            this.labelCommandes.TabIndex = 2;
            this.labelCommandes.Text = "Les commandes";
            // 
            // listBoxCommandes
            // 
            this.listBoxCommandes.FormattingEnabled = true;
            this.listBoxCommandes.ItemHeight = 20;
            this.listBoxCommandes.Location = new System.Drawing.Point(67, 180);
            this.listBoxCommandes.Name = "listBoxCommandes";
            this.listBoxCommandes.Size = new System.Drawing.Size(448, 104);
            this.listBoxCommandes.TabIndex = 3;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(392, 307);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(102, 35);
            this.buttonQuitter.TabIndex = 4;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // ListeCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 354);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.listBoxCommandes);
            this.Controls.Add(this.labelCommandes);
            this.Controls.Add(this.comboBoxListeFournisseur);
            this.Controls.Add(this.labelChoisir);
            this.Name = "ListeCommande";
            this.Text = "Liste des Commandes";
            this.Load += new System.EventHandler(this.ListeCommande_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChoisir;
        private System.Windows.Forms.ComboBox comboBoxListeFournisseur;
        private System.Windows.Forms.Label labelCommandes;
        private System.Windows.Forms.ListBox listBoxCommandes;
        private System.Windows.Forms.Button buttonQuitter;
    }
}


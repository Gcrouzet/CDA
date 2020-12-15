
namespace WindowsFormsAppMAJTable
{
    partial class MaJTable
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
            this.labelCodeFournisseur = new System.Windows.Forms.Label();
            this.textBoxCodeFournisseur = new System.Windows.Forms.TextBox();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelCodePostal = new System.Windows.Forms.Label();
            this.labelVille = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.comboBoxListeFournisseur = new System.Windows.Forms.ComboBox();
            this.labelListeFournisseur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCodeFournisseur
            // 
            this.labelCodeFournisseur.AutoSize = true;
            this.labelCodeFournisseur.Location = new System.Drawing.Point(8, 47);
            this.labelCodeFournisseur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodeFournisseur.Name = "labelCodeFournisseur";
            this.labelCodeFournisseur.Size = new System.Drawing.Size(86, 13);
            this.labelCodeFournisseur.TabIndex = 0;
            this.labelCodeFournisseur.Text = "Code fournisseur";
            // 
            // textBoxCodeFournisseur
            // 
            this.textBoxCodeFournisseur.Location = new System.Drawing.Point(129, 43);
            this.textBoxCodeFournisseur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCodeFournisseur.Name = "textBoxCodeFournisseur";
            this.textBoxCodeFournisseur.Size = new System.Drawing.Size(60, 20);
            this.textBoxCodeFournisseur.TabIndex = 1;
            this.textBoxCodeFournisseur.TextChanged += new System.EventHandler(this.textBoxCodeFournisseur_TextChanged);
            // 
            // buttonCreer
            // 
            this.buttonCreer.Location = new System.Drawing.Point(213, 166);
            this.buttonCreer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(76, 19);
            this.buttonCreer.TabIndex = 3;
            this.buttonCreer.Text = "Créer";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(307, 49);
            this.labelNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 4;
            this.labelNom.Text = "Nom";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(307, 96);
            this.labelAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(45, 13);
            this.labelAdresse.TabIndex = 5;
            this.labelAdresse.Text = "Adresse";
            // 
            // labelCodePostal
            // 
            this.labelCodePostal.AutoSize = true;
            this.labelCodePostal.Location = new System.Drawing.Point(307, 144);
            this.labelCodePostal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodePostal.Name = "labelCodePostal";
            this.labelCodePostal.Size = new System.Drawing.Size(64, 13);
            this.labelCodePostal.TabIndex = 6;
            this.labelCodePostal.Text = "Code Postal";
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(307, 193);
            this.labelVille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(26, 13);
            this.labelVille.TabIndex = 7;
            this.labelVille.Text = "Ville";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(382, 94);
            this.textBoxAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.ReadOnly = true;
            this.textBoxAdresse.Size = new System.Drawing.Size(87, 20);
            this.textBoxAdresse.TabIndex = 8;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(382, 47);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.ReadOnly = true;
            this.textBoxNom.Size = new System.Drawing.Size(87, 20);
            this.textBoxNom.TabIndex = 9;
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(382, 142);
            this.textBoxCP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.ReadOnly = true;
            this.textBoxCP.Size = new System.Drawing.Size(87, 20);
            this.textBoxCP.TabIndex = 10;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(382, 191);
            this.textBoxVille.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.ReadOnly = true;
            this.textBoxVille.Size = new System.Drawing.Size(87, 20);
            this.textBoxVille.TabIndex = 11;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(213, 189);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(76, 22);
            this.buttonAjouter.TabIndex = 12;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(39, 190);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(76, 21);
            this.buttonSupprimer.TabIndex = 13;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(213, 44);
            this.buttonRechercher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(76, 19);
            this.buttonRechercher.TabIndex = 2;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(39, 166);
            this.buttonModifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(76, 20);
            this.buttonModifier.TabIndex = 14;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            // 
            // comboBoxListeFournisseur
            // 
            this.comboBoxListeFournisseur.FormattingEnabled = true;
            this.comboBoxListeFournisseur.Location = new System.Drawing.Point(129, 12);
            this.comboBoxListeFournisseur.Name = "comboBoxListeFournisseur";
            this.comboBoxListeFournisseur.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListeFournisseur.TabIndex = 15;
            this.comboBoxListeFournisseur.SelectedIndexChanged += new System.EventHandler(this.comboBoxListeFournisseur_SelectedIndexChanged);
            // 
            // labelListeFournisseur
            // 
            this.labelListeFournisseur.AutoSize = true;
            this.labelListeFournisseur.Location = new System.Drawing.Point(8, 15);
            this.labelListeFournisseur.Name = "labelListeFournisseur";
            this.labelListeFournisseur.Size = new System.Drawing.Size(86, 13);
            this.labelListeFournisseur.TabIndex = 16;
            this.labelListeFournisseur.Text = "Liste Fournisseur";
            // 
            // MaJTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 253);
            this.Controls.Add(this.labelListeFournisseur);
            this.Controls.Add(this.comboBoxListeFournisseur);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.labelCodePostal);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.textBoxCodeFournisseur);
            this.Controls.Add(this.labelCodeFournisseur);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MaJTable";
            this.Text = "Update Delete Insert";
            this.Load += new System.EventHandler(this.MaJTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodeFournisseur;
        private System.Windows.Forms.TextBox textBoxCodeFournisseur;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelCodePostal;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.ComboBox comboBoxListeFournisseur;
        private System.Windows.Forms.Label labelListeFournisseur;
    }
}



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
            this.labelCodeFournisseur.Location = new System.Drawing.Point(12, 72);
            this.labelCodeFournisseur.Name = "labelCodeFournisseur";
            this.labelCodeFournisseur.Size = new System.Drawing.Size(130, 20);
            this.labelCodeFournisseur.TabIndex = 0;
            this.labelCodeFournisseur.Text = "Code fournisseur";
            // 
            // textBoxCodeFournisseur
            // 
            this.textBoxCodeFournisseur.Location = new System.Drawing.Point(194, 66);
            this.textBoxCodeFournisseur.Name = "textBoxCodeFournisseur";
            this.textBoxCodeFournisseur.Size = new System.Drawing.Size(88, 26);
            this.textBoxCodeFournisseur.TabIndex = 1;
            this.textBoxCodeFournisseur.TextChanged += new System.EventHandler(this.textBoxCodeFournisseur_TextChanged);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(460, 75);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(42, 20);
            this.labelNom.TabIndex = 4;
            this.labelNom.Text = "Nom";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(460, 148);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(68, 20);
            this.labelAdresse.TabIndex = 5;
            this.labelAdresse.Text = "Adresse";
            // 
            // labelCodePostal
            // 
            this.labelCodePostal.AutoSize = true;
            this.labelCodePostal.Location = new System.Drawing.Point(460, 222);
            this.labelCodePostal.Name = "labelCodePostal";
            this.labelCodePostal.Size = new System.Drawing.Size(95, 20);
            this.labelCodePostal.TabIndex = 6;
            this.labelCodePostal.Text = "Code Postal";
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(460, 297);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(38, 20);
            this.labelVille.TabIndex = 7;
            this.labelVille.Text = "Ville";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(573, 145);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(128, 26);
            this.textBoxAdresse.TabIndex = 8;
            this.textBoxAdresse.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(573, 72);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(128, 26);
            this.textBoxNom.TabIndex = 9;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(573, 219);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(128, 26);
            this.textBoxCP.TabIndex = 10;
            this.textBoxCP.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(573, 294);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(128, 26);
            this.textBoxVille.TabIndex = 11;
            this.textBoxVille.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Enabled = false;
            this.buttonAjouter.Location = new System.Drawing.Point(320, 255);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(114, 34);
            this.buttonAjouter.TabIndex = 12;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Enabled = false;
            this.buttonSupprimer.Location = new System.Drawing.Point(58, 292);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(114, 32);
            this.buttonSupprimer.TabIndex = 13;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(320, 68);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(114, 29);
            this.buttonRechercher.TabIndex = 2;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Enabled = false;
            this.buttonModifier.Location = new System.Drawing.Point(58, 255);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(114, 31);
            this.buttonModifier.TabIndex = 14;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // comboBoxListeFournisseur
            // 
            this.comboBoxListeFournisseur.FormattingEnabled = true;
            this.comboBoxListeFournisseur.Location = new System.Drawing.Point(194, 18);
            this.comboBoxListeFournisseur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxListeFournisseur.Name = "comboBoxListeFournisseur";
            this.comboBoxListeFournisseur.Size = new System.Drawing.Size(180, 28);
            this.comboBoxListeFournisseur.TabIndex = 15;
            this.comboBoxListeFournisseur.SelectedIndexChanged += new System.EventHandler(this.comboBoxListeFournisseur_SelectedIndexChanged);
            // 
            // labelListeFournisseur
            // 
            this.labelListeFournisseur.AutoSize = true;
            this.labelListeFournisseur.Location = new System.Drawing.Point(12, 23);
            this.labelListeFournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListeFournisseur.Name = "labelListeFournisseur";
            this.labelListeFournisseur.Size = new System.Drawing.Size(131, 20);
            this.labelListeFournisseur.TabIndex = 16;
            this.labelListeFournisseur.Text = "Liste Fournisseur";
            // 
            // MaJTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 389);
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
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.textBoxCodeFournisseur);
            this.Controls.Add(this.labelCodeFournisseur);
            this.Name = "MaJTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Delete Insert";
            this.Load += new System.EventHandler(this.MaJTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodeFournisseur;
        private System.Windows.Forms.TextBox textBoxCodeFournisseur;
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


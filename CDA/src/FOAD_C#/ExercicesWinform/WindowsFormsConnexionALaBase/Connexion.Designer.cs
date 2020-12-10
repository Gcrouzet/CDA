
namespace WindowsFormsConnexionALaBase
{
    partial class Connexion
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
            this.labelServeur = new System.Windows.Forms.Label();
            this.labelBDD = new System.Windows.Forms.Label();
            this.labelEtat = new System.Windows.Forms.Label();
            this.labelClosed_Open = new System.Windows.Forms.Label();
            this.textBoxErreur = new System.Windows.Forms.TextBox();
            this.textBoxServeur = new System.Windows.Forms.TextBox();
            this.textBoxBDD = new System.Windows.Forms.TextBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelServeur
            // 
            this.labelServeur.AutoSize = true;
            this.labelServeur.Location = new System.Drawing.Point(28, 57);
            this.labelServeur.Name = "labelServeur";
            this.labelServeur.Size = new System.Drawing.Size(72, 20);
            this.labelServeur.TabIndex = 0;
            this.labelServeur.Text = "Serveur :";
            // 
            // labelBDD
            // 
            this.labelBDD.AutoSize = true;
            this.labelBDD.Location = new System.Drawing.Point(28, 120);
            this.labelBDD.Name = "labelBDD";
            this.labelBDD.Size = new System.Drawing.Size(142, 20);
            this.labelBDD.TabIndex = 1;
            this.labelBDD.Text = "Base de données :";
            // 
            // labelEtat
            // 
            this.labelEtat.AutoSize = true;
            this.labelEtat.Location = new System.Drawing.Point(12, 292);
            this.labelEtat.Name = "labelEtat";
            this.labelEtat.Size = new System.Drawing.Size(153, 20);
            this.labelEtat.TabIndex = 2;
            this.labelEtat.Text = "Etat de la connexion";
            // 
            // labelClosed_Open
            // 
            this.labelClosed_Open.AutoSize = true;
            this.labelClosed_Open.Location = new System.Drawing.Point(182, 292);
            this.labelClosed_Open.Name = "labelClosed_Open";
            this.labelClosed_Open.Size = new System.Drawing.Size(0, 20);
            this.labelClosed_Open.TabIndex = 3;
            // 
            // textBoxErreur
            // 
            this.textBoxErreur.Location = new System.Drawing.Point(12, 326);
            this.textBoxErreur.Multiline = true;
            this.textBoxErreur.Name = "textBoxErreur";
            this.textBoxErreur.ReadOnly = true;
            this.textBoxErreur.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxErreur.Size = new System.Drawing.Size(420, 171);
            this.textBoxErreur.TabIndex = 4;
            // 
            // textBoxServeur
            // 
            this.textBoxServeur.Location = new System.Drawing.Point(231, 54);
            this.textBoxServeur.Name = "textBoxServeur";
            this.textBoxServeur.Size = new System.Drawing.Size(201, 26);
            this.textBoxServeur.TabIndex = 5;
            // 
            // textBoxBDD
            // 
            this.textBoxBDD.Location = new System.Drawing.Point(231, 117);
            this.textBoxBDD.Name = "textBoxBDD";
            this.textBoxBDD.Size = new System.Drawing.Size(201, 26);
            this.textBoxBDD.TabIndex = 6;
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(46, 191);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(119, 32);
            this.buttonConnexion.TabIndex = 7;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(245, 229);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(135, 32);
            this.buttonQuitter.TabIndex = 8;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.Enabled = false;
            this.buttonDeconnexion.Location = new System.Drawing.Point(245, 191);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(135, 32);
            this.buttonDeconnexion.TabIndex = 9;
            this.buttonDeconnexion.Text = "Déconnexion";
            this.buttonDeconnexion.UseVisualStyleBackColor = true;
            this.buttonDeconnexion.Click += new System.EventHandler(this.buttonDeconnexion_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 509);
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.textBoxBDD);
            this.Controls.Add(this.textBoxServeur);
            this.Controls.Add(this.textBoxErreur);
            this.Controls.Add(this.labelClosed_Open);
            this.Controls.Add(this.labelEtat);
            this.Controls.Add(this.labelBDD);
            this.Controls.Add(this.labelServeur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Connexion";
            this.Text = "Connexion à la base de données";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Connexion_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelServeur;
        private System.Windows.Forms.Label labelBDD;
        private System.Windows.Forms.Label labelEtat;
        private System.Windows.Forms.Label labelClosed_Open;
        private System.Windows.Forms.TextBox textBoxErreur;
        private System.Windows.Forms.TextBox textBoxServeur;
        private System.Windows.Forms.TextBox textBoxBDD;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonDeconnexion;
    }
}


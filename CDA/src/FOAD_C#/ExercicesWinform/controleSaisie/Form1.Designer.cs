namespace controleSaisie
{
    partial class controle
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
            this.textNom = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.textMontant = new System.Windows.Forms.TextBox();
            this.textCP = new System.Windows.Forms.TextBox();
            this.Valider = new System.Windows.Forms.Button();
            this.Effacer = new System.Windows.Forms.Button();
            this.Nom = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Montant = new System.Windows.Forms.Label();
            this.CodePostal = new System.Windows.Forms.Label();
            this.Date2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(116, 85);
            this.textNom.MaxLength = 30;
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(173, 20);
            this.textNom.TabIndex = 0;
            this.textNom.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(116, 127);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(124, 20);
            this.textDate.TabIndex = 1;
            this.textDate.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textMontant
            // 
            this.textMontant.Location = new System.Drawing.Point(116, 168);
            this.textMontant.Name = "textMontant";
            this.textMontant.Size = new System.Drawing.Size(124, 20);
            this.textMontant.TabIndex = 2;
            this.textMontant.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textCP
            // 
            this.textCP.Location = new System.Drawing.Point(116, 211);
            this.textCP.MaxLength = 5;
            this.textCP.Name = "textCP";
            this.textCP.Size = new System.Drawing.Size(100, 20);
            this.textCP.TabIndex = 3;
            this.textCP.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // Valider
            // 
            this.Valider.Enabled = false;
            this.Valider.Location = new System.Drawing.Point(342, 239);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(83, 24);
            this.Valider.TabIndex = 4;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Effacer
            // 
            this.Effacer.Location = new System.Drawing.Point(342, 269);
            this.Effacer.Name = "Effacer";
            this.Effacer.Size = new System.Drawing.Size(83, 24);
            this.Effacer.TabIndex = 5;
            this.Effacer.Text = "Effacer";
            this.Effacer.UseVisualStyleBackColor = true;
            this.Effacer.Click += new System.EventHandler(this.Effacer_Click);
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(30, 88);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(29, 13);
            this.Nom.TabIndex = 6;
            this.Nom.Text = "Nom";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(30, 130);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 7;
            this.Date.Text = "Date";
            // 
            // Montant
            // 
            this.Montant.AutoSize = true;
            this.Montant.Location = new System.Drawing.Point(30, 175);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(46, 13);
            this.Montant.TabIndex = 8;
            this.Montant.Text = "Montant";
            // 
            // CodePostal
            // 
            this.CodePostal.AutoSize = true;
            this.CodePostal.Location = new System.Drawing.Point(30, 214);
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.Size = new System.Drawing.Size(64, 13);
            this.CodePostal.TabIndex = 9;
            this.CodePostal.Text = "Code Postal";
            // 
            // Date2
            // 
            this.Date2.AutoSize = true;
            this.Date2.Location = new System.Drawing.Point(258, 130);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(79, 13);
            this.Date2.TabIndex = 10;
            this.Date2.Text = "(JJ/MM/AAAA)";
            // 
            // controle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 320);
            this.Controls.Add(this.Date2);
            this.Controls.Add(this.CodePostal);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Effacer);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.textCP);
            this.Controls.Add(this.textMontant);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.textNom);
            this.MaximumSize = new System.Drawing.Size(463, 359);
            this.MinimumSize = new System.Drawing.Size(463, 359);
            this.Name = "controle";
            this.Text = "Les contrôles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.TextBox textMontant;
        private System.Windows.Forms.TextBox textCP;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Button Effacer;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Montant;
        private System.Windows.Forms.Label CodePostal;
        private System.Windows.Forms.Label Date2;
    }
}


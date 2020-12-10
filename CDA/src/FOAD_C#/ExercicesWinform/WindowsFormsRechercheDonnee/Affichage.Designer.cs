
namespace WindowsFormsRechercheDonnee
{
    partial class Affichage
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
            this.labelNom = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelCP_Ville = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelSatisfaction = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxSatisfaction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(53, 48);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(50, 20);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom :";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(53, 104);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(76, 20);
            this.labelAdresse.TabIndex = 1;
            this.labelAdresse.Text = "Adresse :";
            // 
            // labelCP_Ville
            // 
            this.labelCP_Ville.AutoSize = true;
            this.labelCP_Ville.Location = new System.Drawing.Point(52, 161);
            this.labelCP_Ville.Name = "labelCP_Ville";
            this.labelCP_Ville.Size = new System.Drawing.Size(79, 20);
            this.labelCP_Ville.TabIndex = 2;
            this.labelCP_Ville.Text = "CP / Ville :";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(53, 225);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(73, 20);
            this.labelContact.TabIndex = 3;
            this.labelContact.Text = "Contact :";
            // 
            // labelSatisfaction
            // 
            this.labelSatisfaction.AutoSize = true;
            this.labelSatisfaction.Location = new System.Drawing.Point(53, 281);
            this.labelSatisfaction.Name = "labelSatisfaction";
            this.labelSatisfaction.Size = new System.Drawing.Size(101, 20);
            this.labelSatisfaction.TabIndex = 4;
            this.labelSatisfaction.Text = "Satisfaction :";
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(369, 300);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(116, 32);
            this.buttonRetour.TabIndex = 6;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(216, 48);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.ReadOnly = true;
            this.textBoxNom.Size = new System.Drawing.Size(227, 26);
            this.textBoxNom.TabIndex = 7;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(216, 104);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.ReadOnly = true;
            this.textBoxAdresse.Size = new System.Drawing.Size(227, 26);
            this.textBoxAdresse.TabIndex = 8;
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(216, 161);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.ReadOnly = true;
            this.textBoxCP.Size = new System.Drawing.Size(100, 26);
            this.textBoxCP.TabIndex = 9;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(343, 161);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.ReadOnly = true;
            this.textBoxVille.Size = new System.Drawing.Size(160, 26);
            this.textBoxVille.TabIndex = 10;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(216, 225);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.ReadOnly = true;
            this.textBoxContact.Size = new System.Drawing.Size(203, 26);
            this.textBoxContact.TabIndex = 11;
            // 
            // textBoxSatisfaction
            // 
            this.textBoxSatisfaction.Location = new System.Drawing.Point(216, 278);
            this.textBoxSatisfaction.Name = "textBoxSatisfaction";
            this.textBoxSatisfaction.ReadOnly = true;
            this.textBoxSatisfaction.Size = new System.Drawing.Size(27, 26);
            this.textBoxSatisfaction.TabIndex = 12;
            // 
            // Affichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 361);
            this.Controls.Add(this.textBoxSatisfaction);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.labelSatisfaction);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelCP_Ville);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelNom);
            this.Name = "Affichage";
            this.Text = "Affichage Fournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelCP_Ville;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelSatisfaction;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxSatisfaction;
    }
}
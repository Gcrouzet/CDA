namespace WindowsFormsCheckBox
{
    partial class checkBox
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
            this.labelTapezVotreTexte = new System.Windows.Forms.Label();
            this.groupBoxChoix = new System.Windows.Forms.GroupBox();
            this.checkBoxCasse = new System.Windows.Forms.CheckBox();
            this.checkBoxCouleurDesCaracteres = new System.Windows.Forms.CheckBox();
            this.checkBoxCouleurDeFond = new System.Windows.Forms.CheckBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.groupBoxFond = new System.Windows.Forms.GroupBox();
            this.radioButtonVert = new System.Windows.Forms.RadioButton();
            this.radioButtonRouge = new System.Windows.Forms.RadioButton();
            this.radioButtonBleu = new System.Windows.Forms.RadioButton();
            this.groupBoxCaracteres = new System.Windows.Forms.GroupBox();
            this.radioButtonNoir = new System.Windows.Forms.RadioButton();
            this.radioButtonRougeCaractere = new System.Windows.Forms.RadioButton();
            this.radioButtonBlanc = new System.Windows.Forms.RadioButton();
            this.groupBoxCasse = new System.Windows.Forms.GroupBox();
            this.radioButtonMajuscules = new System.Windows.Forms.RadioButton();
            this.radioButtonMinuscules = new System.Windows.Forms.RadioButton();
            this.labelDouble = new System.Windows.Forms.Label();
            this.groupBoxChoix.SuspendLayout();
            this.groupBoxFond.SuspendLayout();
            this.groupBoxCaracteres.SuspendLayout();
            this.groupBoxCasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTapezVotreTexte
            // 
            this.labelTapezVotreTexte.AutoSize = true;
            this.labelTapezVotreTexte.Location = new System.Drawing.Point(12, 9);
            this.labelTapezVotreTexte.Name = "labelTapezVotreTexte";
            this.labelTapezVotreTexte.Size = new System.Drawing.Size(90, 13);
            this.labelTapezVotreTexte.TabIndex = 1;
            this.labelTapezVotreTexte.Text = "Tapez votre texte";
            // 
            // groupBoxChoix
            // 
            this.groupBoxChoix.Controls.Add(this.checkBoxCasse);
            this.groupBoxChoix.Controls.Add(this.checkBoxCouleurDesCaracteres);
            this.groupBoxChoix.Controls.Add(this.checkBoxCouleurDeFond);
            this.groupBoxChoix.Enabled = false;
            this.groupBoxChoix.Location = new System.Drawing.Point(337, 25);
            this.groupBoxChoix.Name = "groupBoxChoix";
            this.groupBoxChoix.Size = new System.Drawing.Size(200, 100);
            this.groupBoxChoix.TabIndex = 2;
            this.groupBoxChoix.TabStop = false;
            this.groupBoxChoix.Text = "Choix";
            // 
            // checkBoxCasse
            // 
            this.checkBoxCasse.AutoSize = true;
            this.checkBoxCasse.Location = new System.Drawing.Point(20, 65);
            this.checkBoxCasse.Name = "checkBoxCasse";
            this.checkBoxCasse.Size = new System.Drawing.Size(55, 17);
            this.checkBoxCasse.TabIndex = 2;
            this.checkBoxCasse.Text = "Casse";
            this.checkBoxCasse.UseVisualStyleBackColor = true;
            this.checkBoxCasse.CheckedChanged += new System.EventHandler(this.checkBoxCasse_CheckedChanged);
            // 
            // checkBoxCouleurDesCaracteres
            // 
            this.checkBoxCouleurDesCaracteres.AutoSize = true;
            this.checkBoxCouleurDesCaracteres.Location = new System.Drawing.Point(20, 43);
            this.checkBoxCouleurDesCaracteres.Name = "checkBoxCouleurDesCaracteres";
            this.checkBoxCouleurDesCaracteres.Size = new System.Drawing.Size(135, 17);
            this.checkBoxCouleurDesCaracteres.TabIndex = 1;
            this.checkBoxCouleurDesCaracteres.Text = "Couleur des caractères";
            this.checkBoxCouleurDesCaracteres.UseVisualStyleBackColor = true;
            this.checkBoxCouleurDesCaracteres.CheckedChanged += new System.EventHandler(this.checkBoxCouleurDesCaracteres_CheckedChanged);
            // 
            // checkBoxCouleurDeFond
            // 
            this.checkBoxCouleurDeFond.AutoSize = true;
            this.checkBoxCouleurDeFond.Location = new System.Drawing.Point(20, 20);
            this.checkBoxCouleurDeFond.Name = "checkBoxCouleurDeFond";
            this.checkBoxCouleurDeFond.Size = new System.Drawing.Size(101, 17);
            this.checkBoxCouleurDeFond.TabIndex = 0;
            this.checkBoxCouleurDeFond.Text = "Couleur de fond";
            this.checkBoxCouleurDeFond.UseVisualStyleBackColor = true;
            this.checkBoxCouleurDeFond.CheckedChanged += new System.EventHandler(this.checkBoxCouleurDeFond_CheckedChanged);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 41);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(308, 20);
            this.textBox.TabIndex = 3;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // groupBoxFond
            // 
            this.groupBoxFond.Controls.Add(this.radioButtonVert);
            this.groupBoxFond.Controls.Add(this.radioButtonRouge);
            this.groupBoxFond.Controls.Add(this.radioButtonBleu);
            this.groupBoxFond.Location = new System.Drawing.Point(22, 164);
            this.groupBoxFond.Name = "groupBoxFond";
            this.groupBoxFond.Size = new System.Drawing.Size(80, 100);
            this.groupBoxFond.TabIndex = 4;
            this.groupBoxFond.TabStop = false;
            this.groupBoxFond.Text = "Fond";
            this.groupBoxFond.Visible = false;
            // 
            // radioButtonVert
            // 
            this.radioButtonVert.AutoSize = true;
            this.radioButtonVert.Location = new System.Drawing.Point(6, 42);
            this.radioButtonVert.Name = "radioButtonVert";
            this.radioButtonVert.Size = new System.Drawing.Size(44, 17);
            this.radioButtonVert.TabIndex = 1;
            this.radioButtonVert.TabStop = true;
            this.radioButtonVert.Text = "Vert";
            this.radioButtonVert.UseVisualStyleBackColor = true;
            this.radioButtonVert.CheckedChanged += new System.EventHandler(this.radioButtonVert_CheckedChanged);
            // 
            // radioButtonRouge
            // 
            this.radioButtonRouge.AutoSize = true;
            this.radioButtonRouge.Location = new System.Drawing.Point(6, 19);
            this.radioButtonRouge.Name = "radioButtonRouge";
            this.radioButtonRouge.Size = new System.Drawing.Size(57, 17);
            this.radioButtonRouge.TabIndex = 0;
            this.radioButtonRouge.TabStop = true;
            this.radioButtonRouge.Text = "Rouge";
            this.radioButtonRouge.UseVisualStyleBackColor = true;
            this.radioButtonRouge.CheckedChanged += new System.EventHandler(this.radioButtonRouge_CheckedChanged);
            // 
            // radioButtonBleu
            // 
            this.radioButtonBleu.AutoSize = true;
            this.radioButtonBleu.Location = new System.Drawing.Point(6, 65);
            this.radioButtonBleu.Name = "radioButtonBleu";
            this.radioButtonBleu.Size = new System.Drawing.Size(46, 17);
            this.radioButtonBleu.TabIndex = 2;
            this.radioButtonBleu.TabStop = true;
            this.radioButtonBleu.Text = "Bleu";
            this.radioButtonBleu.UseVisualStyleBackColor = true;
            this.radioButtonBleu.CheckedChanged += new System.EventHandler(this.radioButtonBleu_CheckedChanged);
            // 
            // groupBoxCaracteres
            // 
            this.groupBoxCaracteres.Controls.Add(this.radioButtonNoir);
            this.groupBoxCaracteres.Controls.Add(this.radioButtonRougeCaractere);
            this.groupBoxCaracteres.Controls.Add(this.radioButtonBlanc);
            this.groupBoxCaracteres.Location = new System.Drawing.Point(117, 164);
            this.groupBoxCaracteres.Name = "groupBoxCaracteres";
            this.groupBoxCaracteres.Size = new System.Drawing.Size(80, 100);
            this.groupBoxCaracteres.TabIndex = 5;
            this.groupBoxCaracteres.TabStop = false;
            this.groupBoxCaracteres.Text = "Caractères";
            this.groupBoxCaracteres.Visible = false;
            // 
            // radioButtonNoir
            // 
            this.radioButtonNoir.AutoSize = true;
            this.radioButtonNoir.Location = new System.Drawing.Point(12, 65);
            this.radioButtonNoir.Name = "radioButtonNoir";
            this.radioButtonNoir.Size = new System.Drawing.Size(44, 17);
            this.radioButtonNoir.TabIndex = 3;
            this.radioButtonNoir.TabStop = true;
            this.radioButtonNoir.Text = "Noir";
            this.radioButtonNoir.UseVisualStyleBackColor = true;
            this.radioButtonNoir.CheckedChanged += new System.EventHandler(this.radioButtonNoir_CheckedChanged);
            // 
            // radioButtonRougeCaractere
            // 
            this.radioButtonRougeCaractere.AutoSize = true;
            this.radioButtonRougeCaractere.Location = new System.Drawing.Point(12, 19);
            this.radioButtonRougeCaractere.Name = "radioButtonRougeCaractere";
            this.radioButtonRougeCaractere.Size = new System.Drawing.Size(57, 17);
            this.radioButtonRougeCaractere.TabIndex = 2;
            this.radioButtonRougeCaractere.TabStop = true;
            this.radioButtonRougeCaractere.Text = "Rouge";
            this.radioButtonRougeCaractere.UseVisualStyleBackColor = true;
            this.radioButtonRougeCaractere.CheckedChanged += new System.EventHandler(this.radioButtonRougeCaractere_CheckedChanged);
            // 
            // radioButtonBlanc
            // 
            this.radioButtonBlanc.AutoSize = true;
            this.radioButtonBlanc.Location = new System.Drawing.Point(12, 42);
            this.radioButtonBlanc.Name = "radioButtonBlanc";
            this.radioButtonBlanc.Size = new System.Drawing.Size(52, 17);
            this.radioButtonBlanc.TabIndex = 1;
            this.radioButtonBlanc.TabStop = true;
            this.radioButtonBlanc.Text = "Blanc";
            this.radioButtonBlanc.UseVisualStyleBackColor = true;
            this.radioButtonBlanc.CheckedChanged += new System.EventHandler(this.radioButtonBlanc_CheckedChanged);
            // 
            // groupBoxCasse
            // 
            this.groupBoxCasse.Controls.Add(this.radioButtonMajuscules);
            this.groupBoxCasse.Controls.Add(this.radioButtonMinuscules);
            this.groupBoxCasse.Location = new System.Drawing.Point(203, 198);
            this.groupBoxCasse.Name = "groupBoxCasse";
            this.groupBoxCasse.Size = new System.Drawing.Size(80, 66);
            this.groupBoxCasse.TabIndex = 6;
            this.groupBoxCasse.TabStop = false;
            this.groupBoxCasse.Text = "Casse";
            this.groupBoxCasse.Visible = false;
            // 
            // radioButtonMajuscules
            // 
            this.radioButtonMajuscules.AutoSize = true;
            this.radioButtonMajuscules.Location = new System.Drawing.Point(6, 43);
            this.radioButtonMajuscules.Name = "radioButtonMajuscules";
            this.radioButtonMajuscules.Size = new System.Drawing.Size(78, 17);
            this.radioButtonMajuscules.TabIndex = 3;
            this.radioButtonMajuscules.TabStop = true;
            this.radioButtonMajuscules.Text = "Majuscules";
            this.radioButtonMajuscules.UseVisualStyleBackColor = true;
            this.radioButtonMajuscules.CheckedChanged += new System.EventHandler(this.radioButtonMajuscules_CheckedChanged);
            // 
            // radioButtonMinuscules
            // 
            this.radioButtonMinuscules.AutoSize = true;
            this.radioButtonMinuscules.Location = new System.Drawing.Point(6, 20);
            this.radioButtonMinuscules.Name = "radioButtonMinuscules";
            this.radioButtonMinuscules.Size = new System.Drawing.Size(78, 17);
            this.radioButtonMinuscules.TabIndex = 2;
            this.radioButtonMinuscules.TabStop = true;
            this.radioButtonMinuscules.Text = "Minuscules";
            this.radioButtonMinuscules.UseVisualStyleBackColor = true;
            this.radioButtonMinuscules.CheckedChanged += new System.EventHandler(this.radioButtonMinuscules_CheckedChanged);
            // 
            // labelDouble
            // 
            this.labelDouble.AutoSize = true;
            this.labelDouble.Location = new System.Drawing.Point(15, 119);
            this.labelDouble.Name = "labelDouble";
            this.labelDouble.Size = new System.Drawing.Size(0, 13);
            this.labelDouble.TabIndex = 7;
            // 
            // checkBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 276);
            this.Controls.Add(this.labelDouble);
            this.Controls.Add(this.groupBoxCasse);
            this.Controls.Add(this.groupBoxCaracteres);
            this.Controls.Add(this.groupBoxFond);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.groupBoxChoix);
            this.Controls.Add(this.labelTapezVotreTexte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "checkBox";
            this.Text = "CheckBox et RadioButton";
            this.groupBoxChoix.ResumeLayout(false);
            this.groupBoxChoix.PerformLayout();
            this.groupBoxFond.ResumeLayout(false);
            this.groupBoxFond.PerformLayout();
            this.groupBoxCaracteres.ResumeLayout(false);
            this.groupBoxCaracteres.PerformLayout();
            this.groupBoxCasse.ResumeLayout(false);
            this.groupBoxCasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTapezVotreTexte;
        private System.Windows.Forms.GroupBox groupBoxChoix;
        private System.Windows.Forms.CheckBox checkBoxCouleurDeFond;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.CheckBox checkBoxCasse;
        private System.Windows.Forms.CheckBox checkBoxCouleurDesCaracteres;
        private System.Windows.Forms.GroupBox groupBoxFond;
        private System.Windows.Forms.RadioButton radioButtonVert;
        private System.Windows.Forms.RadioButton radioButtonRouge;
        private System.Windows.Forms.RadioButton radioButtonBleu;
        private System.Windows.Forms.GroupBox groupBoxCaracteres;
        private System.Windows.Forms.RadioButton radioButtonNoir;
        private System.Windows.Forms.RadioButton radioButtonRougeCaractere;
        private System.Windows.Forms.RadioButton radioButtonBlanc;
        private System.Windows.Forms.GroupBox groupBoxCasse;
        private System.Windows.Forms.RadioButton radioButtonMajuscules;
        private System.Windows.Forms.RadioButton radioButtonMinuscules;
        private System.Windows.Forms.Label labelDouble;
    }
}


namespace WindowsFormsAppSynthese
{
    partial class synthese
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
            this.components = new System.ComponentModel.Container();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelCapitalEmprunté = new System.Windows.Forms.Label();
            this.labelDuree = new System.Windows.Forms.Label();
            this.labelPeriodicite = new System.Windows.Forms.Label();
            this.labelRemboursements = new System.Windows.Forms.Label();
            this.labelNbDeRemboursement = new System.Windows.Forms.Label();
            this.labelRemboursement = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.labelDuree2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxCapitalEmprunte = new System.Windows.Forms.TextBox();
            this.labelNb = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(35, 23);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // labelCapitalEmprunté
            // 
            this.labelCapitalEmprunté.AutoSize = true;
            this.labelCapitalEmprunté.Location = new System.Drawing.Point(35, 63);
            this.labelCapitalEmprunté.Name = "labelCapitalEmprunté";
            this.labelCapitalEmprunté.Size = new System.Drawing.Size(87, 13);
            this.labelCapitalEmprunté.TabIndex = 1;
            this.labelCapitalEmprunté.Text = "Capital Emprunté";
            // 
            // labelDuree
            // 
            this.labelDuree.AutoSize = true;
            this.labelDuree.Location = new System.Drawing.Point(12, 106);
            this.labelDuree.Name = "labelDuree";
            this.labelDuree.Size = new System.Drawing.Size(90, 13);
            this.labelDuree.TabIndex = 2;
            this.labelDuree.Text = "Durée en mois du";
            // 
            // labelPeriodicite
            // 
            this.labelPeriodicite.AutoSize = true;
            this.labelPeriodicite.Location = new System.Drawing.Point(12, 150);
            this.labelPeriodicite.Name = "labelPeriodicite";
            this.labelPeriodicite.Size = new System.Drawing.Size(146, 13);
            this.labelPeriodicite.TabIndex = 3;
            this.labelPeriodicite.Text = "Périodicité de remboursement";
            // 
            // labelRemboursements
            // 
            this.labelRemboursements.AutoSize = true;
            this.labelRemboursements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemboursements.Location = new System.Drawing.Point(412, 167);
            this.labelRemboursements.Name = "labelRemboursements";
            this.labelRemboursements.Size = new System.Drawing.Size(150, 20);
            this.labelRemboursements.TabIndex = 4;
            this.labelRemboursements.Text = "Remboursements";
            // 
            // labelNbDeRemboursement
            // 
            this.labelNbDeRemboursement.AutoSize = true;
            this.labelNbDeRemboursement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbDeRemboursement.Location = new System.Drawing.Point(353, 166);
            this.labelNbDeRemboursement.Name = "labelNbDeRemboursement";
            this.labelNbDeRemboursement.Size = new System.Drawing.Size(19, 20);
            this.labelNbDeRemboursement.TabIndex = 5;
            this.labelNbDeRemboursement.Text = "1";

            // 
            // labelRemboursement
            // 
            this.labelRemboursement.AutoSize = true;
            this.labelRemboursement.Location = new System.Drawing.Point(452, 227);
            this.labelRemboursement.Name = "labelRemboursement";
            this.labelRemboursement.Size = new System.Drawing.Size(0, 13);
            this.labelRemboursement.TabIndex = 6;
            // 
            // buttonOk
            // 
            this.buttonOk.Enabled = false;
            this.buttonOk.Location = new System.Drawing.Point(520, 58);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(81, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "Sauvegarder";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.radioButton9);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Location = new System.Drawing.Point(367, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 123);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taux d\'interet";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(25, 63);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(42, 17);
            this.radioButton8.TabIndex = 4;
            this.radioButton8.TabStop = true;
            this.radioButton8.Tag = "8";
            this.radioButton8.Text = "8 %";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(25, 100);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(42, 17);
            this.radioButton9.TabIndex = 2;
            this.radioButton9.TabStop = true;
            this.radioButton9.Tag = "9";
            this.radioButton9.Text = "9 %";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(25, 28);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(42, 17);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.Tag = "7";
            this.radioButton7.Text = "7 %";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // labelDuree2
            // 
            this.labelDuree2.AutoSize = true;
            this.labelDuree2.Location = new System.Drawing.Point(12, 121);
            this.labelDuree2.Name = "labelDuree2";
            this.labelDuree2.Size = new System.Drawing.Size(79, 13);
            this.labelDuree2.TabIndex = 10;
            this.labelDuree2.Text = "remboursement";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 166);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 69);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(164, 23);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 12;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // textBoxCapitalEmprunte
            // 
            this.textBoxCapitalEmprunte.Location = new System.Drawing.Point(164, 56);
            this.textBoxCapitalEmprunte.Name = "textBoxCapitalEmprunte";
            this.textBoxCapitalEmprunte.Size = new System.Drawing.Size(100, 20);
            this.textBoxCapitalEmprunte.TabIndex = 13;
            this.textBoxCapitalEmprunte.TextChanged += new System.EventHandler(this.textBoxCapitalEmprunte_TextChanged);
            // 
            // labelNb
            // 
            this.labelNb.AutoSize = true;
            this.labelNb.Location = new System.Drawing.Point(138, 106);
            this.labelNb.Name = "labelNb";
            this.labelNb.Size = new System.Drawing.Size(13, 13);
            this.labelNb.TabIndex = 14;
            this.labelNb.Text = "1";
            this.labelNb.TextChanged += new System.EventHandler(this.labelNb_TextChanged);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(184, 106);
            this.hScrollBar1.Maximum = 150;
            this.hScrollBar1.Minimum = 1;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(160, 17);
            this.hScrollBar1.TabIndex = 15;
            this.hScrollBar1.Value = 1;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // synthese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 279);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.labelNb);
            this.Controls.Add(this.textBoxCapitalEmprunte);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelDuree2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelRemboursement);
            this.Controls.Add(this.labelNbDeRemboursement);
            this.Controls.Add(this.labelRemboursements);
            this.Controls.Add(this.labelPeriodicite);
            this.Controls.Add(this.labelDuree);
            this.Controls.Add(this.labelCapitalEmprunté);
            this.Controls.Add(this.labelNom);
            this.Name = "synthese";
            this.Text = "Emprunts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.synthese_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelCapitalEmprunté;
        private System.Windows.Forms.Label labelDuree;
        private System.Windows.Forms.Label labelPeriodicite;
        private System.Windows.Forms.Label labelRemboursements;
        private System.Windows.Forms.Label labelNbDeRemboursement;
        private System.Windows.Forms.Label labelRemboursement;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Label labelDuree2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxCapitalEmprunte;
        private System.Windows.Forms.Label labelNb;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}


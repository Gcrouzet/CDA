namespace WindowsFormsAppListBoxComboBox
{
    partial class listboxCombobox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listboxCombobox));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonFlecheBas = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.labelCible = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonToutAjouter = new System.Windows.Forms.Button();
            this.buttonEnlever = new System.Windows.Forms.Button();
            this.buttonToutEnlever = new System.Windows.Forms.Button();
            this.buttonFlecheHaut = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(223, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 173);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonFlecheBas
            // 
            this.buttonFlecheBas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFlecheBas.BackgroundImage")));
            this.buttonFlecheBas.Location = new System.Drawing.Point(257, 235);
            this.buttonFlecheBas.Name = "buttonFlecheBas";
            this.buttonFlecheBas.Size = new System.Drawing.Size(30, 31);
            this.buttonFlecheBas.TabIndex = 1;
            this.buttonFlecheBas.UseVisualStyleBackColor = true;
            this.buttonFlecheBas.Click += new System.EventHandler(this.buttonFlecheBas_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(42, 22);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(41, 13);
            this.labelSource.TabIndex = 3;
            this.labelSource.Text = "Source";
            // 
            // labelCible
            // 
            this.labelCible.AutoSize = true;
            this.labelCible.Location = new System.Drawing.Point(268, 22);
            this.labelCible.Name = "labelCible";
            this.labelCible.Size = new System.Drawing.Size(30, 13);
            this.labelCible.TabIndex = 4;
            this.labelCible.Text = "Cible";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Enabled = false;
            this.buttonAjouter.Location = new System.Drawing.Point(139, 45);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouter.TabIndex = 5;
            this.buttonAjouter.Text = ">";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonToutAjouter
            // 
            this.buttonToutAjouter.Location = new System.Drawing.Point(139, 74);
            this.buttonToutAjouter.Name = "buttonToutAjouter";
            this.buttonToutAjouter.Size = new System.Drawing.Size(75, 23);
            this.buttonToutAjouter.TabIndex = 6;
            this.buttonToutAjouter.Text = ">>";
            this.buttonToutAjouter.UseVisualStyleBackColor = true;
            this.buttonToutAjouter.Click += new System.EventHandler(this.buttonToutAjouter_Click);
            // 
            // buttonEnlever
            // 
            this.buttonEnlever.Enabled = false;
            this.buttonEnlever.Location = new System.Drawing.Point(139, 158);
            this.buttonEnlever.Name = "buttonEnlever";
            this.buttonEnlever.Size = new System.Drawing.Size(75, 23);
            this.buttonEnlever.TabIndex = 7;
            this.buttonEnlever.Text = "<";
            this.buttonEnlever.UseVisualStyleBackColor = true;
            this.buttonEnlever.Click += new System.EventHandler(this.buttonEnlever_Click);
            // 
            // buttonToutEnlever
            // 
            this.buttonToutEnlever.Location = new System.Drawing.Point(139, 197);
            this.buttonToutEnlever.Name = "buttonToutEnlever";
            this.buttonToutEnlever.Size = new System.Drawing.Size(75, 23);
            this.buttonToutEnlever.TabIndex = 8;
            this.buttonToutEnlever.Text = "<<";
            this.buttonToutEnlever.UseVisualStyleBackColor = true;
            this.buttonToutEnlever.Click += new System.EventHandler(this.buttonToutEnlever_Click);
            // 
            // buttonFlecheHaut
            // 
            this.buttonFlecheHaut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFlecheHaut.BackgroundImage")));
            this.buttonFlecheHaut.Location = new System.Drawing.Point(293, 235);
            this.buttonFlecheHaut.Name = "buttonFlecheHaut";
            this.buttonFlecheHaut.Size = new System.Drawing.Size(30, 31);
            this.buttonFlecheHaut.TabIndex = 9;
            this.buttonFlecheHaut.UseVisualStyleBackColor = true;
            this.buttonFlecheHaut.Click += new System.EventHandler(this.buttonFlecheHaut_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // listboxCombobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 275);
            this.Controls.Add(this.buttonFlecheHaut);
            this.Controls.Add(this.buttonToutEnlever);
            this.Controls.Add(this.buttonEnlever);
            this.Controls.Add(this.buttonToutAjouter);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.labelCible);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonFlecheBas);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "listboxCombobox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les listes";
            this.Load += new System.EventHandler(this.listboxCombobox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonFlecheBas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelCible;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonToutAjouter;
        private System.Windows.Forms.Button buttonEnlever;
        private System.Windows.Forms.Button buttonToutEnlever;
        private System.Windows.Forms.Button buttonFlecheHaut;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}


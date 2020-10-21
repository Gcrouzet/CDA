namespace WindowsFormsAppListBox
{
    partial class ListBox
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
            this.labelNouvelElément = new System.Windows.Forms.Label();
            this.labelProprietes = new System.Windows.Forms.Label();
            this.labelIndexElément = new System.Windows.Forms.Label();
            this.labelLstListe = new System.Windows.Forms.Label();
            this.buttonAjout = new System.Windows.Forms.Button();
            this.textBoxAjout = new System.Windows.Forms.TextBox();
            this.listBoxLstListe = new System.Windows.Forms.ListBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.buttonSelectionner = new System.Windows.Forms.Button();
            this.buttonVider = new System.Windows.Forms.Button();
            this.errorProviderIndex = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelItemCount = new System.Windows.Forms.Label();
            this.labelSelected = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.textBoxItemCount = new System.Windows.Forms.TextBox();
            this.textBoxSelectedIndex = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.errorProviderAjout = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAjout)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNouvelElément
            // 
            this.labelNouvelElément.AutoSize = true;
            this.labelNouvelElément.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNouvelElément.Location = new System.Drawing.Point(12, 29);
            this.labelNouvelElément.Name = "labelNouvelElément";
            this.labelNouvelElément.Size = new System.Drawing.Size(96, 13);
            this.labelNouvelElément.TabIndex = 0;
            this.labelNouvelElément.Text = "Nouvel Elément";
            // 
            // labelProprietes
            // 
            this.labelProprietes.AutoSize = true;
            this.labelProprietes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProprietes.Location = new System.Drawing.Point(184, 121);
            this.labelProprietes.Name = "labelProprietes";
            this.labelProprietes.Size = new System.Drawing.Size(64, 13);
            this.labelProprietes.TabIndex = 1;
            this.labelProprietes.Text = "Propriétés";
            // 
            // labelIndexElément
            // 
            this.labelIndexElément.AutoSize = true;
            this.labelIndexElément.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndexElément.Location = new System.Drawing.Point(184, 29);
            this.labelIndexElément.Name = "labelIndexElément";
            this.labelIndexElément.Size = new System.Drawing.Size(87, 13);
            this.labelIndexElément.TabIndex = 2;
            this.labelIndexElément.Text = "Index Elément";
            // 
            // labelLstListe
            // 
            this.labelLstListe.AutoSize = true;
            this.labelLstListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLstListe.Location = new System.Drawing.Point(12, 121);
            this.labelLstListe.Name = "labelLstListe";
            this.labelLstListe.Size = new System.Drawing.Size(51, 13);
            this.labelLstListe.TabIndex = 3;
            this.labelLstListe.Text = "LstListe";
            // 
            // buttonAjout
            // 
            this.buttonAjout.Enabled = false;
            this.buttonAjout.Location = new System.Drawing.Point(16, 95);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(100, 23);
            this.buttonAjout.TabIndex = 4;
            this.buttonAjout.Text = "Ajout liste";
            this.buttonAjout.UseVisualStyleBackColor = true;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click);
            // 
            // textBoxAjout
            // 
            this.textBoxAjout.Location = new System.Drawing.Point(16, 57);
            this.textBoxAjout.Name = "textBoxAjout";
            this.textBoxAjout.Size = new System.Drawing.Size(100, 20);
            this.textBoxAjout.TabIndex = 5;
            this.textBoxAjout.Click += new System.EventHandler(this.textBoxAjout_Click);
            this.textBoxAjout.TextChanged += new System.EventHandler(this.textBoxAjout_TextChanged);
            // 
            // listBoxLstListe
            // 
            this.listBoxLstListe.FormattingEnabled = true;
            this.listBoxLstListe.Location = new System.Drawing.Point(16, 146);
            this.listBoxLstListe.Name = "listBoxLstListe";
            this.listBoxLstListe.Size = new System.Drawing.Size(120, 95);
            this.listBoxLstListe.TabIndex = 6;
            this.listBoxLstListe.SelectedIndexChanged += new System.EventHandler(this.listBoxLstListe_SelectedIndexChanged);
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(187, 56);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(34, 20);
            this.textBoxIndex.TabIndex = 7;
            this.textBoxIndex.Click += new System.EventHandler(this.textBoxIndex_Click);
            // 
            // buttonSelectionner
            // 
            this.buttonSelectionner.Enabled = false;
            this.buttonSelectionner.Location = new System.Drawing.Point(254, 57);
            this.buttonSelectionner.Name = "buttonSelectionner";
            this.buttonSelectionner.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectionner.TabIndex = 8;
            this.buttonSelectionner.Text = "Sélectionner";
            this.buttonSelectionner.UseVisualStyleBackColor = true;
            this.buttonSelectionner.Click += new System.EventHandler(this.buttonSelectionner_Click);
            // 
            // buttonVider
            // 
            this.buttonVider.Enabled = false;
            this.buttonVider.Location = new System.Drawing.Point(254, 86);
            this.buttonVider.Name = "buttonVider";
            this.buttonVider.Size = new System.Drawing.Size(75, 23);
            this.buttonVider.TabIndex = 9;
            this.buttonVider.Text = "Vider la liste";
            this.buttonVider.UseVisualStyleBackColor = true;
            this.buttonVider.Click += new System.EventHandler(this.buttonVider_Click);
            // 
            // errorProviderIndex
            // 
            this.errorProviderIndex.ContainerControl = this;
            // 
            // labelItemCount
            // 
            this.labelItemCount.AutoSize = true;
            this.labelItemCount.Location = new System.Drawing.Point(187, 158);
            this.labelItemCount.Name = "labelItemCount";
            this.labelItemCount.Size = new System.Drawing.Size(63, 13);
            this.labelItemCount.TabIndex = 10;
            this.labelItemCount.Text = "Items.Count";
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Location = new System.Drawing.Point(184, 188);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(75, 13);
            this.labelSelected.TabIndex = 11;
            this.labelSelected.Text = "SelectedIndex";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(193, 217);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 13);
            this.labelText.TabIndex = 12;
            this.labelText.Text = "Text";
            // 
            // textBoxItemCount
            // 
            this.textBoxItemCount.Enabled = false;
            this.textBoxItemCount.Location = new System.Drawing.Point(265, 158);
            this.textBoxItemCount.Name = "textBoxItemCount";
            this.textBoxItemCount.ReadOnly = true;
            this.textBoxItemCount.Size = new System.Drawing.Size(20, 20);
            this.textBoxItemCount.TabIndex = 13;
            // 
            // textBoxSelectedIndex
            // 
            this.textBoxSelectedIndex.Enabled = false;
            this.textBoxSelectedIndex.Location = new System.Drawing.Point(265, 188);
            this.textBoxSelectedIndex.Name = "textBoxSelectedIndex";
            this.textBoxSelectedIndex.ReadOnly = true;
            this.textBoxSelectedIndex.Size = new System.Drawing.Size(20, 20);
            this.textBoxSelectedIndex.TabIndex = 14;
            // 
            // textBoxText
            // 
            this.textBoxText.Enabled = false;
            this.textBoxText.Location = new System.Drawing.Point(265, 217);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.ReadOnly = true;
            this.textBoxText.Size = new System.Drawing.Size(49, 20);
            this.textBoxText.TabIndex = 15;
            // 
            // errorProviderAjout
            // 
            this.errorProviderAjout.ContainerControl = this;
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 253);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxSelectedIndex);
            this.Controls.Add(this.textBoxItemCount);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelSelected);
            this.Controls.Add(this.labelItemCount);
            this.Controls.Add(this.buttonVider);
            this.Controls.Add(this.buttonSelectionner);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.listBoxLstListe);
            this.Controls.Add(this.textBoxAjout);
            this.Controls.Add(this.buttonAjout);
            this.Controls.Add(this.labelLstListe);
            this.Controls.Add(this.labelIndexElément);
            this.Controls.Add(this.labelProprietes);
            this.Controls.Add(this.labelNouvelElément);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListBox";
            this.Text = "Les listes et leurs propriétés";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAjout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNouvelElément;
        private System.Windows.Forms.Label labelProprietes;
        private System.Windows.Forms.Label labelIndexElément;
        private System.Windows.Forms.Label labelLstListe;
        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.TextBox textBoxAjout;
        private System.Windows.Forms.ListBox listBoxLstListe;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Button buttonSelectionner;
        private System.Windows.Forms.Button buttonVider;
        private System.Windows.Forms.ErrorProvider errorProviderIndex;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.TextBox textBoxSelectedIndex;
        private System.Windows.Forms.TextBox textBoxItemCount;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelSelected;
        private System.Windows.Forms.Label labelItemCount;
        private System.Windows.Forms.ErrorProvider errorProviderAjout;
    }
}


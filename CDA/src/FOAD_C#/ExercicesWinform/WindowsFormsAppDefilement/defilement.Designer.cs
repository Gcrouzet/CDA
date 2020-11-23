namespace WindowsFormsAppDefilement
{
    partial class Defilement
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
            this.hScrollBarRouge = new System.Windows.Forms.HScrollBar();
            this.hScrollBarVert = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBleu = new System.Windows.Forms.HScrollBar();
            this.textBoxRouge = new System.Windows.Forms.TextBox();
            this.textBoxVert = new System.Windows.Forms.TextBox();
            this.textBoxBleu = new System.Windows.Forms.TextBox();
            this.labelRouge = new System.Windows.Forms.Label();
            this.labelVert = new System.Windows.Forms.Label();
            this.labelBleu = new System.Windows.Forms.Label();
            this.textBoxEtiquette = new System.Windows.Forms.TextBox();
            this.numericUpDownRouge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVert = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBleu = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBleu)).BeginInit();
            this.SuspendLayout();
            // 
            // hScrollBarRouge
            // 
            this.hScrollBarRouge.Location = new System.Drawing.Point(63, 65);
            this.hScrollBarRouge.Maximum = 264;
            this.hScrollBarRouge.Name = "hScrollBarRouge";
            this.hScrollBarRouge.Size = new System.Drawing.Size(207, 17);
            this.hScrollBarRouge.TabIndex = 0;
            this.hScrollBarRouge.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarRouge_Scroll);
            // 
            // hScrollBarVert
            // 
            this.hScrollBarVert.Location = new System.Drawing.Point(63, 106);
            this.hScrollBarVert.Maximum = 264;
            this.hScrollBarVert.Name = "hScrollBarVert";
            this.hScrollBarVert.Size = new System.Drawing.Size(207, 17);
            this.hScrollBarVert.TabIndex = 1;
            this.hScrollBarVert.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarVert_Scroll);
            // 
            // hScrollBarBleu
            // 
            this.hScrollBarBleu.Location = new System.Drawing.Point(63, 149);
            this.hScrollBarBleu.Maximum = 264;
            this.hScrollBarBleu.Name = "hScrollBarBleu";
            this.hScrollBarBleu.Size = new System.Drawing.Size(207, 17);
            this.hScrollBarBleu.TabIndex = 2;
            this.hScrollBarBleu.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarBleu_Scroll);
            // 
            // textBoxRouge
            // 
            this.textBoxRouge.Enabled = false;
            this.textBoxRouge.Location = new System.Drawing.Point(353, 62);
            this.textBoxRouge.Name = "textBoxRouge";
            this.textBoxRouge.ReadOnly = true;
            this.textBoxRouge.Size = new System.Drawing.Size(43, 20);
            this.textBoxRouge.TabIndex = 6;
            // 
            // textBoxVert
            // 
            this.textBoxVert.Enabled = false;
            this.textBoxVert.Location = new System.Drawing.Point(353, 103);
            this.textBoxVert.Name = "textBoxVert";
            this.textBoxVert.ReadOnly = true;
            this.textBoxVert.Size = new System.Drawing.Size(43, 20);
            this.textBoxVert.TabIndex = 7;
            // 
            // textBoxBleu
            // 
            this.textBoxBleu.Enabled = false;
            this.textBoxBleu.Location = new System.Drawing.Point(353, 146);
            this.textBoxBleu.Name = "textBoxBleu";
            this.textBoxBleu.ReadOnly = true;
            this.textBoxBleu.Size = new System.Drawing.Size(43, 20);
            this.textBoxBleu.TabIndex = 8;
            // 
            // labelRouge
            // 
            this.labelRouge.AutoSize = true;
            this.labelRouge.Location = new System.Drawing.Point(12, 69);
            this.labelRouge.Name = "labelRouge";
            this.labelRouge.Size = new System.Drawing.Size(39, 13);
            this.labelRouge.TabIndex = 9;
            this.labelRouge.Text = "Rouge";
            // 
            // labelVert
            // 
            this.labelVert.AutoSize = true;
            this.labelVert.Location = new System.Drawing.Point(12, 110);
            this.labelVert.Name = "labelVert";
            this.labelVert.Size = new System.Drawing.Size(26, 13);
            this.labelVert.TabIndex = 10;
            this.labelVert.Text = "Vert";
            // 
            // labelBleu
            // 
            this.labelBleu.AutoSize = true;
            this.labelBleu.Location = new System.Drawing.Point(12, 153);
            this.labelBleu.Name = "labelBleu";
            this.labelBleu.Size = new System.Drawing.Size(28, 13);
            this.labelBleu.TabIndex = 11;
            this.labelBleu.Text = "Bleu";
            // 
            // textBoxEtiquette
            // 
            this.textBoxEtiquette.Enabled = false;
            this.textBoxEtiquette.Location = new System.Drawing.Point(28, 183);
            this.textBoxEtiquette.Multiline = true;
            this.textBoxEtiquette.Name = "textBoxEtiquette";
            this.textBoxEtiquette.ReadOnly = true;
            this.textBoxEtiquette.Size = new System.Drawing.Size(368, 60);
            this.textBoxEtiquette.TabIndex = 12;
            // 
            // numericUpDownRouge
            // 
            this.numericUpDownRouge.Location = new System.Drawing.Point(284, 62);
            this.numericUpDownRouge.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRouge.Name = "numericUpDownRouge";
            this.numericUpDownRouge.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownRouge.TabIndex = 13;
            this.numericUpDownRouge.ValueChanged += new System.EventHandler(this.numericUpDownRouge_ValueChanged);
            // 
            // numericUpDownVert
            // 
            this.numericUpDownVert.Location = new System.Drawing.Point(284, 103);
            this.numericUpDownVert.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownVert.Name = "numericUpDownVert";
            this.numericUpDownVert.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownVert.TabIndex = 14;
            this.numericUpDownVert.ValueChanged += new System.EventHandler(this.numericUpDownVert_ValueChanged);
            // 
            // numericUpDownBleu
            // 
            this.numericUpDownBleu.Location = new System.Drawing.Point(284, 146);
            this.numericUpDownBleu.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBleu.Name = "numericUpDownBleu";
            this.numericUpDownBleu.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownBleu.TabIndex = 15;
            this.numericUpDownBleu.ValueChanged += new System.EventHandler(this.numericUpDownBleu_ValueChanged);
            // 
            // defilement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 255);
            this.Controls.Add(this.numericUpDownBleu);
            this.Controls.Add(this.numericUpDownVert);
            this.Controls.Add(this.numericUpDownRouge);
            this.Controls.Add(this.textBoxEtiquette);
            this.Controls.Add(this.labelBleu);
            this.Controls.Add(this.labelVert);
            this.Controls.Add(this.labelRouge);
            this.Controls.Add(this.textBoxBleu);
            this.Controls.Add(this.textBoxVert);
            this.Controls.Add(this.textBoxRouge);
            this.Controls.Add(this.hScrollBarBleu);
            this.Controls.Add(this.hScrollBarVert);
            this.Controls.Add(this.hScrollBarRouge);
            this.Name = "defilement";
            this.Text = "Defilement";
            this.Load += new System.EventHandler(this.defilement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBleu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBarRouge;
        private System.Windows.Forms.HScrollBar hScrollBarVert;
        private System.Windows.Forms.HScrollBar hScrollBarBleu;
        private System.Windows.Forms.TextBox textBoxRouge;
        private System.Windows.Forms.TextBox textBoxVert;
        private System.Windows.Forms.TextBox textBoxBleu;
        private System.Windows.Forms.Label labelRouge;
        private System.Windows.Forms.Label labelVert;
        private System.Windows.Forms.Label labelBleu;
        private System.Windows.Forms.TextBox textBoxEtiquette;
        private System.Windows.Forms.NumericUpDown numericUpDownRouge;
        private System.Windows.Forms.NumericUpDown numericUpDownVert;
        private System.Windows.Forms.NumericUpDown numericUpDownBleu;
    }
}


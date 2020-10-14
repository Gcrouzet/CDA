namespace controleSaisie
{
    partial class Validation
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMontant = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.labeltextNom = new System.Windows.Forms.Label();
            this.labeltextDate = new System.Windows.Forms.Label();
            this.labeltextMontant = new System.Windows.Forms.Label();
            this.labeltextCP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(71, 144);
            this.buttonOK.MaximumSize = new System.Drawing.Size(94, 30);
            this.buttonOK.MinimumSize = new System.Drawing.Size(94, 30);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(94, 30);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(12, 44);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom :";
            this.labelNom.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 67);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 13);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date :";
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Location = new System.Drawing.Point(12, 89);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(52, 13);
            this.labelMontant.TabIndex = 3;
            this.labelMontant.Text = "Montant :";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(12, 111);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(27, 13);
            this.labelCode.TabIndex = 4;
            this.labelCode.Text = "CP :";
            // 
            // labeltextNom
            // 
            this.labeltextNom.AutoSize = true;
            this.labeltextNom.Location = new System.Drawing.Point(68, 44);
            this.labeltextNom.Name = "labeltextNom";
            this.labeltextNom.Size = new System.Drawing.Size(68, 13);
            this.labeltextNom.TabIndex = 5;
            this.labeltextNom.Text = "labeltextNom";
            // 
            // labeltextDate
            // 
            this.labeltextDate.AutoSize = true;
            this.labeltextDate.Location = new System.Drawing.Point(68, 67);
            this.labeltextDate.Name = "labeltextDate";
            this.labeltextDate.Size = new System.Drawing.Size(69, 13);
            this.labeltextDate.TabIndex = 6;
            this.labeltextDate.Text = "labeltextDate";
            // 
            // labeltextMontant
            // 
            this.labeltextMontant.AutoSize = true;
            this.labeltextMontant.Location = new System.Drawing.Point(68, 89);
            this.labeltextMontant.Name = "labeltextMontant";
            this.labeltextMontant.Size = new System.Drawing.Size(85, 13);
            this.labeltextMontant.TabIndex = 7;
            this.labeltextMontant.Text = "labeltextMontant";
            // 
            // labeltextCP
            // 
            this.labeltextCP.AutoSize = true;
            this.labeltextCP.Location = new System.Drawing.Point(68, 111);
            this.labeltextCP.Name = "labeltextCP";
            this.labeltextCP.Size = new System.Drawing.Size(60, 13);
            this.labeltextCP.TabIndex = 8;
            this.labeltextCP.Text = "labeltextCP";
            // 
            // Validation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 186);
            this.Controls.Add(this.labeltextCP);
            this.Controls.Add(this.labeltextMontant);
            this.Controls.Add(this.labeltextDate);
            this.Controls.Add(this.labeltextNom);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Validation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validation effectuée";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.Label labelCode;
        public System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labeltextNom;
        private System.Windows.Forms.Label labeltextDate;
        private System.Windows.Forms.Label labeltextMontant;
        private System.Windows.Forms.Label labeltextCP;
    }
}

namespace WindowsFormsAppMDI
{
    partial class FormSaisie
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSaisie = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.errorProviderSaisie = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSaisie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tapez votre texte";
            // 
            // textBoxSaisie
            // 
            this.textBoxSaisie.Location = new System.Drawing.Point(31, 29);
            this.textBoxSaisie.Name = "textBoxSaisie";
            this.textBoxSaisie.Size = new System.Drawing.Size(256, 20);
            this.textBoxSaisie.TabIndex = 1;
            this.textBoxSaisie.TextChanged += new System.EventHandler(this.textBoxVotreTexte_TextChanged);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(315, 29);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(101, 23);
            this.buttonValider.TabIndex = 2;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // errorProviderSaisie
            // 
            this.errorProviderSaisie.ContainerControl = this;
            // 
            // FormSaisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 70);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxSaisie);
            this.Controls.Add(this.label1);
            this.Name = "FormSaisie";
            this.Text = "Saisie";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSaisie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSaisie;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.ErrorProvider errorProviderSaisie;
    }
}
namespace controleSaisie
{
    partial class FIN
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
            this.buttonOui = new System.Windows.Forms.Button();
            this.buttonNon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOui
            // 
            this.buttonOui.Location = new System.Drawing.Point(12, 88);
            this.buttonOui.Name = "buttonOui";
            this.buttonOui.Size = new System.Drawing.Size(74, 22);
            this.buttonOui.TabIndex = 0;
            this.buttonOui.Text = "Oui";
            this.buttonOui.UseVisualStyleBackColor = true;
            this.buttonOui.Click += new System.EventHandler(this.buttonOui_Click);
            // 
            // buttonNon
            // 
            this.buttonNon.Location = new System.Drawing.Point(92, 88);
            this.buttonNon.MaximumSize = new System.Drawing.Size(79, 22);
            this.buttonNon.MinimumSize = new System.Drawing.Size(79, 22);
            this.buttonNon.Name = "buttonNon";
            this.buttonNon.Size = new System.Drawing.Size(79, 22);
            this.buttonNon.TabIndex = 1;
            this.buttonNon.Text = "Non";
            this.buttonNon.UseVisualStyleBackColor = true;
            this.buttonNon.Click += new System.EventHandler(this.buttonNon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fin de l\'application";
            // 
            // FIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 115);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNon);
            this.Controls.Add(this.buttonOui);
            this.Name = "FIN";
            this.Text = "FIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOui;
        private System.Windows.Forms.Button buttonNon;
        private System.Windows.Forms.Label label1;
    }
}
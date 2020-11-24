
namespace WindowsFormsAppMDI
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidentifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase1 = new System.Windows.Forms.ToolStripMenuItem();
            this.additionneurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase2 = new System.Windows.Forms.ToolStripMenuItem();
            this.controleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase3 = new System.Windows.Forms.ToolStripMenuItem();
            this.casesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.défilementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.synthèseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenetres = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sidentifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSIdentifier = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButtonPhase3 = new System.Windows.Forms.ToolStripSplitButton();
            this.casesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.défilementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.synthèseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDerniereOperation = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.phase1,
            this.phase2,
            this.phase3,
            this.fenetres});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1086, 24);
            this.menuStripMain.TabIndex = 3;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidentifierToolStripMenuItem1,
            this.quitterToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // sidentifierToolStripMenuItem1
            // 
            this.sidentifierToolStripMenuItem1.Name = "sidentifierToolStripMenuItem1";
            this.sidentifierToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.sidentifierToolStripMenuItem1.Text = "S\'identifier";
            this.sidentifierToolStripMenuItem1.Click += new System.EventHandler(this.sidentifierToolStripMenuItem1_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // phase1
            // 
            this.phase1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.additionneurToolStripMenuItem});
            this.phase1.Enabled = false;
            this.phase1.Name = "phase1";
            this.phase1.Size = new System.Drawing.Size(59, 20);
            this.phase1.Text = "Phase 1";
            // 
            // additionneurToolStripMenuItem
            // 
            this.additionneurToolStripMenuItem.Name = "additionneurToolStripMenuItem";
            this.additionneurToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.additionneurToolStripMenuItem.Text = "Additionneur";
            this.additionneurToolStripMenuItem.Click += new System.EventHandler(this.additionneurToolStripMenuItem_Click);
            // 
            // phase2
            // 
            this.phase2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controleToolStripMenuItem});
            this.phase2.Enabled = false;
            this.phase2.Name = "phase2";
            this.phase2.Size = new System.Drawing.Size(59, 20);
            this.phase2.Text = "Phase 2";
            // 
            // controleToolStripMenuItem
            // 
            this.controleToolStripMenuItem.Name = "controleToolStripMenuItem";
            this.controleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.controleToolStripMenuItem.Text = "Controle";
            this.controleToolStripMenuItem.Click += new System.EventHandler(this.controleToolStripMenuItem_Click);
            // 
            // phase3
            // 
            this.phase3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casesToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.comboboxToolStripMenuItem,
            this.défilementToolStripMenuItem,
            this.toolStripSeparator2,
            this.synthèseToolStripMenuItem});
            this.phase3.Enabled = false;
            this.phase3.Name = "phase3";
            this.phase3.Size = new System.Drawing.Size(59, 20);
            this.phase3.Text = "Phase 3";
            // 
            // casesToolStripMenuItem
            // 
            this.casesToolStripMenuItem.Name = "casesToolStripMenuItem";
            this.casesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.casesToolStripMenuItem.Text = "Cases";
            this.casesToolStripMenuItem.Click += new System.EventHandler(this.casesToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // comboboxToolStripMenuItem
            // 
            this.comboboxToolStripMenuItem.Name = "comboboxToolStripMenuItem";
            this.comboboxToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.comboboxToolStripMenuItem.Text = "Combobox";
            this.comboboxToolStripMenuItem.Click += new System.EventHandler(this.comboboxToolStripMenuItem_Click);
            // 
            // défilementToolStripMenuItem
            // 
            this.défilementToolStripMenuItem.Name = "défilementToolStripMenuItem";
            this.défilementToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.défilementToolStripMenuItem.Text = "Défilement";
            this.défilementToolStripMenuItem.Click += new System.EventHandler(this.défilementToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(131, 6);
            // 
            // synthèseToolStripMenuItem
            // 
            this.synthèseToolStripMenuItem.Name = "synthèseToolStripMenuItem";
            this.synthèseToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.synthèseToolStripMenuItem.Text = "Synthèse";
            this.synthèseToolStripMenuItem.Click += new System.EventHandler(this.synthèseToolStripMenuItem_Click);
            // 
            // fenetres
            // 
            this.fenetres.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.toolStripSeparator1});
            this.fenetres.Enabled = false;
            this.fenetres.Name = "fenetres";
            this.fenetres.Size = new System.Drawing.Size(63, 20);
            this.fenetres.Text = "Fenetres";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidentifierToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 26);
            // 
            // sidentifierToolStripMenuItem
            // 
            this.sidentifierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phase3ToolStripMenuItem1});
            this.sidentifierToolStripMenuItem.Name = "sidentifierToolStripMenuItem";
            this.sidentifierToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.sidentifierToolStripMenuItem.Text = "S\'identifier";
            // 
            // phase3ToolStripMenuItem1
            // 
            this.phase3ToolStripMenuItem1.Name = "phase3ToolStripMenuItem1";
            this.phase3ToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.phase3ToolStripMenuItem1.Text = "Phase 3";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSIdentifier,
            this.toolStripSplitButtonPhase3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1086, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSIdentifier
            // 
            this.toolStripButtonSIdentifier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSIdentifier.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSIdentifier.Image")));
            this.toolStripButtonSIdentifier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSIdentifier.Name = "toolStripButtonSIdentifier";
            this.toolStripButtonSIdentifier.Size = new System.Drawing.Size(67, 22);
            this.toolStripButtonSIdentifier.Text = "S\'identifier";
            this.toolStripButtonSIdentifier.Click += new System.EventHandler(this.sidentifierToolStripMenuItem1_Click);
            // 
            // toolStripSplitButtonPhase3
            // 
            this.toolStripSplitButtonPhase3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonPhase3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casesToolStripMenuItem1,
            this.listBoxToolStripMenuItem1,
            this.comboBoxToolStripMenuItem1,
            this.défilementToolStripMenuItem1,
            this.synthèseToolStripMenuItem1});
            this.toolStripSplitButtonPhase3.Enabled = false;
            this.toolStripSplitButtonPhase3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonPhase3.Image")));
            this.toolStripSplitButtonPhase3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonPhase3.Name = "toolStripSplitButtonPhase3";
            this.toolStripSplitButtonPhase3.Size = new System.Drawing.Size(60, 22);
            this.toolStripSplitButtonPhase3.Text = "Phase3";
            // 
            // casesToolStripMenuItem1
            // 
            this.casesToolStripMenuItem1.Name = "casesToolStripMenuItem1";
            this.casesToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.casesToolStripMenuItem1.Text = "Cases";
            this.casesToolStripMenuItem1.Click += new System.EventHandler(this.casesToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem1
            // 
            this.listBoxToolStripMenuItem1.Name = "listBoxToolStripMenuItem1";
            this.listBoxToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.listBoxToolStripMenuItem1.Text = "ListBox";
            this.listBoxToolStripMenuItem1.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem1
            // 
            this.comboBoxToolStripMenuItem1.Name = "comboBoxToolStripMenuItem1";
            this.comboBoxToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.comboBoxToolStripMenuItem1.Text = "ComboBox";
            this.comboBoxToolStripMenuItem1.Click += new System.EventHandler(this.comboboxToolStripMenuItem_Click);
            // 
            // défilementToolStripMenuItem1
            // 
            this.défilementToolStripMenuItem1.Name = "défilementToolStripMenuItem1";
            this.défilementToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.défilementToolStripMenuItem1.Text = "Défilement";
            this.défilementToolStripMenuItem1.Click += new System.EventHandler(this.défilementToolStripMenuItem_Click);
            // 
            // synthèseToolStripMenuItem1
            // 
            this.synthèseToolStripMenuItem1.Name = "synthèseToolStripMenuItem1";
            this.synthèseToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.synthèseToolStripMenuItem1.Text = "Synthèse";
            this.synthèseToolStripMenuItem1.Click += new System.EventHandler(this.synthèseToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDate,
            this.toolStripStatusLabelDerniereOperation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 594);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1086, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDate
            // 
            this.toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            this.toolStripStatusLabelDate.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabelDate.Text = "Date";
            // 
            // toolStripStatusLabelDerniereOperation
            // 
            this.toolStripStatusLabelDerniereOperation.Name = "toolStripStatusLabelDerniereOperation";
            this.toolStripStatusLabelDerniereOperation.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 616);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phase1;
        private System.Windows.Forms.ToolStripMenuItem phase2;
        private System.Windows.Forms.ToolStripMenuItem phase3;
        private System.Windows.Forms.ToolStripMenuItem fenetres;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sidentifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phase3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sidentifierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem additionneurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem défilementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem synthèseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSIdentifier;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonPhase3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem casesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem défilementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem synthèseToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDerniereOperation;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}


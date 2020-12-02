
namespace WindowsFormsAppToutEmbal
{
    partial class Production
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
            this.labelProdA = new System.Windows.Forms.Label();
            this.labelProdB = new System.Windows.Forms.Label();
            this.labelProdC = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageTypeA = new System.Windows.Forms.TabPage();
            this.textBoxTauxDepuisDemarrageA = new System.Windows.Forms.TextBox();
            this.textBoxTauxDefaulHeureA = new System.Windows.Forms.TextBox();
            this.textBoxNbCaisseA = new System.Windows.Forms.TextBox();
            this.labelTauxDepuisDemarrageA = new System.Windows.Forms.Label();
            this.labelTauxDefaulHeureA = new System.Windows.Forms.Label();
            this.labelNbCaisseA = new System.Windows.Forms.Label();
            this.tabPageTypeB = new System.Windows.Forms.TabPage();
            this.textBoxTauxDepuisDemarrageB = new System.Windows.Forms.TextBox();
            this.textBoxTauxDefaulHeureB = new System.Windows.Forms.TextBox();
            this.textBoxNbCaisseB = new System.Windows.Forms.TextBox();
            this.labelTauxDepuisDemarrageB = new System.Windows.Forms.Label();
            this.labelTauxDefaulHeureB = new System.Windows.Forms.Label();
            this.labelNbCaisseB = new System.Windows.Forms.Label();
            this.tabPageTypeC = new System.Windows.Forms.TabPage();
            this.textBoxTauxDepuisDemarrageC = new System.Windows.Forms.TextBox();
            this.textBoxTauxDefaulHeureC = new System.Windows.Forms.TextBox();
            this.textBoxNbCaisseC = new System.Windows.Forms.TextBox();
            this.labelTauxDepuisDemarrageC = new System.Windows.Forms.Label();
            this.labelTauxDefaulHeureC = new System.Windows.Forms.Label();
            this.labelNbCaisseC = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.démarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DemarrerA = new System.Windows.Forms.ToolStripMenuItem();
            this.DemarrerB = new System.Windows.Forms.ToolStripMenuItem();
            this.DemarrerC = new System.Windows.Forms.ToolStripMenuItem();
            this.arrêterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArreterA = new System.Windows.Forms.ToolStripMenuItem();
            this.ArreterB = new System.Windows.Forms.ToolStripMenuItem();
            this.ArreterC = new System.Windows.Forms.ToolStripMenuItem();
            this.continuerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContinuerA = new System.Windows.Forms.ToolStripMenuItem();
            this.ContinuerB = new System.Windows.Forms.ToolStripMenuItem();
            this.ContinuerC = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarProdA = new System.Windows.Forms.ProgressBar();
            this.progressBarProdB = new System.Windows.Forms.ProgressBar();
            this.progressBarProdC = new System.Windows.Forms.ProgressBar();
            this.tabControl.SuspendLayout();
            this.tabPageTypeA.SuspendLayout();
            this.tabPageTypeB.SuspendLayout();
            this.tabPageTypeC.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProdA
            // 
            this.labelProdA.AutoSize = true;
            this.labelProdA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdA.Location = new System.Drawing.Point(28, 287);
            this.labelProdA.Name = "labelProdA";
            this.labelProdA.Size = new System.Drawing.Size(113, 22);
            this.labelProdA.TabIndex = 0;
            this.labelProdA.Text = "Production A";
            // 
            // labelProdB
            // 
            this.labelProdB.AutoSize = true;
            this.labelProdB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdB.Location = new System.Drawing.Point(28, 336);
            this.labelProdB.Name = "labelProdB";
            this.labelProdB.Size = new System.Drawing.Size(113, 22);
            this.labelProdB.TabIndex = 1;
            this.labelProdB.Text = "Production B";
            // 
            // labelProdC
            // 
            this.labelProdC.AutoSize = true;
            this.labelProdC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdC.Location = new System.Drawing.Point(28, 384);
            this.labelProdC.Name = "labelProdC";
            this.labelProdC.Size = new System.Drawing.Size(114, 22);
            this.labelProdC.TabIndex = 2;
            this.labelProdC.Text = "Production C";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageTypeA);
            this.tabControl.Controls.Add(this.tabPageTypeB);
            this.tabControl.Controls.Add(this.tabPageTypeC);
            this.tabControl.Location = new System.Drawing.Point(311, 95);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(423, 178);
            this.tabControl.TabIndex = 3;
            // 
            // tabPageTypeA
            // 
            this.tabPageTypeA.Controls.Add(this.textBoxTauxDepuisDemarrageA);
            this.tabPageTypeA.Controls.Add(this.textBoxTauxDefaulHeureA);
            this.tabPageTypeA.Controls.Add(this.textBoxNbCaisseA);
            this.tabPageTypeA.Controls.Add(this.labelTauxDepuisDemarrageA);
            this.tabPageTypeA.Controls.Add(this.labelTauxDefaulHeureA);
            this.tabPageTypeA.Controls.Add(this.labelNbCaisseA);
            this.tabPageTypeA.Location = new System.Drawing.Point(4, 22);
            this.tabPageTypeA.Name = "tabPageTypeA";
            this.tabPageTypeA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTypeA.Size = new System.Drawing.Size(415, 152);
            this.tabPageTypeA.TabIndex = 0;
            this.tabPageTypeA.Text = "Type A";
            this.tabPageTypeA.UseVisualStyleBackColor = true;
            // 
            // textBoxTauxDepuisDemarrageA
            // 
            this.textBoxTauxDepuisDemarrageA.Location = new System.Drawing.Point(283, 108);
            this.textBoxTauxDepuisDemarrageA.Name = "textBoxTauxDepuisDemarrageA";
            this.textBoxTauxDepuisDemarrageA.ReadOnly = true;
            this.textBoxTauxDepuisDemarrageA.Size = new System.Drawing.Size(100, 20);
            this.textBoxTauxDepuisDemarrageA.TabIndex = 5;
            this.textBoxTauxDepuisDemarrageA.Text = "0";
            // 
            // textBoxTauxDefaulHeureA
            // 
            this.textBoxTauxDefaulHeureA.Location = new System.Drawing.Point(283, 67);
            this.textBoxTauxDefaulHeureA.Name = "textBoxTauxDefaulHeureA";
            this.textBoxTauxDefaulHeureA.ReadOnly = true;
            this.textBoxTauxDefaulHeureA.Size = new System.Drawing.Size(100, 20);
            this.textBoxTauxDefaulHeureA.TabIndex = 4;
            this.textBoxTauxDefaulHeureA.Text = "0";
            // 
            // textBoxNbCaisseA
            // 
            this.textBoxNbCaisseA.Location = new System.Drawing.Point(283, 24);
            this.textBoxNbCaisseA.Name = "textBoxNbCaisseA";
            this.textBoxNbCaisseA.ReadOnly = true;
            this.textBoxNbCaisseA.Size = new System.Drawing.Size(100, 20);
            this.textBoxNbCaisseA.TabIndex = 3;
            this.textBoxNbCaisseA.Text = "0";
            // 
            // labelTauxDepuisDemarrageA
            // 
            this.labelTauxDepuisDemarrageA.AutoSize = true;
            this.labelTauxDepuisDemarrageA.Location = new System.Drawing.Point(31, 108);
            this.labelTauxDepuisDemarrageA.Name = "labelTauxDepuisDemarrageA";
            this.labelTauxDepuisDemarrageA.Size = new System.Drawing.Size(156, 13);
            this.labelTauxDepuisDemarrageA.TabIndex = 2;
            this.labelTauxDepuisDemarrageA.Text = "Boites défaut depuis démarrage";
            // 
            // labelTauxDefaulHeureA
            // 
            this.labelTauxDefaulHeureA.AutoSize = true;
            this.labelTauxDefaulHeureA.Location = new System.Drawing.Point(31, 67);
            this.labelTauxDefaulHeureA.Name = "labelTauxDefaulHeureA";
            this.labelTauxDefaulHeureA.Size = new System.Drawing.Size(94, 13);
            this.labelTauxDefaulHeureA.TabIndex = 1;
            this.labelTauxDefaulHeureA.Text = "Taux défaut heure";
            // 
            // labelNbCaisseA
            // 
            this.labelNbCaisseA.AutoSize = true;
            this.labelNbCaisseA.Location = new System.Drawing.Point(31, 24);
            this.labelNbCaisseA.Name = "labelNbCaisseA";
            this.labelNbCaisseA.Size = new System.Drawing.Size(198, 13);
            this.labelNbCaisseA.TabIndex = 0;
            this.labelNbCaisseA.Text = "Nombre de caisses depuis le démarrrage";
            // 
            // tabPageTypeB
            // 
            this.tabPageTypeB.Controls.Add(this.textBoxTauxDepuisDemarrageB);
            this.tabPageTypeB.Controls.Add(this.textBoxTauxDefaulHeureB);
            this.tabPageTypeB.Controls.Add(this.textBoxNbCaisseB);
            this.tabPageTypeB.Controls.Add(this.labelTauxDepuisDemarrageB);
            this.tabPageTypeB.Controls.Add(this.labelTauxDefaulHeureB);
            this.tabPageTypeB.Controls.Add(this.labelNbCaisseB);
            this.tabPageTypeB.Location = new System.Drawing.Point(4, 22);
            this.tabPageTypeB.Name = "tabPageTypeB";
            this.tabPageTypeB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTypeB.Size = new System.Drawing.Size(415, 152);
            this.tabPageTypeB.TabIndex = 1;
            this.tabPageTypeB.Text = "Type B";
            this.tabPageTypeB.UseVisualStyleBackColor = true;
            // 
            // textBoxTauxDepuisDemarrageB
            // 
            this.textBoxTauxDepuisDemarrageB.Location = new System.Drawing.Point(283, 108);
            this.textBoxTauxDepuisDemarrageB.Name = "textBoxTauxDepuisDemarrageB";
            this.textBoxTauxDepuisDemarrageB.ReadOnly = true;
            this.textBoxTauxDepuisDemarrageB.Size = new System.Drawing.Size(100, 20);
            this.textBoxTauxDepuisDemarrageB.TabIndex = 11;
            this.textBoxTauxDepuisDemarrageB.Text = "0";
            // 
            // textBoxTauxDefaulHeureB
            // 
            this.textBoxTauxDefaulHeureB.Location = new System.Drawing.Point(283, 67);
            this.textBoxTauxDefaulHeureB.Name = "textBoxTauxDefaulHeureB";
            this.textBoxTauxDefaulHeureB.ReadOnly = true;
            this.textBoxTauxDefaulHeureB.Size = new System.Drawing.Size(100, 20);
            this.textBoxTauxDefaulHeureB.TabIndex = 10;
            this.textBoxTauxDefaulHeureB.Text = "0";
            // 
            // textBoxNbCaisseB
            // 
            this.textBoxNbCaisseB.Location = new System.Drawing.Point(283, 24);
            this.textBoxNbCaisseB.Name = "textBoxNbCaisseB";
            this.textBoxNbCaisseB.ReadOnly = true;
            this.textBoxNbCaisseB.Size = new System.Drawing.Size(100, 20);
            this.textBoxNbCaisseB.TabIndex = 9;
            this.textBoxNbCaisseB.Text = "0";
            // 
            // labelTauxDepuisDemarrageB
            // 
            this.labelTauxDepuisDemarrageB.AutoSize = true;
            this.labelTauxDepuisDemarrageB.Location = new System.Drawing.Point(31, 108);
            this.labelTauxDepuisDemarrageB.Name = "labelTauxDepuisDemarrageB";
            this.labelTauxDepuisDemarrageB.Size = new System.Drawing.Size(156, 13);
            this.labelTauxDepuisDemarrageB.TabIndex = 8;
            this.labelTauxDepuisDemarrageB.Text = "Boites défaut depuis démarrage";
            // 
            // labelTauxDefaulHeureB
            // 
            this.labelTauxDefaulHeureB.AutoSize = true;
            this.labelTauxDefaulHeureB.Location = new System.Drawing.Point(31, 67);
            this.labelTauxDefaulHeureB.Name = "labelTauxDefaulHeureB";
            this.labelTauxDefaulHeureB.Size = new System.Drawing.Size(94, 13);
            this.labelTauxDefaulHeureB.TabIndex = 7;
            this.labelTauxDefaulHeureB.Text = "Taux défaut heure";
            // 
            // labelNbCaisseB
            // 
            this.labelNbCaisseB.AutoSize = true;
            this.labelNbCaisseB.Location = new System.Drawing.Point(31, 24);
            this.labelNbCaisseB.Name = "labelNbCaisseB";
            this.labelNbCaisseB.Size = new System.Drawing.Size(198, 13);
            this.labelNbCaisseB.TabIndex = 6;
            this.labelNbCaisseB.Text = "Nombre de caisses depuis le démarrrage";
            // 
            // tabPageTypeC
            // 
            this.tabPageTypeC.Controls.Add(this.textBoxTauxDepuisDemarrageC);
            this.tabPageTypeC.Controls.Add(this.textBoxTauxDefaulHeureC);
            this.tabPageTypeC.Controls.Add(this.textBoxNbCaisseC);
            this.tabPageTypeC.Controls.Add(this.labelTauxDepuisDemarrageC);
            this.tabPageTypeC.Controls.Add(this.labelTauxDefaulHeureC);
            this.tabPageTypeC.Controls.Add(this.labelNbCaisseC);
            this.tabPageTypeC.Location = new System.Drawing.Point(4, 22);
            this.tabPageTypeC.Name = "tabPageTypeC";
            this.tabPageTypeC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTypeC.Size = new System.Drawing.Size(415, 152);
            this.tabPageTypeC.TabIndex = 2;
            this.tabPageTypeC.Text = "Type C";
            this.tabPageTypeC.UseVisualStyleBackColor = true;
            // 
            // textBoxTauxDepuisDemarrageC
            // 
            this.textBoxTauxDepuisDemarrageC.Location = new System.Drawing.Point(283, 108);
            this.textBoxTauxDepuisDemarrageC.Name = "textBoxTauxDepuisDemarrageC";
            this.textBoxTauxDepuisDemarrageC.ReadOnly = true;
            this.textBoxTauxDepuisDemarrageC.Size = new System.Drawing.Size(100, 20);
            this.textBoxTauxDepuisDemarrageC.TabIndex = 11;
            // 
            // textBoxTauxDefaulHeureC
            // 
            this.textBoxTauxDefaulHeureC.Location = new System.Drawing.Point(283, 67);
            this.textBoxTauxDefaulHeureC.Name = "textBoxTauxDefaulHeureC";
            this.textBoxTauxDefaulHeureC.ReadOnly = true;
            this.textBoxTauxDefaulHeureC.Size = new System.Drawing.Size(100, 20);
            this.textBoxTauxDefaulHeureC.TabIndex = 10;
            // 
            // textBoxNbCaisseC
            // 
            this.textBoxNbCaisseC.Location = new System.Drawing.Point(283, 24);
            this.textBoxNbCaisseC.Name = "textBoxNbCaisseC";
            this.textBoxNbCaisseC.ReadOnly = true;
            this.textBoxNbCaisseC.Size = new System.Drawing.Size(100, 20);
            this.textBoxNbCaisseC.TabIndex = 9;
            // 
            // labelTauxDepuisDemarrageC
            // 
            this.labelTauxDepuisDemarrageC.AutoSize = true;
            this.labelTauxDepuisDemarrageC.Location = new System.Drawing.Point(31, 108);
            this.labelTauxDepuisDemarrageC.Name = "labelTauxDepuisDemarrageC";
            this.labelTauxDepuisDemarrageC.Size = new System.Drawing.Size(156, 13);
            this.labelTauxDepuisDemarrageC.TabIndex = 8;
            this.labelTauxDepuisDemarrageC.Text = "Boites défaut depuis démarrage";
            // 
            // labelTauxDefaulHeureC
            // 
            this.labelTauxDefaulHeureC.AutoSize = true;
            this.labelTauxDefaulHeureC.Location = new System.Drawing.Point(31, 67);
            this.labelTauxDefaulHeureC.Name = "labelTauxDefaulHeureC";
            this.labelTauxDefaulHeureC.Size = new System.Drawing.Size(94, 13);
            this.labelTauxDefaulHeureC.TabIndex = 7;
            this.labelTauxDefaulHeureC.Text = "Taux défaut heure";
            // 
            // labelNbCaisseC
            // 
            this.labelNbCaisseC.AutoSize = true;
            this.labelNbCaisseC.Location = new System.Drawing.Point(31, 24);
            this.labelNbCaisseC.Name = "labelNbCaisseC";
            this.labelNbCaisseC.Size = new System.Drawing.Size(198, 13);
            this.labelNbCaisseC.TabIndex = 6;
            this.labelNbCaisseC.Text = "Nombre de caisses depuis le démarrrage";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.productionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitter});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitter
            // 
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(180, 22);
            this.quitter.Text = "Quitter";
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.démarrerToolStripMenuItem,
            this.arrêterToolStripMenuItem,
            this.continuerToolStripMenuItem});
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // démarrerToolStripMenuItem
            // 
            this.démarrerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DemarrerA,
            this.DemarrerB,
            this.DemarrerC});
            this.démarrerToolStripMenuItem.Name = "démarrerToolStripMenuItem";
            this.démarrerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.démarrerToolStripMenuItem.Text = "Démarrer";
            // 
            // DemarrerA
            // 
            this.DemarrerA.Name = "DemarrerA";
            this.DemarrerA.Size = new System.Drawing.Size(180, 22);
            this.DemarrerA.Text = "A";
            this.DemarrerA.Click += new System.EventHandler(this.DemarrerA_Click);
            // 
            // DemarrerB
            // 
            this.DemarrerB.Name = "DemarrerB";
            this.DemarrerB.Size = new System.Drawing.Size(180, 22);
            this.DemarrerB.Text = "B";
            this.DemarrerB.Click += new System.EventHandler(this.DemarrerB_Click);
            // 
            // DemarrerC
            // 
            this.DemarrerC.Name = "DemarrerC";
            this.DemarrerC.Size = new System.Drawing.Size(180, 22);
            this.DemarrerC.Text = "C";
            this.DemarrerC.Click += new System.EventHandler(this.DemarrerC_Click);
            // 
            // arrêterToolStripMenuItem
            // 
            this.arrêterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArreterA,
            this.ArreterB,
            this.ArreterC});
            this.arrêterToolStripMenuItem.Name = "arrêterToolStripMenuItem";
            this.arrêterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arrêterToolStripMenuItem.Text = "Arrêter";
            // 
            // ArreterA
            // 
            this.ArreterA.Enabled = false;
            this.ArreterA.Name = "ArreterA";
            this.ArreterA.Size = new System.Drawing.Size(180, 22);
            this.ArreterA.Text = "A";
            this.ArreterA.Click += new System.EventHandler(this.ArreterA_Click);
            // 
            // ArreterB
            // 
            this.ArreterB.Enabled = false;
            this.ArreterB.Name = "ArreterB";
            this.ArreterB.Size = new System.Drawing.Size(180, 22);
            this.ArreterB.Text = "B";
            this.ArreterB.Click += new System.EventHandler(this.ArreterB_Click);
            // 
            // ArreterC
            // 
            this.ArreterC.Enabled = false;
            this.ArreterC.Name = "ArreterC";
            this.ArreterC.Size = new System.Drawing.Size(180, 22);
            this.ArreterC.Text = "C";
            this.ArreterC.Click += new System.EventHandler(this.ArreterC_Click);
            // 
            // continuerToolStripMenuItem
            // 
            this.continuerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContinuerA,
            this.ContinuerB,
            this.ContinuerC});
            this.continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
            this.continuerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.continuerToolStripMenuItem.Text = "Continuer";
            // 
            // ContinuerA
            // 
            this.ContinuerA.Enabled = false;
            this.ContinuerA.Name = "ContinuerA";
            this.ContinuerA.Size = new System.Drawing.Size(180, 22);
            this.ContinuerA.Text = "A";
            this.ContinuerA.Click += new System.EventHandler(this.ContinuerA_Click);
            // 
            // ContinuerB
            // 
            this.ContinuerB.Enabled = false;
            this.ContinuerB.Name = "ContinuerB";
            this.ContinuerB.Size = new System.Drawing.Size(180, 22);
            this.ContinuerB.Text = "B";
            this.ContinuerB.Click += new System.EventHandler(this.ContinuerB_Click);
            // 
            // ContinuerC
            // 
            this.ContinuerC.Enabled = false;
            this.ContinuerC.Name = "ContinuerC";
            this.ContinuerC.Size = new System.Drawing.Size(180, 22);
            this.ContinuerC.Text = "C";
            this.ContinuerC.Click += new System.EventHandler(this.ContinuerC_Click);
            // 
            // progressBarProdA
            // 
            this.progressBarProdA.Location = new System.Drawing.Point(315, 286);
            this.progressBarProdA.Name = "progressBarProdA";
            this.progressBarProdA.Size = new System.Drawing.Size(415, 23);
            this.progressBarProdA.TabIndex = 5;
            // 
            // progressBarProdB
            // 
            this.progressBarProdB.Location = new System.Drawing.Point(315, 335);
            this.progressBarProdB.Name = "progressBarProdB";
            this.progressBarProdB.Size = new System.Drawing.Size(415, 23);
            this.progressBarProdB.TabIndex = 6;
            // 
            // progressBarProdC
            // 
            this.progressBarProdC.Location = new System.Drawing.Point(315, 383);
            this.progressBarProdC.Name = "progressBarProdC";
            this.progressBarProdC.Size = new System.Drawing.Size(415, 23);
            this.progressBarProdC.TabIndex = 7;
            // 
            // Production
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBarProdC);
            this.Controls.Add(this.progressBarProdB);
            this.Controls.Add(this.progressBarProdA);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.labelProdC);
            this.Controls.Add(this.labelProdB);
            this.Controls.Add(this.labelProdA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Production";
            this.Text = "Production des caisses";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Production_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabPageTypeA.ResumeLayout(false);
            this.tabPageTypeA.PerformLayout();
            this.tabPageTypeB.ResumeLayout(false);
            this.tabPageTypeB.PerformLayout();
            this.tabPageTypeC.ResumeLayout(false);
            this.tabPageTypeC.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProdA;
        private System.Windows.Forms.Label labelProdB;
        private System.Windows.Forms.Label labelProdC;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageTypeA;
        private System.Windows.Forms.TabPage tabPageTypeB;
        private System.Windows.Forms.TabPage tabPageTypeC;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitter;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem démarrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DemarrerA;
        private System.Windows.Forms.ToolStripMenuItem DemarrerB;
        private System.Windows.Forms.ToolStripMenuItem DemarrerC;
        private System.Windows.Forms.ToolStripMenuItem arrêterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArreterA;
        private System.Windows.Forms.ToolStripMenuItem ArreterB;
        private System.Windows.Forms.ToolStripMenuItem ArreterC;
        private System.Windows.Forms.ToolStripMenuItem continuerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContinuerA;
        private System.Windows.Forms.ToolStripMenuItem ContinuerB;
        private System.Windows.Forms.ToolStripMenuItem ContinuerC;
        private System.Windows.Forms.ProgressBar progressBarProdA;
        private System.Windows.Forms.ProgressBar progressBarProdB;
        private System.Windows.Forms.ProgressBar progressBarProdC;
        private System.Windows.Forms.TextBox textBoxTauxDepuisDemarrageA;
        private System.Windows.Forms.TextBox textBoxTauxDefaulHeureA;
        private System.Windows.Forms.TextBox textBoxNbCaisseA;
        private System.Windows.Forms.Label labelTauxDepuisDemarrageA;
        private System.Windows.Forms.Label labelTauxDefaulHeureA;
        private System.Windows.Forms.Label labelNbCaisseA;
        private System.Windows.Forms.TextBox textBoxTauxDepuisDemarrageB;
        private System.Windows.Forms.TextBox textBoxTauxDefaulHeureB;
        private System.Windows.Forms.TextBox textBoxNbCaisseB;
        private System.Windows.Forms.Label labelTauxDepuisDemarrageB;
        private System.Windows.Forms.Label labelTauxDefaulHeureB;
        private System.Windows.Forms.Label labelNbCaisseB;
        private System.Windows.Forms.TextBox textBoxTauxDepuisDemarrageC;
        private System.Windows.Forms.TextBox textBoxTauxDefaulHeureC;
        private System.Windows.Forms.TextBox textBoxNbCaisseC;
        private System.Windows.Forms.Label labelTauxDepuisDemarrageC;
        private System.Windows.Forms.Label labelTauxDefaulHeureC;
        private System.Windows.Forms.Label labelNbCaisseC;
    }
}


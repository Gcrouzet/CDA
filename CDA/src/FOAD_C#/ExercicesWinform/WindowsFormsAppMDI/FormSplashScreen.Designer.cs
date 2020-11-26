
namespace WindowsFormsAppMDI
{
    partial class FormSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSplashScreen));
            this.timerSplashScreen = new System.Windows.Forms.Timer(this.components);
            this.progressBarSplashScreen = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // timerSplashScreen
            // 
            this.timerSplashScreen.Interval = 150;
            this.timerSplashScreen.Tick += new System.EventHandler(this.timerSplashScreen_Tick);
            // 
            // progressBarSplashScreen
            // 
            this.progressBarSplashScreen.Location = new System.Drawing.Point(459, 400);
            this.progressBarSplashScreen.Name = "progressBarSplashScreen";
            this.progressBarSplashScreen.Size = new System.Drawing.Size(326, 23);
            this.progressBarSplashScreen.TabIndex = 0;
            // 
            // FormSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(797, 533);
            this.Controls.Add(this.progressBarSplashScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerSplashScreen;
        private System.Windows.Forms.ProgressBar progressBarSplashScreen;
    }
}
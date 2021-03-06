﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMDI
{
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent(); 
            timerSplashScreen.Start();
        }

        private void timerSplashScreen_Tick(object sender, EventArgs e)
        {
            progressBarSplashScreen.Increment(5);

            if (progressBarSplashScreen.Value == progressBarSplashScreen.Maximum)
            {
                timerSplashScreen.Stop();
                this.Close();
            }

        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleSaisie
{
    public partial class FIN : Form
    {
        public FIN()
        {
            InitializeComponent();
        }

        private void buttonOui_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

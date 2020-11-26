using System;
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
    public partial class FormLogin : Form
    {
        private bool loginIsOk;

        public bool LoginIsOk 
        { 
            get => loginIsOk; 
            //set => loginIsOk = value; 
        }

        public FormLogin()
        {
            InitializeComponent();
            loginIsOk = false;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "admin" && textBoxPassword.Text == "admin")
            {
                loginIsOk = true;
                this.Close();
            }
            else
            {
                errorProviderOK.SetError(buttonOk, "Echec de l'identification");
            }
        }
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

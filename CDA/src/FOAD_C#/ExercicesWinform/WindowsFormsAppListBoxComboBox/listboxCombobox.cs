using ClassLibraryVerification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppListBoxComboBox
{
    public partial class listboxCombobox : Form
    {
        public listboxCombobox()
        {
            InitializeComponent();
        }

        private void listboxCombobox_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("France");
            comboBox1.Items.Add("Espagne");
            comboBox1.Items.Add("Angleterre");
            comboBox1.Items.Add("Japon");
            comboBox1.Items.Add("Chine");
            comboBox1.Items.Add("Allemagne");
            comboBox1.Items.Add("Italie");
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                bool paysIsOk = Verification.ValidNom(comboBox1.Text);
                bool pasDoublon = listBox1.Items.Contains(comboBox1.Text);
                if (paysIsOk == true & pasDoublon == false)
                {
                    errorProvider1.Clear();
                    listBox1.Items.Add(comboBox1.Text);
                    comboBox1.Text = "";

                }
                else if (pasDoublon == true)
                {
                    errorProvider1.SetError(comboBox1, "doublon");
                    comboBox1.Text = "";
                }
                else
                {
                    errorProvider1.SetError(comboBox1, "inserez le nom d'un pays");
                }
            }
            else
            {

                listBox1.Items.Add(comboBox1.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                comboBox1.Text = "";
            }

        }


        private void buttonToutAjouter_Click(object sender, EventArgs e)
        {
            foreach (string s in comboBox1.Items)
            {
                listBox1.Items.Add(s);
            }
            comboBox1.Items.Clear();
            buttonToutAjouter.Enabled = false;
            buttonToutEnlever.Enabled = true;
            comboBox1.Text = "";
        }

        private void buttonEnlever_Click(object sender, EventArgs e)
        {

            comboBox1.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
            buttonToutAjouter.Enabled = true;
        }

        private void buttonToutEnlever_Click(object sender, EventArgs e)
        {
            foreach (string s in listBox1.Items)
            {
                comboBox1.Items.Add(s);
            }
            listBox1.Items.Clear();
            buttonToutAjouter.Enabled = true;
            buttonToutEnlever.Enabled = false;
            buttonEnlever.Enabled = false;
            buttonFlecheBas.Enabled = false;
            buttonFlecheHaut.Enabled = false;
        }
        public void MoveToBot(ListBox lb, int index)
        {
            var item = lb.Items[index];
            lb.Items.RemoveAt(index);
            lb.Items.Insert(index + 1, item);
            lb.SetSelected(index + 1, true);
        }

        private void buttonFlecheBas_Click(object sender, EventArgs e)
        {
            MoveToBot(listBox1, listBox1.SelectedIndex);
        }

        public void MoveToTop(ListBox lb, int index)
        {
            var item = lb.Items[index];
            lb.Items.RemoveAt(index);
            lb.Items.Insert(index - 1, item);
            lb.SetSelected(index - 1, true);
        }

        private void buttonFlecheHaut_Click(object sender, EventArgs e)
        {
            MoveToTop(listBox1, listBox1.SelectedIndex);


        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 & comboBox1.Text.Length == 0)
            {
                buttonAjouter.Enabled = false;
            }
            else
            {
                buttonAjouter.Enabled = true;
            }

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == -1)
            {
                buttonEnlever.Enabled = false;
                buttonFlecheHaut.Enabled = false;
                buttonFlecheBas.Enabled = false;
            }
            else
            {
                buttonFlecheHaut.Enabled = true;
                buttonFlecheBas.Enabled = true;
                buttonEnlever.Enabled = true;
            }
            if (listBox1.SelectedIndex == 0)
            {
                buttonFlecheHaut.Enabled = false;
            }
            if (listBox1.SelectedIndex == listBox1.Items.Count - 1)
            {
                buttonFlecheBas.Enabled = false;
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text.Length == 0)
            {
                buttonAjouter.Enabled = false;
            }
            else
            {
                buttonAjouter.Enabled = true;
            }
            errorProvider1.Clear();
        }
    }

}

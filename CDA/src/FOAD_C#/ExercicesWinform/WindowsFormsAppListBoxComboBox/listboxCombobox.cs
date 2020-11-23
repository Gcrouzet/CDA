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
    public partial class ListboxCombobox : Form
    {
        public ListboxCombobox()
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
                int pasDoublon = listBox1.FindStringExact(comboBox1.Text);
                int pasDoublonCombo = comboBox1.FindStringExact(comboBox1.Text);

                if (paysIsOk == true & pasDoublon == -1 & pasDoublonCombo == -1)
                {
                    errorProvider1.Clear();
                    listBox1.Items.Add(comboBox1.Text);
                    comboBox1.Text = "";
                    buttonToutEnlever.Enabled = true;

                }
                else if (paysIsOk == true & pasDoublon >= 0)
                {
                    errorProvider1.SetError(comboBox1, "doublon");

                }
                else if (paysIsOk == true & pasDoublonCombo >= 0)
                {
                    comboBox1.Items.Remove(comboBox1.Text);
                    listBox1.Items.Add(comboBox1.Text);
                    comboBox1.Text = "";
                    buttonToutEnlever.Enabled = true;
                }
                else
                {
                    errorProvider1.SetError(comboBox1, "inserez le nom d'un pays commençant par une majuscule");
                }
            }
            else
            {
                listBox1.Items.Add(comboBox1.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                comboBox1.Text = "";
                buttonToutEnlever.Enabled = true;
            }
            buttonAjouter.Enabled = false;
            buttonAjouter.Focus();


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
            errorProvider1.Clear();
            comboBox1.ResetText();
        }

        private void buttonEnlever_Click(object sender, EventArgs e)
        {
            int tempIndex = listBox1.SelectedIndex;

            comboBox1.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
            buttonToutAjouter.Enabled = true;
            if (tempIndex < listBox1.Items.Count)
            {
                listBox1.SetSelected(tempIndex, true);
            }
            else if (tempIndex == listBox1.Items.Count && tempIndex > 0)
            {
                listBox1.SetSelected(tempIndex - 1, true);
            }
            else
            {
                buttonToutEnlever.Enabled = false;
                listBox1.ClearSelected();

            }
            buttonEnlever.Focus();
            errorProvider1.Clear();
            comboBox1.ResetText();
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
            errorProvider1.Clear();
            comboBox1.ResetText();
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
            errorProvider1.Clear();
            comboBox1.ResetText();
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
            errorProvider1.Clear();
            comboBox1.ResetText();
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
            listBox1.ClearSelected();
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

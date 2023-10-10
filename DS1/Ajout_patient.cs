using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS1
{
    public partial class Ajout_patient : Form
    {
        public Ajout_patient()
        {
            InitializeComponent();
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Des lettres seulemnt ! ", "Type incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Des lettres seulemnt ! ", "Type incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }



        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Regex chaine = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (!chaine.IsMatch(this.txtEmail.Text))
            {
                txtEmail.Text = "";
                MessageBox.Show("Format de l'email doit etre personne@abcdef.com !", "Format invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dtpDate.Value;
            int x = DateTime.Compare(date, System.DateTime.Today);
            if (x > 0)
            {
                MessageBox.Show("Date de naissance ne peut pas etre supérieur à " + System.DateTime.Today.ToString().Substring(0,10), "Date de naissance incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDate.Value = System.DateTime.Today;
                this.BringToFront();
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if ((this.txtNom.Text != "") && (this.txtPrenom.Text != "") && (this.mtxtNum.Text.Count(c => c == ' ') == 2) && (this.txtEmail.Text != ""))
            {
                string nouveau = $"{txtNom.Text};{txtPrenom.Text};{dtpDate.Value.ToString().Substring(0, 10)};{mtxtNum.Text};{txtEmail.Text}";
                Boolean existe = false;
                using (StreamReader reader = new StreamReader("patients.txt"))
                {
                    string ligne;
                    while ((ligne = reader.ReadLine()) != null)
                    {
                        if (ligne==nouveau)
                        {
                            MessageBox.Show("Un patient existe déjà avec les mêmes coordonnées", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            existe = true;
                        }
                    }
                }
                if (existe == false)
                {
                    using (StreamWriter writer = File.AppendText("patients.txt"))
                    {
                        writer.WriteLine(nouveau);
                    }
                    MessageBox.Show("Patient ajouté avec succès !");
                }
            }
            else
                MessageBox.Show("Veuillez remplir tous les champs", "Informations incomplètes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void iconBACK_Click(object sender, EventArgs e)
        {
            Liste_patients obj = new Liste_patients();
            obj.Show();
            this.Hide();
        }

        private void iconMENU_Click(object sender, EventArgs e)
        {
            menu obj= new menu();
            obj.Show();
            this.Hide();
        }

        private void iconEXIT_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Ajout_patient_Load(object sender, EventArgs e)
        {
            dtpDate.Value = System.DateTime.Today;
        }

        private void mtxtNum_Leave(object sender, EventArgs e)
        {
            if (this.mtxtNum.Text.Length < 16)
            {
                MessageBox.Show("Le numéro de téléphone doit contenir 8 chiffres ! ", "Numéro incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtNum.Text = "";
            }
        }
    }
}

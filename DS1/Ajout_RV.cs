using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DS1
{
    public partial class Ajout_RV : Form
    {
        public Ajout_RV()
        {
            InitializeComponent();
        }

        private void iconEXIT_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void iconMENU_Click(object sender, EventArgs e)
        {
            menu obj = new menu();
            obj.Show();
            this.Hide();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if ((this.txtNom.Text != "") && (this.txtPrenom.Text != "") && (this.mtxtNum.Text.Length==16) && (this.cboxheure.Text != "")&&(this.cboxAMPM.Text!=""))
            {
                string nom = "Nom : " + txtNom.Text;
                string prenom = "Prénom : " + txtPrenom.Text;
                string num = "N° téléphone : " + mtxtNum.Text;
                string date = "Date : " + dtpDate.Value.ToString().Substring(0, 10);
                string heure = "Heure : " + cboxheure.Text + " " + cboxAMPM.Text;

                try
                {
                    string fichier = "rendez-vous.txt";
                    using (StreamWriter writer = File.AppendText(fichier))
                    {
                        writer.WriteLine(nom);
                        writer.WriteLine(prenom);
                        writer.WriteLine(num);
                        writer.WriteLine(date);
                        writer.WriteLine(heure);
                        writer.WriteLine("---------------------------------------------------");
                    }
                    MessageBox.Show("Rendez-vous ajouté avec succès !", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Rendez_vous obj = new Rendez_vous();
                obj.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Veuillez remplir tous les champs", "Informations incomplètes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void iconBACK_Click(object sender, EventArgs e)
        {
            Rendez_vous obj= new Rendez_vous();
            obj.Show();
            this.Hide();
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

        private void mtxtNum_Leave(object sender, EventArgs e)
        {
            if (this.mtxtNum.Text.Length < 16)
            {
                MessageBox.Show("Le numéro de téléphone doit contenir 8 chiffres ! ", "Numéro incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtNum.Text = "";
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dtpDate.Value;
            int x = DateTime.Compare(date, System.DateTime.Today);
            if (x < 0)
            {
                MessageBox.Show("La date ne peut pas etre inférieur à " + System.DateTime.Today.ToString().Substring(0, 10), "Date de naissance incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDate.Value = System.DateTime.Today;
                this.BringToFront();
            }
        }

        private void Ajout_RV_Load(object sender, EventArgs e)
        {
            dtpDate.Value = System.DateTime.Today;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS1
{
    public partial class nouveau_mdp : Form
    {
        public nouveau_mdp()
        {
            InitializeComponent();
        }

        private void iconBACK_Click(object sender, EventArgs e)
        {
            se_connecter obj= new se_connecter();
            obj.Show();
            this.Hide();
        }

        private void iconEXIT_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (this.txtNouveau.Text!="")
            {
                string nouveau = $"{txtNouveau.Text}";
                File.WriteAllText("mot de passe.txt", nouveau);
                MessageBox.Show("Mot de passe changé avec succès !");
                se_connecter obj = new se_connecter();
                obj.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Veuillez saisir le nouveau mot de passe", "Information incomplète", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtNouveau_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

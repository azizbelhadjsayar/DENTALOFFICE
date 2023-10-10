using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DS1
{
    public partial class se_connecter : Form
    {
        public se_connecter()
        {
            InitializeComponent();
        }


        private void btnConnecter_Click(object sender, EventArgs e)
        {
            string fichier = "mot de passe.txt";
            string mdp=File.ReadAllText(fichier);
            if((txtUtilisateur.Text!="")&&(txtMDP.Text!=""))
            {
                if (mdp != txtMDP.Text)
                {
                    MessageBox.Show("Mot de passe incorrect ! ", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMDP.Clear();
                    txtMDP.Select();
                }
                else
                {
                    menu obj = new menu();
                    this.Hide();
                    obj.Show();
                }
            }
            else
                MessageBox.Show("Veuiller remplir tous les champs ! ", "Informations incomplètes", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void iconEXIT_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void labelMDPoublié_Click(object sender, EventArgs e)
        {
            nouveau_mdp obj=new nouveau_mdp();
            obj.Show();
            this.Hide();
        }
    }
}

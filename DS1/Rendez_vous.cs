using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DS1
{
    public partial class Rendez_vous : Form
    {
        public Rendez_vous()
        {
            InitializeComponent();
        }

        private void Rendez_vous_Load(object sender, EventArgs e)
        {
            string fichier = "Rendez-vous.txt";
            using (StreamReader reader = new StreamReader(fichier))
            {
                string ligne;
                while ((ligne = reader.ReadLine()) != null)
                {
                    listBoxRV.Items.Add(ligne);
                }
            }
        }

        private void iconMENU_Click(object sender, EventArgs e)
        {
            menu obj=new menu();
            obj.Show();
            this.Hide();
        }

        private void iconEXIT_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void iconAJOUTER_RV_Click(object sender, EventArgs e)
        {
            Ajout_RV obj=new Ajout_RV();
            obj.Show();
            this.Hide();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Rendez-vous.txt", string.Empty);
            listBoxRV.Items.Clear();
        }
    }
}

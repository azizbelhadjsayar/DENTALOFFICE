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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DS1
{
    public partial class Liste_patients : Form
    {
        public Liste_patients()
        {
            InitializeComponent();
        }

        private void iconEXIT_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void iconRefresh_Click(object sender, EventArgs e)
        {
            listViewPatients.Items.Clear();
            btnSelectionner.Text = "Sélectionner tout";
            using (StreamReader reader = new StreamReader("patients.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');

                    ListViewItem item = new ListViewItem(parts[0]);
                    item.SubItems.Add(parts[1]);
                    item.SubItems.Add(parts[2]);
                    item.SubItems.Add(parts[3]);
                    item.SubItems.Add(parts[4]);
                    listViewPatients.Items.Add(item);
                }
            }
        }

        private void iconBACK_Click(object sender, EventArgs e)
        {
            menu obj = new menu();
            this.Hide();
            obj.Show();
        }

        private void iconSUPPRIMER_Click(object sender, EventArgs e)
        {
            int nb = 0;
            foreach (ListViewItem item in listViewPatients.Items)
            {
                if (item.Checked == true)
                    nb++;
            }
            if (nb == 0)
                MessageBox.Show("Veuiller sélectionner un ou plusieurs patient(s) à supprimer", "Pas de sélection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                string fichier = @"patients.txt";
                foreach (ListViewItem item in listViewPatients.Items)
                {
                    if (item.Checked)
                    {
                        listViewPatients.Items.Remove(item);
                    }
                }
                using (StreamWriter writer = new StreamWriter(fichier))
                {
                    foreach (ListViewItem item in listViewPatients.Items)
                    {
                        writer.Write(item.SubItems[0].Text + ";" + item.SubItems[1].Text + ";" + item.SubItems[2].Text + ";" + item.SubItems[3].Text + ";" + item.SubItems[4].Text + "\n");
                    }
                }
            }
        }

        private void Liste_patients_Load(object sender, EventArgs e)
        {
            listViewPatients.Items.Clear();
            using (StreamReader reader = new StreamReader("patients.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');

                    ListViewItem item = new ListViewItem(parts[0]);
                    item.SubItems.Add(parts[1]);
                    item.SubItems.Add(parts[2]);
                    item.SubItems.Add(parts[3]);
                    item.SubItems.Add(parts[4]);
                    listViewPatients.Items.Add(item);
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Ajout_patient obj=new Ajout_patient();
            obj.Show();
            this.Hide();
        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            Chercher_patient obj = new Chercher_patient();
            obj.Show();
            this.Hide();
        }

        private void iconMENU_Click(object sender, EventArgs e)
        {
            menu obj=new menu();
            obj.Show();
            this.Hide();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if(btnSelectionner.Text == "Sélectionner tout")
            {
                foreach (ListViewItem item in listViewPatients.Items)
                {
                    item.Checked = true;
                }
                btnSelectionner.Text = "Annuler";
            }
            else
            {
                foreach (ListViewItem item in listViewPatients.Items)
                {
                    item.Checked = false;
                }
                btnSelectionner.Text = "Sélectionner tout";
            }
        }


        private void listViewPatients_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                e.Item.BackColor = Color.IndianRed;
                e.Item.ForeColor = Color.White;
            }
            else
            {
                e.Item.BackColor = listViewPatients.BackColor; ;
                e.Item.ForeColor = Color.Black;
            }
        }
    }
}

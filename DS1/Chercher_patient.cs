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
    public partial class Chercher_patient : Form
    {
        public Chercher_patient()
        {
            InitializeComponent();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            String chercher_date = dtpDate.Text.ToString().Substring(0, 10);
            listViewPatients.Items.Clear();
            using (StreamReader reader = new StreamReader("patients.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(chercher_date))
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
        }

        private void iconBACK_Click(object sender, EventArgs e)
        {
            Liste_patients obj = new Liste_patients();
            this.Hide();
            obj.Show();
        }

        private void iconMENU_Click(object sender, EventArgs e)
        {
            menu obj = new menu();
            obj.Show();
            this.Hide();
        }

        private void iconEXIT_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Chercher_patient_Load(object sender, EventArgs e)
        {
            dtpDate.Value = System.DateTime.Today;
        }
    }
}

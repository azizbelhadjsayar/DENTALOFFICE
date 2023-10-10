using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void pictureCLOSE_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            Liste_patients obj = new Liste_patients();
            this.Hide();
            obj.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Rendez_vous obj= new Rendez_vous();
            obj.Show();
            this.Hide();
        }
    }
}

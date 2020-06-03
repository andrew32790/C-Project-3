using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_TEST
{
    public partial class Dashboard : Form
    {
        List<Persoane> persoane = new List<Persoane>();
        public Dashboard()
        {
            InitializeComponent();

            listapersoane.DataSource = persoane;
            listapersoane.DisplayMember = "FullInfo";
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            persoane = db.GetPersoane(Numetext.Text);

            listapersoane.DataSource = persoane;
            listapersoane.DisplayMember = "FullInfo";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Adrese f = new Adrese();
            f.Show();
            f.Activate();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Vehicule f = new Vehicule();
            f.Show();
            f.Activate();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Register f = new Register();
            f.Show();
            f.Activate();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

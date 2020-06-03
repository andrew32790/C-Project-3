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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertPerson(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Dashboard f = new Dashboard();
            f.Show();
            f.Activate();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertAdress(textBox5.Text, textBox6.Text);

            textBox5.Text = "";
            textBox6.Text = "";
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Adrese f = new Adrese();
            f.Show();
            f.Activate();
            this.Hide();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertVehicle(textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text);

            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Vehicule f = new Vehicule();
            f.Show();
            f.Activate();
            this.Hide();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

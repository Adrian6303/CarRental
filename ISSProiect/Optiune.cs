using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISSProiect.service;
using ISSProiect.Domain;

namespace ISSProiect
{
    public partial class Optiune : Form
    {
        Service service;
        Sediu sediu;
        Client client;
        Login login;
        public Optiune(Service service, Sediu sediu, Client client, Login login)
        {
            InitializeComponent();
            this.service = service;
            this.sediu = sediu;
            this.client = client;
            this.login = login;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

        private void InchiriazaButton_Click(object sender, EventArgs e)
        {
            Rezervare rezervare = new Rezervare(service, sediu, client, this);
            rezervare.Text = client.Nume + ": Alege Maisna";
            this.Hide();
            rezervare.Show();
        }

        private void ReturneazaButton_Click(object sender, EventArgs e)
        {
            Returnare returnare = new Returnare(service, sediu, client, this);
            returnare.Text = client.Nume + ": Returneaza Masina";
            this.Hide();
            returnare.Show();
        }
    }
}

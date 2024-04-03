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

            this.service = service;
            this.sediu = sediu;
            this.client = client;
            this.login = login;
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }
    }
}

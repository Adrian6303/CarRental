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
    public partial class Returnare : Form
    {
        Service service;
        Sediu sediu;
        Client client;
        Optiune optiune;
        public Returnare(Service service,Sediu sediu, Client client, Optiune optiune)
        {
            InitializeComponent();
            this.service = service;
            this.sediu = sediu;
            this.client = client;
            this.optiune = optiune;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            optiune.Show();
            this.Close();
        }
    }
}

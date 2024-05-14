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
        public Returnare(Service service, Sediu sediu, Client client, Optiune optiune)
        {
            InitializeComponent();
            this.service = service;
            this.sediu = sediu;
            this.client = client;
            this.optiune = optiune;
            LoadReturnare();
        }

        public void LoadReturnare()
        {
            MasiniDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            List<Masina> masini = service.findMasiniUnavailableBySediu(sediu,client);
            MasiniDataGridView.DataSource = masini;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            optiune.Show();
            this.Close();
        }

        private void ReturneazaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Masina masina = (Masina)MasiniDataGridView.SelectedRows[0].DataBoundItem;
                service.deleteInchiriere(masina.Id);
                service.updateMasinaStare(masina);
                MessageBox.Show("Masina a fost returnata cu succes!");
                optiune.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

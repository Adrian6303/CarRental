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
using ISSProiect.utils;

namespace ISSProiect
{

    public partial class Rezervare : Form, Observer
    {
        Service service;
        Sediu sediu;
        Client client;
        Optiune optiune;
        public Rezervare(Service service, Sediu sediu, Client client, Optiune optiune)
        {
            InitializeComponent();
            this.service = service;
            service.addObserver(this);
            this.sediu = sediu;
            this.client = client;
            this.optiune = optiune;
            LoadRezervare();
        }

        public void LoadRezervare()
        {
            MasiniDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            NrZileNumericUpDown.Value = 1;
            NrZileNumericUpDown.Minimum = 1;
            NrZileNumericUpDown.Maximum = 30;
            List<Masina> masini = service.findMasiniAvailableBySediu(sediu);
            MasiniDataGridView.DataSource = masini;

            MasiniDataGridView.Columns["Id"].Visible = false;
            MasiniDataGridView.Columns["Marca"].Visible = true;
            MasiniDataGridView.Columns["Model"].Visible = true;
            MasiniDataGridView.Columns["Descriere"].Visible = false;
            MasiniDataGridView.Columns["Stare"].Visible = false;


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            optiune.Show();
            this.Close();
        }

        private void MasiniDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DescriereTextBox.Text = MasiniDataGridView.SelectedRows[0].Cells["Descriere"].Value.ToString();
        }

        public void update()
        {
            LoadRezervare();
        }

        private void RezervaButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dataInchiriere = DateTime.Now;
                int nrZile = Int32.Parse(NrZileNumericUpDown.Text);
                Masina masina = (Masina)MasiniDataGridView.CurrentRow.DataBoundItem;
                Inchiriere inchiriere = new Inchiriere(client.Id, masina.Id, dataInchiriere, nrZile);
                List<Inchiriere> inchirieri = service.findAllInchirieri();
                foreach(Inchiriere i in inchirieri)
                {
                    if(i.Vin_masina == masina.Id)
                    {
                        LoadRezervare();
                        MessageBox.Show("Masina este deja rezervata!");
                        
                        return;
                    }
                }
                service.addInchiriere(inchiriere);
                service.updateMasinaStare(masina);
                MessageBox.Show("Masina a fost rezervata cu succes!");
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

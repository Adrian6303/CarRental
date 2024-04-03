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

    public partial class Rezervare : Form
    {
        Service service;
        Sediu sediu;
        Client client;
        Optiune optiune;
        public Rezervare(Service service, Sediu sediu, Client client, Optiune optiune)
        {
            InitializeComponent();
            this.service = service;
            this.sediu = sediu;
            this.client = client;
            this.optiune = optiune;
            LoadRezervare();
        }

        public void LoadRezervare()
        {
            StartDateTimePicker.Value = DateTime.Now;
            StartDateTimePicker.MinDate = DateTime.Now;
            StartDateTimePicker.MaxDate = DateTime.Now.AddDays(90);
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dataInchiriere = StartDateTimePicker.Value;
                int nrZile = Int32.Parse(NrZileNumericUpDown.Text);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MasiniDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DescriereTextBox.Text = MasiniDataGridView.SelectedRows[0].Cells["Descriere"].Value.ToString();
        }
    }
}

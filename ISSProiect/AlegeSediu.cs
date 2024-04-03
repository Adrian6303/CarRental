using ISSProiect.Domain;
using System;
using ISSProiect.service;
using System.Data;

namespace ISSProiect
{
    public partial class AlegeSediu : Form
    {
        Service service;
        DataSet ds = new DataSet();
        public AlegeSediu(Service service)
        {
            InitializeComponent();
            this.service = service;
            AlegeSediu_Load();
        }

        private void AlegeSediu_Load()
        {
            this.Text = "Alege Sediu";

            SediiDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nume", typeof(string));
            dt.Columns.Add("Adresa", typeof(string));
            foreach (Sediu s in service.findAllSedii())
            {
                dt.Rows.Add(s.Id, s.Nume, s.Adresa);
            }
            SediiDataGridView.DataSource = dt;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            try
            {

                int id = Int32.Parse(SediiDataGridView.SelectedRows[0].Cells["Id"].Value.ToString());

                Sediu sediu = service.findSediu(id);

                Login login = new Login(service,sediu, this);
                login.Text = "Login at location: " + sediu.Nume;
                this.Hide();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
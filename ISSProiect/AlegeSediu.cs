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

            this.service = service;
            InitializeComponent();
            AlegeSediu_Load();
        }

        private void AlegeSediu_Load()
        {

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


    }
}
using System.Configuration;
using ISSProiect.Repository;
using ISSProiect.service;

namespace ISSProiect
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            string ConectionString = "Data Source=LAPTOP-LO9O0L3V\\SQLEXPRESS;Initial Catalog=CarRental;Integrated Security=True;TrustServerCertificate=True";
            
            SediuRepo sediuRepo= new SediuRepo(ConectionString);
            MasinaRepo masinaRepo = new MasinaRepo(ConectionString);
            ClientRepo clientRepo = new ClientRepo(ConectionString);
            InchiriereRepo inchiriereRepo = new InchiriereRepo(ConectionString);
            ApartineRepo apartineRepo = new ApartineRepo(ConectionString);
            
            Service service = new Service(sediuRepo, masinaRepo, clientRepo, inchiriereRepo, apartineRepo);
            
            ApplicationConfiguration.Initialize();
            Application.Run(new AlegeSediu(service));
        }
    }
}
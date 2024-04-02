using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSProiect.Domain;

public class Inchiriere : Entity<int>
{
    private int cnp_client;
    private string vin_masina;
    private DateTime startDate;
    private int nrZile;


    public Inchiriere(int cnp_client, string vin_masina, DateTime startDate, int nrZile)
    {
        this.cnp_client = cnp_client;
        this.vin_masina = vin_masina;
        this.startDate = startDate;
        this.nrZile = nrZile;
    }


    public int Cnp_client
    {
        get { return cnp_client; }
        set { cnp_client = value; }
    }

    public string Vin_masina
    {
        get { return vin_masina; }
        set { vin_masina = value; }
    }

    public DateTime StartDate
    {
        get { return startDate; }
        set { startDate = value; }
    }

    public int NrZile
    {
        get { return nrZile; }
        set { nrZile = value; }
    }

    public override string ToString()
    {
        return $"Inchiriere{{id={Id}, cnp_client={cnp_client}, vin_masina={vin_masina}, startDate={startDate}, nrZile={nrZile}}}";
    }
    

    public override bool Equals(object obj)
    {
        if (this == obj)
            return true;

        if (!(obj is Inchiriere))
            return false;

        Inchiriere inchiriere = (Inchiriere)obj;
        return Equals(Id, inchiriere.Id);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

}

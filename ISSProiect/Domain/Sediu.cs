using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSProiect.Domain;

public class Sediu : Entity<int>
{
    private string nume;
    private string adresa;

    public Sediu(string nume, string adresa)
    {
        this.nume = nume;
        this.adresa = adresa;
    }

    public string Nume
    {
        get { return nume; }
        set { nume = value; }
    }

    public string Adresa 
    {
        get { return adresa; }
        set { adresa = value; }
    }


    public override string ToString()
    {
        return $"Sediu{{id={Id}, nume={nume}, adresa={adresa}}}";
    }


    public override bool Equals(object obj)
    {
        if (this == obj)
            return true;

        if (!(obj is Sediu))
            return false;

        Sediu sediu = (Sediu)obj;
        return Equals(Id, sediu.Id);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

}

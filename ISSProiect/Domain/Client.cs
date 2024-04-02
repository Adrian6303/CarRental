using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSProiect.Domain;

public class Client : Entity<int>
{
    private string parola;
    private string nume;
    private string adresa;
    private string telefon;

    public Client(string parola, string nume, string adresa, string telefon)
    {
        this.parola = parola;
        this.nume = nume;
        this.adresa = adresa;
        this.telefon = telefon;
    }

    public string Parola
    {
        get { return parola; }
        set { parola = value; }
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

    public string Telefon
    {
        get { return telefon; }
        set { telefon = value; }
    }

    public override string ToString()
    {
        return $"Client{{id={Id}, parola={parola}, nume={nume}, adresa={adresa}, telefon={telefon}}}";
    }

    public override bool Equals(object obj)
    {
        if (this == obj)
            return true;

        if (!(obj is Client))
            return false;

        Client client = (Client)obj;
        return Equals(Id, client.Id);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }


   
}

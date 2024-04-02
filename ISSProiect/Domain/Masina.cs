using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSProiect.Domain;

public class Masina : Entity<string>
{
    private string marca;
    private string model;
    private string descriere;
    private string stare;

    public Masina(string marca, string model, string descriere, string stare)
    {
        this.marca = marca;
        this.model = model;
        this.descriere = descriere;
        this.stare = stare;
    }

    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Descriere
    {
        get { return descriere; }
        set { descriere = value; }
    }

    public string Stare
    {
        get { return stare; }
        set { stare = value; }
    }

    public override string ToString()
    {
        return $"Masina{{id={Id}, marca={marca}, model={model}, descriere={descriere}, stare={stare}}}";
    }

    public override bool Equals(object obj)
    {
        if (this == obj)
            return true;

        if (!(obj is Masina))
            return false;

        Masina masina = (Masina)obj;
        return Equals(Id, masina.Id);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }



}

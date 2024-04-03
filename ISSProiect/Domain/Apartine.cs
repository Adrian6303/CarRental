using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSProiect.Domain;

public class Apartine : Entity<int>
{
    private int id_sediu;
    private string id_masina;

    public Apartine(int id_sediu, string id_masina)
    {
        this.id_sediu = id_sediu;
        this.id_masina = id_masina;
    }

    public int Id_sediu
    {
        get { return id_sediu; }
        set { id_sediu = value; }
    }

    public string Id_masina
    {
        get { return id_masina; }
        set { id_masina = value; }
    }

    public override string ToString()
    {
        return $"Apartine{{id={Id}, id_sediu={id_sediu}, id_masina={id_masina}}}";
    }

    public override bool Equals(object obj)
    {
        if (this == obj)
            return true;

        if (!(obj is Apartine))
            return false;

        Apartine apartine = (Apartine)obj;
        return id_sediu == apartine.id_sediu && id_masina == apartine.id_masina;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(id_sediu, id_masina);
    }
    
}

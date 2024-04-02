using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISSProiect.Domain;
using Microsoft.Data.SqlClient;

namespace ISSProiect.Repository;

public class InchiriereRepo : IRepository<int, Inchiriere>
{
    SqlConnection cs = new SqlConnection();
    SqlDataAdapter da = new SqlDataAdapter();

    public InchiriereRepo(string ConectionString)
    {
        this.cs = new SqlConnection(ConectionString);
    }
    public void delete(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Inchiriere> findAll()
    {
        throw new NotImplementedException();
    }

    public Inchiriere? findOne(int id)
    {
        throw new NotImplementedException();
    }

    public void save(Inchiriere entity)
    {
        throw new NotImplementedException();
    }

    public void update(Inchiriere entity)
    {
        throw new NotImplementedException();
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISSProiect.Domain;
using Microsoft.Data.SqlClient;

namespace ISSProiect.Repository;

public class MasinaRepo : IRepository<string, Masina>
{
    SqlConnection cs = new SqlConnection();
    SqlDataAdapter da = new SqlDataAdapter();

    public MasinaRepo(string ConectionString)
    {
        this.cs = new SqlConnection(ConectionString);
    }


    public void delete(string id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Masina> findAll()
    {
        throw new NotImplementedException();
    }

    public Masina? findOne(string id)
    {
        throw new NotImplementedException();
    }

    public void save(Masina entity)
    {
        throw new NotImplementedException();
    }

    public void update(Masina entity)
    {
        throw new NotImplementedException();
    }
}

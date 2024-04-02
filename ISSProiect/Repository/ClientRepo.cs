using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISSProiect.Domain;
using Microsoft.Data.SqlClient;

namespace ISSProiect.Repository;

public class ClientRepo : IRepository<int, Client>
{
    SqlConnection cs = new SqlConnection();
    SqlDataAdapter da = new SqlDataAdapter();

    public ClientRepo(string ConectionString)
    {
        this.cs = new SqlConnection(ConectionString);
    }

    public void delete(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Client> findAll()
    {
        throw new NotImplementedException();
    }

    public Client? findOne(int id)
    {
        throw new NotImplementedException();
    }

    public void save(Client entity)
    {
        throw new NotImplementedException();
    }

    public void update(Client entity)
    {
        throw new NotImplementedException();
    }
}

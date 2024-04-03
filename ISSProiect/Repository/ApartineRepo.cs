using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISSProiect.Domain;
using Microsoft.Data.SqlClient;

namespace ISSProiect.Repository;

public class ApartineRepo : IRepository<int, Apartine>
{
    SqlConnection cs = new SqlConnection();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();

    public ApartineRepo(string ConectionString)
    {
        this.cs = new SqlConnection(ConectionString);
    }

    public void delete(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Apartine> findAll()
    {
        throw new NotImplementedException();
    }

    public Apartine? findOne(int id)
    {
        throw new NotImplementedException();
    }

    public void save(Apartine entity)
    {
        throw new NotImplementedException();
    }

    public void update(Apartine entity)
    {
        throw new NotImplementedException();
    }

    public bool exists(int id_sediu, string id_masina)
    {
        try
        {
            da.SelectCommand = new SqlCommand("Select * from Apartine where id_sediu = @id_sediu and id_masina = @id_masina", cs);
            da.SelectCommand.Parameters.AddWithValue("@id_sediu", id_sediu);
            da.SelectCommand.Parameters.AddWithValue("@id_masina", id_masina);

            ds.Clear();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
        catch (Exception e)
        {
            cs.Close();
            throw new Exception(e.Message);
        }
    }
}

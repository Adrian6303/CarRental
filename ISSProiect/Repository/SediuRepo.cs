using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISSProiect.Domain;
using Microsoft.Data.SqlClient;

namespace ISSProiect.Repository;

public class SediuRepo : IRepository<int, Sediu>
{
    SqlConnection cs = new SqlConnection();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();

    public SediuRepo(string ConectionString)
    {
        this.cs = new SqlConnection(ConectionString);
    }
    public void delete(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Sediu> findAll()
    {
        try
        {
            da.SelectCommand = new SqlCommand("Select * from Sediu", cs);
            IList<Sediu> sedii = new List<Sediu>();
            ds.Clear();
            da.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Sediu s = new Sediu(dr["nume"].ToString(), dr["adresa"].ToString());
                s.Id = Convert.ToInt32(dr["id"]);
                sedii.Add(s);
            }

            return sedii;
        }
        catch (Exception e)
        {
            cs.Close();
            throw new Exception(e.Message);
        }
        
    }

    public Sediu? findOne(int id)
    {
        try { 
            da.SelectCommand = new SqlCommand("Select * from Sediu where id = @id", cs);
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            ds.Clear();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }
            DataRow dr = ds.Tables[0].Rows[0];
            Sediu s = new Sediu(dr["nume"].ToString(), dr["adresa"].ToString());
            s.Id = Convert.ToInt32(dr["id"]);
            return s;
        }
        catch (Exception e)
        {
            cs.Close();
            throw new Exception(e.Message);
        }
    }

    public void save(Sediu entity)
    {
        throw new NotImplementedException();
    }

    public void update(Sediu entity)
    {
        throw new NotImplementedException();
    }
}

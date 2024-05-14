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
    DataSet ds = new DataSet();

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
        try
        {
            da.SelectCommand = new SqlCommand("Select * from Masina", cs);
            IList<Masina> masini = new List<Masina>();
            ds.Clear();
            da.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Masina m = new Masina(dr["marca"].ToString(), dr["model"].ToString(), dr["descriere"].ToString(), dr["stare"].ToString());
                m.Id = dr["vin"].ToString();
                masini.Add(m);
            }
            return masini;
        }
        catch (Exception e)
        {
            cs.Close();
            throw new Exception(e.Message);
        }
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
        try
        {
            da.UpdateCommand = new SqlCommand("Update Masina set marca = @marca, model = @model, descriere = @descriere, stare = @stare where vin = @vin", cs);
            da.UpdateCommand.Parameters.AddWithValue("@marca", entity.Marca);
            da.UpdateCommand.Parameters.AddWithValue("@model", entity.Model);
            da.UpdateCommand.Parameters.AddWithValue("@descriere", entity.Descriere);
            da.UpdateCommand.Parameters.AddWithValue("@stare", entity.Stare);
            da.UpdateCommand.Parameters.AddWithValue("@vin", entity.Id);

            cs.Open();
            da.UpdateCommand.ExecuteNonQuery();
            cs.Close();

        }
        catch (Exception e)
        {
            cs.Close();
            throw new Exception(e.Message);
        }
    }
}

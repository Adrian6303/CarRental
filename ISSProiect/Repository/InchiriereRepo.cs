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
    public void deleteByVin(string vin)
    {
        try
        {
            da.DeleteCommand = new SqlCommand("Delete from Inchiriere where vin_masina = @vin_masina", cs);
            da.DeleteCommand.Parameters.AddWithValue("@vin_masina", vin);

            cs.Open();
            da.DeleteCommand.ExecuteNonQuery();
            cs.Close();
        }
        catch (Exception e)
        {
            cs.Close();
            throw new Exception(e.Message);
        }
    }

    public IEnumerable<Inchiriere> findAll()
    {
        try
        {
            da.SelectCommand = new SqlCommand("Select * from Inchiriere", cs);
            IList<Inchiriere> inchirieri = new List<Inchiriere>();
            cs.Open();
            SqlDataReader dr = da.SelectCommand.ExecuteReader();
            while (dr.Read())
            {
                Inchiriere i = new Inchiriere(Convert.ToInt32(dr["cnp_client"]), dr["vin_masina"].ToString(), Convert.ToDateTime(dr["startDate"]), Convert.ToInt32(dr["nrZile"]));
                inchirieri.Add(i);
            }
            cs.Close();
            return inchirieri;

        }catch(Exception e)
        {
            cs.Close();
            throw new Exception(e.Message);
        }
    }

    public Inchiriere? findOne(int id)
    {
        throw new NotImplementedException();
    }

    public void save(Inchiriere entity)
    {
        try
        {
            da.InsertCommand = new SqlCommand("Insert into Inchiriere values (@cnp_client, @vin_masina, @startDate, @nrZile)", cs);
            da.InsertCommand.Parameters.AddWithValue("@cnp_client", entity.Cnp_client);
            da.InsertCommand.Parameters.AddWithValue("@vin_masina", entity.Vin_masina);
            da.InsertCommand.Parameters.AddWithValue("@startDate", entity.StartDate);
            da.InsertCommand.Parameters.AddWithValue("@nrZile", entity.NrZile);
            cs.Open();
            da.InsertCommand.ExecuteNonQuery();
            cs.Close();

            

        }
        catch (Exception e)
        {
            cs.Close();
            throw new Exception(e.Message);
        }
    }

    public void update(Inchiriere entity)
    {
        throw new NotImplementedException();
    }
}

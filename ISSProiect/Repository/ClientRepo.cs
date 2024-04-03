using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using ISSProiect.Domain;
using Microsoft.Data.SqlClient;
using System.Diagnostics.Metrics;

namespace ISSProiect.Repository;

public class ClientRepo : IRepository<int, Client>
{
    SqlConnection cs = new SqlConnection();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();

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
        try { 
            da.SelectCommand = new SqlCommand("Select * from Client", cs);
            IList<Client> clienti = new List<Client>();
            ds.Clear();
            da.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Client c = new Client(dr["parola"].ToString(), dr["nume"].ToString(), dr["adresa"].ToString(), dr["telefon"].ToString());
                c.Id = Convert.ToInt32(dr["cnp"]);
                clienti.Add(c);
            }
            return clienti;
        }
        catch (Exception e)
        {
            cs.Close();
            throw new Exception(e.Message);
        }
    }

    public Client? findOne(int id)
    {
        try {
            da.SelectCommand = new SqlCommand("Select * from Client where cnp = @cnp", cs);
            da.SelectCommand.Parameters.AddWithValue("@cnp", id);
            ds.Clear();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }
            DataRow dr = ds.Tables[0].Rows[0];
            Client c = new Client(dr["parola"].ToString(), dr["nume"].ToString(), dr["adresa"].ToString(), dr["telefon"].ToString());
            c.Id = Convert.ToInt32(dr["cnp"]);
        return c;
        }
        catch (Exception e)
        {
            cs.Close();
            throw new Exception(e.Message);
        }
    }

    public void save(Client entity)
    {
        try
        {
            da.InsertCommand = new SqlCommand("Insert into Client values (@cnp, @parola, @nume, @adresa, @telefon)", cs);
            da.InsertCommand.Parameters.AddWithValue("@cnp", entity.Id);
            da.InsertCommand.Parameters.AddWithValue("@parola", entity.Parola);
            da.InsertCommand.Parameters.AddWithValue("@nume", entity.Nume);
            da.InsertCommand.Parameters.AddWithValue("@adresa", entity.Adresa);
            da.InsertCommand.Parameters.AddWithValue("@telefon", entity.Telefon);
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

    public void update(Client entity)
    {
        throw new NotImplementedException();
    }
}

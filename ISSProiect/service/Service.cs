using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISSProiect.Domain;
using ISSProiect.Repository;

namespace ISSProiect.service;



public class Service
{
    private SediuRepo sediuRepo;
    private MasinaRepo masinaRepo;
    private ClientRepo clientRepo;
    private InchiriereRepo inchiriereRepo;
    private ApartineRepo apartineRepo;

    public Service(SediuRepo sediuRepo, MasinaRepo masinaRepo, ClientRepo clientRepo, InchiriereRepo inchiriereRepo, ApartineRepo apartineRepo)
    {
        this.sediuRepo = sediuRepo;
        this.masinaRepo = masinaRepo;
        this.clientRepo = clientRepo;
        this.inchiriereRepo = inchiriereRepo;
        this.apartineRepo = apartineRepo;
    }

    //Add
    public void addSediu(Sediu sediu)
    {
        sediuRepo.save(sediu);
    }
    public void addMasina(Masina masina)
    {
        masinaRepo.save(masina);
    }
    public void addClient(Client client)
    {
        clientRepo.save(client);
    }
    public void addInchiriere(Inchiriere inchiriere)
    {
        inchiriereRepo.save(inchiriere);
    }

    //Delete
    public void deleteSediu(int id)
    {
        sediuRepo.delete(id);
    }
    public void deleteMasina(string id)
    {
        masinaRepo.delete(id);
    }
    public void deleteClient(int id)
    {
        clientRepo.delete(id);
    }
    public void deleteInchiriere(int id)
    {
        inchiriereRepo.delete(id);
    }

    //Update
    public void updateSediu(Sediu sediu)
    {
        sediuRepo.update(sediu);
    }
    public void updateMasina(Masina masina)
    {
        masinaRepo.update(masina);
    }
    public void updateClient(Client client)
    {
        clientRepo.update(client);
    }
    public void updateInchiriere(Inchiriere inchiriere)
    {
        inchiriereRepo.update(inchiriere);
    }

    //FindAll
    public List<Sediu> findAllSedii()
    {
        return sediuRepo.findAll().ToList();
    }
    public List<Masina> findAllMasini()
    {
        return masinaRepo.findAll().ToList();
    }
    public List<Client> findAllClienti()
    {
        return clientRepo.findAll().ToList();
    }
    public List<Inchiriere> findAllInchirieri()
    {
        return inchiriereRepo.findAll().ToList();
    }

    //FindOne
    public Sediu? findSediu(int id)
    {
        return sediuRepo.findOne(id);
    }
    public Masina? findMasina(string id)
    {
        return masinaRepo.findOne(id);
    }
    public Client? findClient(int id)
    {
        return clientRepo.findOne(id);
    }
    public Inchiriere? findInchiriere(int id)
    {
        return inchiriereRepo.findOne(id);
    }


    //Other
    public bool existsApartine(int id_sediu, string id_masina)
    {
        return apartineRepo.exists(id_sediu, id_masina);
    }

    public List<Masina> findMasiniAvailableBySediu(Sediu sediu)
    {
        List<Masina> masini = new List<Masina>();
        foreach (Masina m in masinaRepo.findAll().ToList())
        {
            if (existsApartine(sediu.Id, m.Id) == true && m.Stare == "disponibil")
            {
                masini.Add(m);
            }
        }
        return masini;
    }
}

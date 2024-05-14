using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISSProiect.Domain;
using ISSProiect.Repository;
using ISSProiect.utils;

namespace ISSProiect.service;



public class Service : Observable
{
    private SediuRepo sediuRepo;
    private MasinaRepo masinaRepo;
    private ClientRepo clientRepo;
    private InchiriereRepo inchiriereRepo;
    private ApartineRepo apartineRepo;
    private List<Observer> observers = new List<Observer>();


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
        notifyObservers();
    }
    public void addMasina(Masina masina)
    {
        masinaRepo.save(masina);
        notifyObservers();
    }
    public void addClient(Client client)
    {
        clientRepo.save(client);
        notifyObservers();
    }
    public void addInchiriere(Inchiriere inchiriere)
    {
        inchiriereRepo.save(inchiriere);
        notifyObservers();
    }

    //Delete
    public void deleteSediu(int id)
    {
        sediuRepo.delete(id);
        notifyObservers();
    }
    public void deleteMasina(string id)
    {
        masinaRepo.delete(id);
        notifyObservers();
    }
    public void deleteClient(int id)
    {
        clientRepo.delete(id);
        notifyObservers();
    }
    public void deleteInchiriere(string vin)
    {
        inchiriereRepo.deleteByVin(vin);
        notifyObservers();
    }

    //Update
    public void updateSediu(Sediu sediu)
    {
        sediuRepo.update(sediu);
        notifyObservers();
    }
    public void updateMasina(Masina masina)
    {
        masinaRepo.update(masina);
        notifyObservers();
    }
    public void updateClient(Client client)
    {
        clientRepo.update(client);
        notifyObservers();
    }
    public void updateInchiriere(Inchiriere inchiriere)
    {
        inchiriereRepo.update(inchiriere);
        notifyObservers();
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

    public List<Masina> findMasiniUnavailableBySediu(Sediu sediu, Client client)
    {
        List<Masina> masini = new List<Masina>();
        foreach (Masina m in masinaRepo.findAll().ToList())
        {
            if (existsApartine(sediu.Id, m.Id) == true && m.Stare == "inchiriat")
            {
                foreach (Inchiriere i in inchiriereRepo.findAll().ToList())
                {
                    if (i.Vin_masina == m.Id && i.Cnp_client == client.Id)
                    {
                        masini.Add(m);
                    }
                }
               
            }
        }
        return masini;
    }
    public void updateMasinaStare(Masina masina)
    {
        if (masina.Stare == "disponibil")
            masina.Stare = "inchiriat";
        else
            masina.Stare = "disponibil";
        masinaRepo.update(masina);
        notifyObservers();
    }



    //Observable
    public void addObserver(Observer observer)
    {
        observers.Add(observer);
    }

    public void removeObserver(Observer observer)
    {
        observers.Remove(observer);
    }

    public void notifyObservers()
    {
        observers.ForEach(observer => observer.update());
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibrarieClase;

namespace NivelAccesData
{
    public class Administrare_client : IStocareClient
    {
        string NumeFisier { get; set; } = "client.txt";

        public Administrare_client()
        {
            Stream sFisierText = File.Open(NumeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();
        }

        public List<Client> GetInfo()
        {
            List<Client> _client = new List<Client>();

            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip client pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Client clientDinFisier = new Client(line);
                    _client.Add(clientDinFisier);
                }
            }

            return _client;
        }
        public Client CautaClient(string cnp) // cauta client
        {
            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Client clientDinFisier = new Client(line);
                    if ( clientDinFisier.CNP == cnp)
                        return clientDinFisier;
                }
            }

            return null;
        }
        
        public void AddClient(Client b)
        {
            using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
            {
                swFisierText.WriteLine(b.ConversieLaSir_PentruScriereInFisier());
            }
        }
    }
}

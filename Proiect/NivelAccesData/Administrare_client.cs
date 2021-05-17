using System;
using System.Collections;
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

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sFisierText.Close();
            //using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }

        public ArrayList GetInfo()
        {
            ArrayList _client = new ArrayList();

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
            ArrayList _client = new ArrayList();


            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
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
            //instructiunea 'using' va apela la final swFisierText.Close();
            //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
            using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
            {
                swFisierText.WriteLine(b.ConversieLaSir_PentruScriereInFisier());
            }
        }
    }
}

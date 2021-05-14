using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibrarieClase;

namespace NivelAccesData
{
    public class Administrare_mancare : IStocareMancare
    {
        string NumeFisier { get; set; }

        public Administrare_mancare()
        {
            this.NumeFisier = "mancare.txt";
            Stream sFisierText = File.Open(NumeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sFisierText.Close();
            //using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }

        public ArrayList GetInfoMancare()
        {
            ArrayList _mancare = new ArrayList();

            this.NumeFisier = "mancare.txt";

            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Mancare mancareDinFisier = new Mancare(line); /* ATENTIE LA CONSTRUCTORUL ASTA*/
                    _mancare.Add(mancareDinFisier);
                }
            }

            return _mancare;
        }

        public void AddMancareFisier(Mancare b)
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

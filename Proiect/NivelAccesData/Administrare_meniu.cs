using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibrarieClase;

namespace NivelAccesData
{
    public class Administrare_meniu : IStocareMeniu
    {
        string NumeFisier { get; set; } = "meniu.txt";

        public Administrare_meniu()
        {
            Stream sFisierText = File.Open(NumeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sFisierText.Close();
            //using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }

        public ArrayList GetInfo() // preluare informatii din fisier
        {
            ArrayList _meniu = new ArrayList();


            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Studenumiret pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Meniu meniu = new Meniu(line);
                    _meniu.Add(meniu);
                }
            }

            return _meniu;
        }
        public Meniu GetInfo(string denumire) // functie de cautare
        {
            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Meniu meniu = new Meniu(line);
                    if ( (meniu.denumire).ToLower() == denumire.ToLower() )
                        return meniu;
                }
            }

            return null;
        }

        public void Add(Meniu b)
        {
            using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
            {
                swFisierText.WriteLine(b.ConversieLaSir_PentruScriereInFisier());
            }
        }
    }
}

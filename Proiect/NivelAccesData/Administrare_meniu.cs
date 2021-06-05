using System;
using System.Collections.Generic;
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
        }

        public List<Meniu> GetInfo() // preluare informatii din fisier
        {
            List<Meniu> _meniu = new List<Meniu>();


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
        public Meniu GetInfo(int index) // functie de cautare -- folosita la modificare
        {
            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Meniu pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Meniu meniu = new Meniu(line);
                    if (meniu.id == index)
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

        public bool UpdateMeniu(Meniu update_camp_meniu, bool inceput = false)
        {
            List<Meniu> _meniu = new List<Meniu>();
            bool actualizareCuSucces = false;
            if (inceput == true)
                { _meniu.Add(update_camp_meniu);   actualizareCuSucces = true; }
            else
            if (inceput == false)
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Meniu meniuDinFisier = new Meniu(line);
                        _meniu.Add(meniuDinFisier);
                        actualizareCuSucces = true;
                    }
                }
                _meniu.Add(update_camp_meniu);
            }
            
            if (actualizareCuSucces == true)
            {
                int contor = 1;
                File.Delete(NumeFisier);
                IStocareMeniu stocare_info_meniu = new Administrare_meniu();

                List<Meniu> list_copy = new List<Meniu>();
                foreach(Meniu m in _meniu)
                {
                    if (m.tip_aliment == "Mancare")
                    {
                        Meniu copy = new Meniu();
                        copy.id = contor;
                        copy.tip_aliment = "Mancare";
                        copy.denumire = m.denumire;
                        copy.pret = m.pret;

                        contor++;

                        list_copy.Add(copy);
                    }
                }
                foreach (Meniu m in _meniu)
                {
                    if (m.tip_aliment == "Bautura")
                    {
                        Meniu copy = new Meniu();
                        copy.id = contor;
                        copy.tip_aliment = "Bautura";
                        copy.denumire = m.denumire;
                        copy.pret = m.pret;

                        contor++;

                        list_copy.Add(copy);
                    }
                }
                foreach (Meniu m in _meniu)
                {
                    if (m.tip_aliment == "Desert")
                    {
                        Meniu copy = new Meniu();
                        copy.id = contor;
                        copy.tip_aliment = "Desert";
                        copy.denumire = m.denumire;
                        copy.pret = m.pret;

                        contor++;

                        list_copy.Add(copy);
                    }
                }


                for (int i = 0; i < list_copy.Count; i++)
                {
                    stocare_info_meniu.Add(list_copy[i]);
                }
                return true;
            }
            else
                return false;
        }
    }
}

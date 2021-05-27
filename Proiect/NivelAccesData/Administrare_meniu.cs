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

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sFisierText.Close();
            //using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
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
        public Meniu GetInfo(int index) // functie de cautare
        {
            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
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

        public bool UpdateMeniu(Meniu update_camp_meniu)
        {
            
            List<Meniu> _meniu = GetInfo();

            bool actualizareCuSucces = false;
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Meniu m in _meniu)
                    {
                        Meniu meniu_pentru_stocare = m;
                        //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
                        if (m.id == update_camp_meniu.id)
                        {
                            meniu_pentru_stocare = update_camp_meniu;
                        }
                        swFisierText.WriteLine(meniu_pentru_stocare.ConversieLaSir_PentruScriereInFisier());
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return actualizareCuSucces;



            /*using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Meniu meniuDinFisier = new(line);

                    _meniu.Add(meniuDinFisier);
                }
                verificare = true;
            }

            //for (int i = 0; i < Meniu.last_id; i++)
            _meniu.Add(m);

            if (verificare == true)
            {
                File.Delete(NumeFisier);
                IStocareMeniu stocare_info_meniu = new Administrare_meniu();

                for (int i = 0; i < _meniu.Count; i++)
                {
                    stocare_info_meniu.Add(_meniu[i]);
                }
                return true;
            }
            else
                return false;*/
        }
    }
}

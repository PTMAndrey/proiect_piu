using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibrarieClase;

namespace NivelAccesData
{
    public class Administrare_masa : IStocareMasa
    {
        string NumeFisier { get; set; } = "masa.txt";

        public Administrare_masa()
        {
            Stream sFisierText = File.Open(NumeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sFisierText.Close();
            //using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }

        public ArrayList GetInfoMasa()
        {
            ArrayList _masa = new ArrayList();

            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Masa masaDinFisier = new Masa(line);
                    _masa.Add(masaDinFisier);
                }
            }

            return _masa;
        }
        public Masa CautaMasa(string id_masa)
        {
            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Masa masaDinFisier = new Masa(line);
                    if ((masaDinFisier.id).ToString() == id_masa)
                    {
                        return masaDinFisier;
                    }
                }
            }

            return null;
        }

        public bool UpdateMasa(string _id, string _locuri, bool ocupat = false)
        {
            bool verificare = false;
            ArrayList _masa = new ArrayList();

            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Masa masaDinFisier = new Masa(line);
                    if (masaDinFisier.id == Convert.ToInt32(_id))
                    { masaDinFisier.locuri = Convert.ToInt32(_locuri); masaDinFisier.ocupat = ocupat; verificare = true; }

                    _masa.Add(masaDinFisier);
                }
            }
            if (verificare == true)
            {
                File.Delete(NumeFisier);
                IStocareMasa stocare_info_masa = new Administrare_masa();
                for (int i = 0; i < _masa.Count; i++)
                {
                    stocare_info_masa.AddMasaFisier((Masa)_masa[i]);
                }
                return true;
            }
            else
                return false;
        }
        public void AddMasaFisier(Masa b)
        {
            /*Citesc din fisier codurile unice, apoi verific daca codul unic generat cand s-a introdus masa la consola este egal cu vreun cod deja existent. Daca da, generez pana cand cele doua nu sunt egale*/
            ArrayList _masa = new ArrayList();
            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Masa pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Masa masaDinFisier = new Masa(line);
                    while (masaDinFisier.cod_unic == b.cod_unic)
                        b.cod_unic = b.GenerareCodUnic();
                }
            }



            //instructiunea 'using' va apela la final swFisierText.Close();
            //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
            using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
            {
                swFisierText.WriteLine(b.ConversieLaSir_PentruScriereInFisier());
            }
        }
        public string GetInfoMasaPentruClient(int ID) /*afiseaza detalii masa pe care a rezervat-o clientul*/
        {
            ArrayList _masa = new ArrayList();
            string s;
            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Masa masaDinFisier = new Masa(line);
                    if (masaDinFisier.id == ID)
                    {
                        s = $"Clientul se afla la masa [ {ID} ] cu {masaDinFisier.locuri} locuri\nTOTAL PLATA: {masaDinFisier.total_plata}";
                        return s;
                    }
                }
            }

            return null;
        }

    }
}

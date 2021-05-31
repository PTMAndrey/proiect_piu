using System;
using System.Collections;
using System.Collections.Generic;
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

        public List<Masa> GetInfo()
        {
            List<Masa> _masa = new List<Masa>();

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
        public Masa Cauta(string locatie) // caut masa din locatia selectata in groupbox-ul cu butoane radio si o returnez daca exista
        {
            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Masa masaDinFisier = new Masa(line);
                    if (masaDinFisier.locatie == locatie)
                    {
                        return masaDinFisier;
                    }
                }
            }

            return null;
        }

        public bool UpdateMasa(int _id, bool ocupat = false, string update_total_plata = "")
        {
            bool verificare = false;
            List<Masa> _masa = new List<Masa>();

            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Masa pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Masa masaDinFisier = new Masa(line);

                    if (masaDinFisier.id == _id)
                        if (ocupat == false) // update pentru : 1) actualizare total plata ... 2) schimbare status masa din liber in ocupat
                        {
                            if (update_total_plata != "")
                            {
                                masaDinFisier.total_plata = Validari.Validare_ConvertToFloat_Pret_Meniu(update_total_plata);
                            }
                            else
                            {
                                masaDinFisier.ocupat = true;
                            }
                        }
                        else
                        if (ocupat == true) // update pentru eliberare masa
                        {
                            masaDinFisier.ocupat = false;
                            masaDinFisier.cod_unic = masaDinFisier.GenerareCodUnic();
                            masaDinFisier.total_plata = 0;
                        }

                    // update pentru actualizare pret total masa

                    _masa.Add(masaDinFisier);
                    verificare = true;
                }
            }
            if (verificare == true)
            {
                File.Delete(NumeFisier);
                IStocareMasa stocare_info_masa = new Administrare_masa();
                for (int i = 0; i < _masa.Count; i++)
                {
                    stocare_info_masa.AddMasa(_masa[i]);
                }
                return true;
            }
            else
                return false;
        }


        public void AddMasa(Masa b)
        {
            b.cod_unic = Validari.Validare_Cod_Unic(b, NumeFisier);

            //instructiunea 'using' va apela la final swFisierText.Close();
            //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
            using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
            {
                swFisierText.WriteLine(b.ConversieLaSir_PentruScriereInFisier());
            }
        }
        public string GetInfoMasaPentruClient(int ID) /*afiseaza detalii masa pe care a rezervat-o clientul*/
        {
            List<Masa> _masa = new List<Masa>();
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

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

        }

        public List<Masa> GetInfo()
        {
            List<Masa> _masa = new List<Masa>();

            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

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

        public bool UpdateMasa(int _id, bool ocupat = false, int locuri = 0, string locatie = "", string update_total_plata = "", bool eliberare_masa = false)
        {
            bool verificare = false;
            List<Masa> _masa = new List<Masa>();

            if (_id == 1 && locuri != 0 && locatie != "") // daca fisierul este gol, din form primesc _id = 1
            {
                Masa m = new Masa();
                m.id = _id;
                m.locuri = locuri;
                m.locatie = locatie;
                m.ocupat = false;
                m.total_plata = 0;
                _masa.Add(m);
            }
            else
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Masa pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Masa masaDinFisier = new Masa(line);

                        if (masaDinFisier.id == _id)
                        {
                            if (eliberare_masa == false)
                            {
                                if (ocupat == true && locuri == 0 && update_total_plata == "")  // schimbare status masa la rezervarea unui client
                                    masaDinFisier.ocupat = true;

                                if (ocupat == true && locuri == 0 && update_total_plata != "") // update pret total in meniu
                                {
                                    masaDinFisier.total_plata = Validari.Validare_ConvertToFloat_Pret_Meniu(update_total_plata);
                                    masaDinFisier.ocupat = true;
                                }
                            }
                            else
                            {
                                masaDinFisier.ocupat = false;
                                masaDinFisier.cod_unic = masaDinFisier.GenerareCodUnic();
                                masaDinFisier.total_plata = 0;
                            }

                        }
                        _masa.Add(masaDinFisier);

                        verificare = true;
                    }
                }
            }
            Masa add_to_list_masa = new Masa();
            if (ocupat == false && locuri != 0 && locatie != "" && update_total_plata == "") // adauga masa
            {
                add_to_list_masa.id = _id;
                add_to_list_masa.ocupat = false;
                add_to_list_masa.locuri = locuri;
                add_to_list_masa.cod_unic = add_to_list_masa.GenerareCodUnic();
                add_to_list_masa.locatie = locatie;
                add_to_list_masa.total_plata = 0;

                _masa.Add(add_to_list_masa);
                verificare = true;
            }

            if (verificare == true)
            {
                int contor = 1;
                File.Delete(NumeFisier);
                IStocareMasa stocare_info_masa = new Administrare_masa();
                
                // sortare list 
                List<Masa> list_copy = new List<Masa>();
                foreach(Masa m in _masa)
                {
                    if(m.locatie == "Interior")
                    {
                        Masa copy = new Masa();
                        copy.id = contor;
                        copy.locuri = m.locuri;
                        copy.locatie = "Interior";
                        copy.cod_unic = m.cod_unic;
                        copy.total_plata = m.total_plata;
                        copy.ocupat = m.ocupat;
                        contor++;

                        list_copy.Add(copy);
                    }
                }
                foreach (Masa m in _masa)
                {
                    if (m.locatie == "Separeu")
                    {
                        Masa copy = new Masa();
                        copy.id = contor;
                        copy.locuri = m.locuri;
                        copy.locatie = "Separeu";
                        copy.cod_unic = m.cod_unic;
                        copy.total_plata = m.total_plata;
                        copy.ocupat = m.ocupat;

                        contor++;

                        list_copy.Add(copy);
                    }
                }
                foreach (Masa m in _masa)
                {
                    if (m.locatie == "Terasa")
                    {
                        Masa copy = new Masa();
                        copy.id = contor;
                        copy.locuri = m.locuri;
                        copy.locatie = "Terasa";
                        copy.cod_unic = m.cod_unic;
                        copy.total_plata = m.total_plata;
                        copy.ocupat = m.ocupat;

                        contor++;

                        list_copy.Add(copy);
                    }
                }

                for (int i = 0; i < list_copy.Count; i++)
                {
                    stocare_info_masa.AddMasa(list_copy[i]);
                }
                return true;
            }
            else
                return false;
        }


        public void AddMasa(Masa b)
        {
            b.cod_unic = Validari.Validare_Cod_Unic(b, NumeFisier);
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

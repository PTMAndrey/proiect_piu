using System;
using System.Collections;
using System.Collections.Generic;
using NivelAccesData;
using LibrarieClase;

namespace Proiect
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> list_client;
            List<Masa> list_masa;
            List<Meniu> list_meniu;

            IStocareClient stocare_info_client;
            IStocareMasa stocare_info_masa;
            IStocareMeniu stocare_info_meniu;

            Console.WriteLine("Daca se anuleaza masa rezervata - clientul pleaca -  sa se genereze alt cod unic pentru masa respectiva");
            Console.ReadKey();
            string optiune;
            do
            {
                stocare_info_client = new Administrare_client();
                stocare_info_masa = new Administrare_masa();
                stocare_info_meniu = new Administrare_meniu();

                list_client = stocare_info_client.GetInfo();
                list_masa = stocare_info_masa.GetInfo();
                list_meniu = stocare_info_meniu.GetInfo();

                Console.Clear();
                Console.WriteLine("A. Afisare mese disponibile");
                Console.WriteLine("B. Modifica locuri masa");
                Console.WriteLine("C. Adauga mese\n");

                Console.WriteLine("D. Afisare meniu");
                Console.WriteLine("E. Adauga in meniu");
                Console.WriteLine("F. Cauta aliment\n");

                Console.WriteLine("G. Rezervare masa");
                Console.WriteLine("H. Afisare clienti");
                Console.WriteLine("I. Cauta client\n");

                Console.WriteLine("J. Comanda din meniu");

                Console.WriteLine("X. Parasire restaurant");
                Console.Write("\nAlegeti o optiune: ");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "A":
                        {
                            if (list_masa.Count == 0)
                                Console.WriteLine("Nu exista inregistrari valide!");
                            else
                                AfisareMese(list_masa);
                            break;
                        }
                   
                    case "B":
                        {
                            /*string id, locuri;
                            Console.WriteLine("ID-ul mesei este: ");
                            id = Console.ReadLine();
                            if (list_masa.Count < Convert.ToInt32(id))
                                Console.WriteLine("Masa nu a putut fi actualizata deoarece id-ul introdus nu este atribuit la nici o masa");
                            else
                            {
                                Console.WriteLine("Noul numar de locuri: ");
                                locuri = Console.ReadLine();

                                bool confirmare;
                                confirmare = stocare_info_masa.UpdateMasa(id, locuri);
                                if (confirmare)
                                {
                                    list_masa = stocare_info_masa.GetInfo();
                                    AfisareMese(list_masa);
                                }
                            }*/
                            break;
                        }

                    case "C":
                        {
                            Masa addmasa = AddMasa_Citire_Consola();
                            list_masa.Add(addmasa);
                            stocare_info_masa.AddMasa(addmasa);
                            Console.WriteLine("Masa a fost adaugata cu succes!");

                            break;
                        }

                    case "D":
                        {
                            if (list_meniu.Count == 0)
                                Console.WriteLine("Nu exista inregistrari valide!");
                            else
                                AfisareMeniu(list_meniu);
                            break;
                        }

                    case "E":
                        {
                            Meniu adauga_in_meniu = AddMeniu();
                            list_meniu.Add(adauga_in_meniu);
                            stocare_info_meniu.Add(adauga_in_meniu);
                            Console.WriteLine("Produsul a fost adaugat cu succes!");
                            break;
                        }

                    case "F":
                        {
                            CautaAliment(stocare_info_meniu);
                            break;
                        }

                    case "G":
                        {
                            Client addclient = Rezervare(list_client.Count, list_masa);
                            list_client.Add(addclient);
                            stocare_info_client.AddClient(addclient);
                            Console.WriteLine("Clientul a fost inregistrat!");
                            break;
                        }

                    case "H":
                        {
                            if (list_client.Count == 0)
                                Console.WriteLine("Nu exista clienti in restaurant!");
                            else
                                AfisareClienti(list_client, list_masa);
                            break;
                        }
                    case "I":
                        {
                            CautaClient(stocare_info_client);
                            break;
                        }

                    case "J":
                        {
                            if (list_client.Count == 0)
                                Console.WriteLine("Nu aveti vreo masa rezervata! Rezervati prima data o masa!");
                            


                            break;
                        }

                    case "X":
                        Console.WriteLine("\nLa revedere! Va mai asteptam cu drag!");
                        break;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;

                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

            } while (optiune.ToUpper() != "X");

        }

        public static Client Rezervare(int client_Count, List<Masa> list_masa)
        {
            Client cl = new Client();
            string nume, prenume, cnp;

            Console.WriteLine("\nIntroduceti informatiile client:");
            Console.Write("\n\t-Nume: ");
            nume = Console.ReadLine();

            Console.Write("\n\t-Prenume: ");
            prenume = Console.ReadLine();
            int ok = 0;
            do
            {
                ok = 0;
                Console.Write("\n\t-CNP: ");
                cnp = Console.ReadLine();
                if (cnp.Length != 13)
                {
                    ok = 1;
                    Console.WriteLine("Lungimea CNP-ului trebuie sa fie de exact 13 cifre!");
                }
                else
                {
                    for (int i = 0; i < cnp.Length; i++)
                        if (char.IsLetter(cnp[i]))
                        { ok = 1; Console.WriteLine("CNP-ul trebuie sa contina doar cifre!"); break; }
                }

            } while (ok == 1);


            AfisareMese(list_masa);
            int id = 0;
            bool _catch;
            do
            {
                _catch = false;
                string local_nr_masa = "";
                try
                {
                    Console.WriteLine("Introduceti ID-ul mesei la care doriti sa stati: ");
                    local_nr_masa = Console.ReadLine();
                    id = Convert.ToInt32(local_nr_masa);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ati introdus gresit informatia! Incercati din nou!\n");
                    _catch = true;
                }
                if (_catch == false) // nu e eroare de format la citire
                {
                    if (id < 0 || id > list_masa.Count)
                    {
                        _catch = true;
                        Console.WriteLine("Ati introdus gresit informatia! Incercati din nou!\n");

                    }
                    else if (Verificare_Status(id) == true) // masa este libera
                    {
                        string add = $"{client_Count + 1};{nume};{prenume};{cnp};{local_nr_masa}";
                        bool consola = true;
                        cl = new Client(add, consola);
                        _catch = false;
                    }
                    else
                    {
                        Console.WriteLine("Masa este ocupata! Incercati la alta masa!\n");
                        _catch = true;
                    }
                }

            } while (_catch == true);


            return cl;
        }

        public static bool Verificare_Status(int id)
        {

            /*StocareMasa stocare_info_masa = new Administrare_masa();
            Masa m;//= new Masa();
            m = stocare_info_masa.Cauta(id.ToString());
            if (m != null) // inseamna ca masa selectata exista in fisier
            {
                if (m.ocupat == false)
                    if (stocare_info_masa.UpdateMasa(id.ToString(), (m.locuri).ToString(), true) == true)
                        return true;
            }*/

            return false;
        }

        public static void AfisareClienti(List<Client> clienti, List<Masa> mese)
        {
            Console.WriteLine("Clientii din restaurant sunt:");
            for (int i = 0; i < clienti.Count; i++)
            {
                for (int k = 0; k < mese.Count; k++)
                {
                    if ( clienti[i].ID_Masa == mese[k].id )
                    {
                        Console.WriteLine( clienti[i].ConversieLaSir_PentruAfisare(mese[k]) + "\n");
                        break;
                    }   
                }
            }
        }

        public static void CautaClient(IStocareClient stocare_info_client)
        {
            string cnp;
            Console.WriteLine("CNP-ul persoanei cautate: ");
            cnp = Console.ReadLine();
            Client cautare;
            cautare = stocare_info_client.CautaClient(cnp);
            if (cautare != null)
                Console.Write($"\t[ {cautare.id} ]. Clientul [ {cautare.Nume} {cautare.Prenume} ] se afla la masa [ {cautare.ID_Masa} ]\n");
            else
                Console.WriteLine("Clientul cautat nu exista!");
        }

        public static Masa AddMasa_Citire_Consola()
        {
            string locuri;
            int locatie_masa = 0;
            Masa m;
            do
            {
                Console.WriteLine("\nIntroduceti informatiile despre masa pe care doriti sa o adaugati:");
                Console.WriteLine("\t-Numar locuri:");
                locuri = Console.ReadLine();
                Console.WriteLine("\tLocatie masa:");
                Console.WriteLine("1. Interior");
                Console.WriteLine("2. Separeu");
                Console.WriteLine("3. Terasa");
                bool gasit;
                do
                {
                    gasit = false;

                    try
                    {
                        Console.WriteLine("\nIntroduceti cifra corespunzatoare optiunii dorite: ");
                        locatie_masa = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Optiune inexistenta!");
                        gasit = true;
                    }
                    if (gasit == false)
                        if (locatie_masa < 1 || locatie_masa > 3)
                        {
                            Console.WriteLine("Optiune inexistenta!");
                            gasit = true;
                        }
                        else
                            gasit = false;

                } while (gasit == true);

                string add = $"{locuri};{Convert.ToString((Locatie)locatie_masa)}";

                bool consola = true;
                m = new Masa(add, consola);

            } while (m.locuri == -1);
            return m;
        }

        public static void AfisareMese(List<Masa> mese)
        {
            Console.WriteLine("\tMesele libere din restaurant\n");
            Console.WriteLine("\t\t ID \t\t  Locatie \t\t Locuri");
            for (int i = 0; i < mese.Count; i++)
            {
                if (mese[i].ConversieLaSir_PentruAfisare() != null)
                    Console.WriteLine(mese[i].ConversieLaSir_PentruAfisare());
            }
        }
        /*
        public static Mancare AddMancare_Citire_Consola()
        {
            Mancare m;
            do
            {
                string denumire, pret;

                Console.WriteLine("\nIntroduceti informatiile despre mancarea pe care doriti sa o adaugati:");
                Console.WriteLine("\t-Denumire mancare:");
                denumire = Console.ReadLine();
                Console.WriteLine("\t-Pret produs:");
                pret = Console.ReadLine();
                pret = pret.Replace(',', '.');

                string add = $"{denumire};{pret}";

                bool consola = true;
                m = new Mancare(add, consola);
            } while (m.pret == -1);

            return m;
        }

        public static void AfisareMancare(List<> mancare)
        {
            Console.WriteLine("Bauturile din meniu sunt:");
            for (int i = 0; i < mancare.Count; i++)
            {
                Console.WriteLine(((Mancare)mancare[i]).ConversieLaSir_PentruAfisare());
            }
        }
        */
        public static Meniu AddMeniu()
        {
            Meniu meniu;
            do
            {
                string nume, pret;
                int tip = 0;

                Console.WriteLine("\nIntroduceti informatiile pe care doriti sa le adaugati:");
                Console.WriteLine("\t-Tip aliment:");
                Console.WriteLine("1. Mancare");
                Console.WriteLine("2. Bautura");
                Console.WriteLine("3. Desert");
                bool gasit;
                do
                {
                    gasit = false;

                    try
                    {
                        Console.WriteLine("\nIntroduceti cifra corespunzatoare optiunii dorite: ");
                        tip = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Optiune inexistenta!");
                        gasit = true;
                    }
                    if (gasit == false)
                        if (tip < 1 || tip > 3)
                        {
                            Console.WriteLine("Optiune inexistenta!");
                            gasit = true;
                        }
                        else
                            gasit = false;

                } while (gasit == true);

                Console.WriteLine("\tNume: ");
                nume = Console.ReadLine();

                Console.WriteLine("\t-Pret produs:");
                pret = Console.ReadLine();
                pret = pret.Replace(',', '.');


                string add = $"{nume};{pret};{Convert.ToString((Tip_aliment)(tip))}";

                bool consola = true;
                meniu = new Meniu(add, consola);

            } while (meniu.pret == -1);

            return meniu;
        }

        public static void AfisareMeniu(List<Meniu> meniu)
        {
            Console.WriteLine("\t\t[  Meniu  ]\n");
            Console.WriteLine("\t ID \t   PRET \t\t NUME");
            for (int i = 0; i < meniu.Count; i++)
            {
                Console.WriteLine(meniu[i].ConversieLaSir_PentruAfisare());
            }
        }

        public static void CautaAliment(IStocareMeniu stocare_info_meniu)
        {/*
            string denumire;
            Console.WriteLine("Numele alimentului pe care doriti sa il cautati:");
            denumire = Console.ReadLine();
            Meniu cautare;
            cautare = stocare_info_meniu.GetInfo(denumire);
            if (cautare != null)
                Console.WriteLine(cautare.ConversieLaSir_PentruAfisare());
            else
                Console.WriteLine("Ne cerem scuze, dar optiunea cautata nu face parte din meniul nostru!");*/
        }

    }
}

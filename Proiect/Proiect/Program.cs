using System;
using System.Collections;
using NivelAccesData;
using LibrarieClase;

namespace Proiect
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array_client;
            ArrayList array_masa;
            ArrayList array_mancare;
            ArrayList array_bautura;

            IStocareClient stocare_info_client;
            IStocareMasa stocare_info_masa;
            IStocareMancare stocare_info_mancare;
            IStocareBautura stocare_info_bautura;

            Console.WriteLine("Daca se anuleaza masa rezervata - clientul pleaca -  sa se genereze alt cod unic pentru masa respectiva");
            Console.ReadKey();
            string optiune;
            do
            {
                stocare_info_client = new Administrare_client();
                stocare_info_masa = new Administrare_masa();
                stocare_info_mancare = new Administrare_mancare();
                stocare_info_bautura = new Administrare_bautura();

                array_client = stocare_info_client.GetInfoClient();
                array_masa = stocare_info_masa.GetInfoMasa();
                array_mancare = stocare_info_mancare.GetInfoMancare();
                array_bautura = stocare_info_bautura.GetInfoBautura();

                Console.Clear();
                Console.WriteLine("A. Afisare mese disponibile");
                Console.WriteLine("B. Modifica locuri masa");
                Console.WriteLine("C. Adauga mese\n");
                Console.WriteLine("D. Afisare meniu mancare");
                Console.WriteLine("E. Adauga mancare\n");
                Console.WriteLine("F. Afisare meniu bautura");
                Console.WriteLine("G. Adauga bautura");
                Console.WriteLine("H. Cauta bautura\n");
                Console.WriteLine("I. Inregistrare client");
                Console.WriteLine("J. Afisare clienti");
                Console.WriteLine("K. Cauta client\n");
                Console.WriteLine("X. Parasire restaurant");
                Console.Write("\nAlegeti o optiune: ");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "A":
                        {
                            if (array_masa.Count == 0)
                                Console.WriteLine("Nu exista inregistrari valide!");
                            else
                                AfisareMese(array_masa);
                            break;
                        }
                   
                    case "B":
                        {
                            string id, locuri;
                            Console.WriteLine("ID-ul mesei este: ");
                            id = Console.ReadLine();
                            if (array_masa.Count < Convert.ToInt32(id))
                                Console.WriteLine("Masa nu a putut fi actualizata deoarece id-ul introdus nu este atribuit la nici o masa");
                            else
                            {
                                Console.WriteLine("Noul numar de locuri: ");
                                locuri = Console.ReadLine();

                                bool confirmare;
                                confirmare = stocare_info_masa.UpdateMasa(id, locuri);
                                if (confirmare)
                                {
                                    array_masa = stocare_info_masa.GetInfoMasa();
                                    AfisareMese(array_masa);
                                }
                            }
                            break;
                        }

                    case "C":
                        {
                            Masa addmasa = AddMasa_Citire_Consola();
                            array_masa.Add(addmasa);
                            stocare_info_masa.AddMasaFisier(addmasa);
                            Console.WriteLine("Masa a fost adaugata cu succes!");

                            break;
                        }

                    case "D":
                        {
                            if (array_mancare.Count == 0)
                                Console.WriteLine("Nu exista inregistrari valide!");
                            else
                                AfisareMancare(array_mancare);
                            break;
                        }

                    case "E":
                        {
                            Mancare addmancare = AddMancare_Citire_Consola();
                            array_mancare.Add(addmancare);
                            stocare_info_mancare.AddMancareFisier(addmancare);
                            Console.WriteLine("Produsul a fost adaugat cu succes!");
                            break;
                        }

                    case "F":
                        {
                            if (array_bautura.Count == 0)
                                Console.WriteLine("Nu exista inregistrari valide!");
                            else
                                AfisareBautura(array_bautura);
                            break;
                        }

                    case "G":
                        {
                            Bautura addbautura = AddBautura_Citire_Consola();
                            array_bautura.Add(addbautura);
                            stocare_info_bautura.AddBauturaFisier(addbautura);
                            Console.WriteLine("Produsul a fost adaugat cu succes!");
                            break;
                        }

                    case "H":
                        {
                            string denumire;
                            Console.WriteLine("Numele bauturii pe care doriti sa o cautati:");
                            denumire = Console.ReadLine();
                            Bautura cautare_bautura;
                            cautare_bautura = stocare_info_bautura.GetBautura(denumire);
                            if (cautare_bautura != null)
                                Console.Write(cautare_bautura.Afisare_Bautura());
                            else
                                Console.WriteLine("Bautura nu exista in meniul nostru");
                            break;
                        }

                    case "I":
                        {
                            Client addclient = AddClient_Citire_Consola(array_client.Count, array_masa);
                            array_client.Add(addclient);
                            stocare_info_client.AddClientFisier(addclient);
                            Console.WriteLine("Clientul a fost inregistrat!");
                            break;
                        }

                    case "J":
                        {
                            if (array_client.Count == 0)
                                Console.WriteLine("Nu exista clienti in restaurant!");
                            else
                                AfisareClienti(array_client, array_masa);
                            break;
                        }
                    case "K":
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

        public static Client AddClient_Citire_Consola(int client_Count, ArrayList array_masa)
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


            AfisareMese(array_masa);
            int nr_masa = 0;
            bool _catch;
            do
            {
                _catch = false;
                string local_nr_masa = "";
                try
                {
                    Console.WriteLine("Introduceti ID-ul mesei la care doriti sa stati: ");
                    local_nr_masa = Console.ReadLine();
                    nr_masa = Convert.ToInt32(local_nr_masa);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ati introdus gresit informatia! Incercati din nou!\n");
                    _catch = true;
                }
                if (_catch == false) // nu e eroare de format la citire
                {
                    if (nr_masa < 0 || nr_masa > array_masa.Count)
                    {
                        _catch = true;
                        Console.WriteLine("Ati introdus gresit informatia! Incercati din nou!\n");

                    }
                    else if (Verificare_Status_Masa(nr_masa) == true) // masa este libera
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

        public static bool Verificare_Status_Masa(int nr_masa)
        {

            IStocareMasa stocare_info_masa = new Administrare_masa();
            Masa m;//= new Masa();
            m = stocare_info_masa.CautaMasa(nr_masa.ToString());
            if (m != null) // inseamna ca masa selectata exista in fisier
            {
                if (m.ocupat == false)
                    if (stocare_info_masa.UpdateMasa(nr_masa.ToString(), (m.locuri).ToString(), true) == true)
                        return true;
            }

            return false;
        }

        public static void AfisareClienti(ArrayList clienti, ArrayList mese)
        {
            Console.WriteLine("Clientii din restaurant sunt:");
            for (int i = 0; i < clienti.Count; i++)
            {
                for (int k = 0; k < mese.Count; k++)
                {
                    if ( ( (Client)clienti[i] ).ID_Masa == ( (Masa)mese[k] ).id )
                    {
                        Console.WriteLine( ( (Client)clienti[i] ).Afisare_Client( (Masa)mese[k] ) + "\n");
                        break;
                    }   
                }
            }
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

                string add = $"{locuri};{Convert.ToString((Locatie_masa)locatie_masa)}";

                bool consola = true;
                m = new Masa(add, consola);

            } while (m.locuri == -1);
            return m;
        }

        public static void AfisareMese(ArrayList mese)
        {
            Console.WriteLine("Mesele libere din restaurant sunt:");
            for (int i = 0; i < mese.Count; i++)
            {
                if (((Masa)mese[i]).Afisare_Masa() != null)
                    Console.WriteLine(((Masa)mese[i]).Afisare_Masa());
            }
        }

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

        public static void AfisareMancare(ArrayList mancare)
        {
            Console.WriteLine("Bauturile din meniu sunt:");
            for (int i = 0; i < mancare.Count; i++)
            {
                Console.WriteLine(((Mancare)mancare[i]).Afisare_Mancare());
            }
        }

        public static Bautura AddBautura_Citire_Consola()
        {
            Bautura baut;
            do
            {
                string denumire, pret;

                Console.WriteLine("\nIntroduceti informatiile bauturii pe care doriti sa o adaugati:");
                Console.WriteLine("\t-Denumire bautura:");
                denumire = Console.ReadLine();

                Console.WriteLine("\t-Pret produs:");
                pret = Console.ReadLine();
                pret = pret.Replace(',', '.');

                string add = $"{denumire};{pret}";

                bool consola = true;
                baut = new Bautura(add, consola);
            } while (baut.pret == -1);

            return baut;
        }

        public static void AfisareBautura(ArrayList bautura)
        {
            Console.WriteLine("Bauturile din meniu sunt:");
            for (int i = 0; i < bautura.Count; i++)
            {
                Console.WriteLine(((Bautura)bautura[i]).Afisare_Bautura());
            }
        }

    }
}

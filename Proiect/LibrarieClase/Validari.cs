
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibrarieClase
{
    public class Validari
    {
        public static float Validare_ConvertToFloat_Pret_Meniu(string info_x)
        {
            float pret = 0;
            int ok = 0, nr = 0, nr_decimals = 0;
            try
            {
                for (int i = 0; i < info_x.Length; i++)
                {
                    if (info_x[i] != ',' && ok == 0)
                        nr++;
                    else
                    if (info_x[i] == ',')
                        ok = i;

                    if (info_x[i] != ',' && ok != 0)
                        nr_decimals++;
                }
                pret = float.Parse(info_x, System.Globalization.CultureInfo.InvariantCulture);
                while (nr_decimals != 0)
                {
                    pret /= 10;
                    nr_decimals--;
                }
            }
            catch
            {
                pret = -1;
                Console.WriteLine("\nAti introdus gresit datele de intrare!\n");
            }

            return pret;

        }

        public static int Validare_Cod_Unic(Masa b, string NumeFisier)
        {
            /*Citesc din fisier codurile unice, apoi verific daca codul unic generat cand s-a introdus masa la consola este egal cu vreun cod deja existent. Daca da, generez pana cand cele doua nu sunt egale*/
            List<Masa> _masa = new List<Masa>();
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
            return b.cod_unic;
        }

        public static bool Validare_Date_Rezervare(string nume, string prenume, string cnp)
        {
            if (nume == ""|| prenume == "" || cnp == "")
                return false;
            return true;
        }

        public static bool Admin_Validare_Date_Meniu(string tip, string denumire, string pret)
        {
            if (tip == "" || denumire == "" || pret == "")
                return false;
            return true;
        }


    }
}
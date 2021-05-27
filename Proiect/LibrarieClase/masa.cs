using System;
using System.Globalization;

namespace LibrarieClase
{
    public class Masa
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        public int id { get; set; }
        public static int last_id { get; set; } = 0;
        public int locuri { get; set; } = 0;
        public bool ocupat { get; set; } = false;
        public int cod_unic { get; set; } = 0; // va fi generat random
        public float total_plata { get; set; } = 0;
        public string locatie { get; set; }

        // urmeaza functii

        public Masa()
        {
            last_id++;
            id = last_id;
            locuri = cod_unic = 0;
            ocupat = false;
            total_plata = 0;
            locatie = string.Empty;
        }
        public Masa(string informatii_masa, bool citit_din_consola = false)
        {
            string[] info_masa = informatii_masa.Split(';');

            try
            {
                if (citit_din_consola == false) /*numarul de ordine al campurilor clasei depind de locul de unde sunt preluate informatiile ( consola sau mese.txt )*/
                    locuri = Convert.ToInt32(info_masa[1]);
                else
                    locuri = Convert.ToInt32(info_masa[0]); // am citit de la consola

            }
            catch (FormatException)
            {
                Console.WriteLine("Incorect! Trebuie introdus un numar intreg pozitiv!");
                locuri = -1;
            }
            if( locuri != -1 )
                if (citit_din_consola == false) // citire din fisier
                {
                    id = Convert.ToInt32(info_masa[0]);
                    last_id = id;
                    ocupat = Convert.ToBoolean(info_masa[2]);
                    cod_unic = Convert.ToInt32(info_masa[3]);

                    if (ocupat == false)
                        total_plata = 0;
                    else
                        total_plata = float.Parse(info_masa[4], CultureInfo.InvariantCulture.NumberFormat);
                    locatie = info_masa[5];
                }
                else // am citit de la consola
                {
                    cod_unic = GenerareCodUnic();
                    //if (Validari.Verificare_CodUnic == true)
                            
                    last_id++;
                    id = last_id;
                    ocupat = false; /*Daca se introduce manual o masa atunci codul va fi generat automat*/
                    total_plata = 0;
                    locatie = info_masa[1];
                }


        }
        public int GenerareCodUnic()
        {
            var rand = new Random();
            int nr;
            int[] verificare = { 11111, 22222, 33333, 44444, 55555,
                                 66666, 77777, 88888, 99999, 12345,
                                 23456, 34567, 45678, 56789, 98765,
                                 87654, 76543, 65432, 54321};
            do
            {
                nr = rand.Next(10010, 99999);
                if (Array.Exists(verificare, element => element == nr) == false)
                    break;
            } while (true);

            return nr;
        }

        public string ConversieLaSir_PentruAfisare(int id_pentru_afisare_info_client = 0)
        {
            if (id_pentru_afisare_info_client == 0) // afisare normala pt mese disponibile
            {
                if (ocupat == false)
                {
                    //return $"\tMasa cu   ID [ {id} ]   se afla in    [ {locatie_masa}\t]\tsi are [ {locuri} ] locuri disponibile.";
                    return $"\t\t[ {id} ] \t\t [ {locatie} ] \t\t [ {locuri} ]";
                }
                /*else
                    s = $"\t[ OCUPAT ] Masa [ {id} ] nu este disponibila.";*/
            }
            else // afisez informatii pentru cazul in care un client vrea sa rezerve si e nevoie de afisare mese libere
            {
                return $"\t Masa cu ID [ {id_pentru_afisare_info_client} ] se afla in [ {locatie} ] si are [ {locuri} ] cu total de plata [ {total_plata} ].";
            }
            
            return null;
        }

        public string ConversieLaSir_PentruScriereInFisier()
        {
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}",
                SEPARATOR_PRINCIPAL_FISIER, id.ToString(), locuri.ToString(), ocupat.ToString(), cod_unic.ToString(), total_plata.ToString(), ( locatie ?? "NEDEFINIT") );

            return s;
        }


        public static string compara_mese(Masa ob1, Masa ob2)
        {
            if (ob1.locuri > ob2.locuri)
                return ($"Masa {ob1.id} are mai multe locuri decat masa {ob2.id}");
            else
                return ($"Masa {ob2.id} are mai multe locuri decat masa {ob1.id}");
        }
    }
}

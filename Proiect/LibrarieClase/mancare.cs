using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieClase
{
    public class Mancare
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int DENUMIRE = 1;
        private const int PRET = 2;

        public int id { get; set; }
        public static int last_id { get; set; } = 0;
        public string denumire { get; set; }
        public float pret { get; set; } = 0;

        public Mancare()
        {
            last_id++;
            id = last_id;
            denumire = string.Empty;
            pret = 0;
        }

        public Mancare(string _mancare, bool citit_din_consola = false)
        {
            string[] info_mancare = _mancare.Split(';');
            /*for (var j = 0; j < info_mancare.Length; j++)
            {
                for (var i = 0; i < info_mancare[j].Length; i++)
                    Console.WriteLine($"---{info_mancare[j][i]}");
                Console.WriteLine("\nbla\n");
            }*/
            if (citit_din_consola == false) // daca am citit din fisier text, pret e pe pozitia 2 in fisier
                pret = Validari.Validare_ConvertToFloat_Pret_Meniu(info_mancare[2]);
            else
                pret = Validari.Validare_ConvertToFloat_Pret_Meniu(info_mancare[1]);

            if (pret != -1)
            {
                last_id++;
                id = last_id;

                if (citit_din_consola == false)
                    denumire = info_mancare[1];
                else
                    denumire = info_mancare[0];
            }
            else
            {
                //last_id++;
                id = last_id;
                denumire = string.Empty;
            }
        }

        public string Afisare_Mancare()
        {
            string s = $"\t[ {id} ]. [ {denumire} ] are pretul [ {pret} ]";
            return s;
        }

        public string ConversieLaSir_PentruScriereInFisier()
        {
            string s = string.Format("{1}{0}{2}{0}{3}",
                SEPARATOR_PRINCIPAL_FISIER, id.ToString(), (denumire ?? " NECUNOSCUT "), pret.ToString());

            return s;
        }
    }
}

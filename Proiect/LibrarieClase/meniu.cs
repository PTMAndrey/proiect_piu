using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieClase
{
    public class Meniu
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        public int id { get; set; }
        public static int last_id { get; set; } = 0;
        public string denumire { get; set; }
        public float pret { get; set; } = 0;
        public string tip_aliment { get; set; }
        public string[] ingrediente { get; set; }

        public Meniu()
        {
            //last_id++;
            id = 0;
            denumire = string.Empty;
            pret = 0;
            tip_aliment = string.Empty;
        }

        public Meniu(string _bautura, bool citit_din_consola = false)
        {
            string[] info_bautura = _bautura.Split(';');
            /*for (int i = 0; i < info_bautura.Length; i++)
                Console.WriteLine(info_bautura[i] + " ");
            Console.ReadKey();*/
            if (citit_din_consola == false) // daca am citit din fisier text, pret e pe pozitia 2 in fisier
                pret = Validari.Validare_ConvertToFloat_Pret_Meniu(info_bautura[2]);
            else
                pret = Validari.Validare_ConvertToFloat_Pret_Meniu(info_bautura[1]);

            if (pret != -1)
            {

                if (citit_din_consola == false)
                {
                    id = Convert.ToInt32(info_bautura[0]);
                    denumire = info_bautura[1];
                    tip_aliment = info_bautura[3];
                }
                else
                {
                    last_id++;
                    id = last_id;
                    denumire = info_bautura[0];
                    tip_aliment = info_bautura[2];
                }
            }
            else // eroare din cauza pretului
            {
                last_id++;
                id = last_id;
                denumire = string.Empty;
                tip_aliment = string.Empty;
            }
        }

        public string ConversieLaSir_PentruAfisare()
        {
            if (pret < 10)
                return $"\t[ {id} ].  [  {pret.ToString("F", CultureInfo.InvariantCulture)} ] RON  \t[ {denumire} ]";
            else
                return $"\t[ {id} ].  [ {pret.ToString("F", CultureInfo.InvariantCulture)} ] RON  \t[ {denumire} ]";
        }

        public string ConversieLaSir_PentruScriereInFisier()
        {
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}",
                SEPARATOR_PRINCIPAL_FISIER, id.ToString(), (denumire ?? " NECUNOSCUT "), pret.ToString(), (tip_aliment ?? "NECUNOSCUT"));

            return s;
        }
    }
}
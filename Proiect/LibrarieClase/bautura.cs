using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieClase
{
    public class Bautura
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        public int id { get; set; }
        public static int last_id { get; set; } = 0;
        public string denumire { get; set; }
        public float pret { get; set; } = 0;

        public Bautura()
        {
            last_id++;
            id = last_id;
            denumire = string.Empty;
            pret = 0;
        }

        public Bautura(string _bautura, bool citit_din_consola = false)
        {

            string[] info_bautura = _bautura.Split(';');
            if (citit_din_consola == false) // daca am citit din fisier text, pret e pe pozitia 2 in fisier
                pret = Validari.Validare_ConvertToFloat_Pret_Meniu(info_bautura[2]);
            else
                pret = Validari.Validare_ConvertToFloat_Pret_Meniu(info_bautura[1]);

            if (pret != -1)
            {

                last_id++;
                id = last_id;

                if (citit_din_consola == false)
                    denumire = info_bautura[1];
                else
                    denumire = info_bautura[0];
            }
            else 
            {
                last_id++;
                id = last_id;
                denumire = string.Empty;
            }
        }

        public string Afisare_Bautura()
        {
            string s = $"\t[ {id} ]. Sticla [ {denumire} ] are pretul [ {pret.ToString("F", CultureInfo.InvariantCulture)} ]";
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

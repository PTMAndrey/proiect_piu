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

        public Meniu()
        {
            id = 0;
            denumire = string.Empty;
            pret = 0;
            tip_aliment = string.Empty;
        }

        public Meniu(string _bautura, bool citit_din_consola = false)
        {
            string[] info_bautura = _bautura.Split(';');
            pret = Validari.Validare_ConvertToFloat_Pret_Meniu(info_bautura[2]);
            id = Convert.ToInt32(info_bautura[0]);
            denumire = info_bautura[1];
            tip_aliment = info_bautura[3];

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
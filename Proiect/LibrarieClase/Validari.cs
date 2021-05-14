
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
    }
}
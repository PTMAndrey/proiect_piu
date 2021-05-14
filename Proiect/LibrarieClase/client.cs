using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieClase
{
    public class Client
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        public int id { get; set; }
        public static int last_ID { get; set; } = 0;
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public int ID_Masa { get; set; } = 0;
        public Client()
        {
            Nume = Prenume = CNP = string.Empty;
            last_ID++;
            id = last_ID;
            ID_Masa = 0;
        }
        public Client(string _Client, bool citit_din_consola = false)
        {
            string[] info_client = _Client.Split(';');
            //if (citit_din_consola == false) // citire din fisier
            //{
                last_ID++;
                id = Convert.ToInt32(info_client[0]);
                Nume = info_client[1];
                Prenume = info_client[2];
                CNP = info_client[3];
                ID_Masa = Convert.ToInt32(info_client[4]);
            //}
            //else // citire din consola
            /*{
                last_ID++;
                id = last_ID;
                Nume = info_client[0];
                Prenume = info_client[1];
                CNP = info_client[2];
                ID_Masa = Convert.ToInt32(info_client[3]);

            }*/

        }

        public string Afisare_Client(Masa m)
        {
            string s = $"\t[ {id} ]. Clientul [ {Nume} {Prenume} ] se afla la masa [ {ID_Masa} ]\n";
            
             
            s += $"\t\tMasa cu ID {ID_Masa} are {m.locuri} locuri avand suma totala de plata {m.total_plata}";
            return s;
        }


        public string ConversieLaSir_PentruScriereInFisier()
        {
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}",
                SEPARATOR_PRINCIPAL_FISIER, id.ToString(), (Nume ?? " NECUNOSCUT "), (Prenume ?? " NECUNOSCUT "), CNP.ToString(), ID_Masa.ToString());

            return s;
        }
    }
}

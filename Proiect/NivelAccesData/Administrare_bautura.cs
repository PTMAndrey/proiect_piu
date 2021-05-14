using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibrarieClase;

namespace NivelAccesData
{
    public class Administrare_bautura : IStocareBautura
    {
        string NumeFisier { get; set; } = "bautura.txt";

        public Administrare_bautura()
        {
            Stream sFisierText = File.Open(NumeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sFisierText.Close();
            //using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }

        public ArrayList GetInfoBautura()
        {
            ArrayList _bautura = new ArrayList();


            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Studenumiret pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Bautura bauturaDinFisier = new Bautura(line);
                    _bautura.Add(bauturaDinFisier);
                }
            }

            return _bautura;
        }
        public Bautura GetBautura(string denumire)
        {
            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Bautura bauturaDinFisier = new Bautura(line);
                    if (bauturaDinFisier.denumire == denumire)
                        return bauturaDinFisier;
                }
            }

            return null;
        }

        public void AddBauturaFisier(Bautura b)
        {
            //instructiunea 'using' va apela la final swFisierText.Close();
            //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
            using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
            {
                swFisierText.WriteLine(b.ConversieLaSir_PentruScriereInFisier());
            }
        }
    }
}

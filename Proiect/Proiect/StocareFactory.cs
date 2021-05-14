using NivelAccesData;
using System.Configuration;
using System;

namespace Proiect
{
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisier";
        public static IStocareData GetInfoMese()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisier = ConfigurationManager.AppSettings["NumeFisierMese"];
            if (formatSalvare != null)
            {
                /*switch (formatSalvare)
                {
                    default:
                    case "bin":
                        return new AdministrareStudenti_FisierBinar(numeFisier + "." + formatSalvare);
                    case "txt":
                        return new AdministrareStudenti_FisierText(numeFisier + "." + formatSalvare);
                }*/
            }

            return null;
        }
    }
}

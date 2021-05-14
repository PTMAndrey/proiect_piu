using System;
using System.Collections;
using LibrarieClase;

namespace NivelAccesData
{
    //definitia interfetei
    public interface IStocareBautura
    {
        ArrayList GetInfoBautura();
        Bautura GetBautura(string denumire);
        void AddBauturaFisier(Bautura b);
    }
}

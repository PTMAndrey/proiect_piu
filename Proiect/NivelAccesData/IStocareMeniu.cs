using System;
using System.Collections;
using LibrarieClase;

namespace NivelAccesData
{
    //definitia interfetei
    public interface IStocareMeniu
    {
        ArrayList GetInfo();
        Meniu GetInfo(string denumire);
        void Add(Meniu b);
    }
}

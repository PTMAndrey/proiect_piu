using System;
using System.Collections.Generic;
using LibrarieClase;

namespace NivelAccesData
{
    //definitia interfetei
    public interface IStocareMeniu
    {
        List<Meniu> GetInfo();
        Meniu GetInfo(int id);
        void Add(Meniu b);
        public bool UpdateMeniu(Meniu m, bool inceput = false);
    }
}

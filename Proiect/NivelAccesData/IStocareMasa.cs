using System;
using System.Collections;
using LibrarieClase;

namespace NivelAccesData
{
    //definitia interfetei
    public interface IStocareMasa
    {
        ArrayList GetInfo();
        bool UpdateMasa(string _id, string _locuri, bool ocupat = false);
        void AddMasa(Masa b);
        string GetInfoMasaPentruClient(int ID);
        Masa CautaMasa(string id_masa);
    }
}

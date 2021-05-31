using System;
using System.Collections.Generic;
using LibrarieClase;

namespace NivelAccesData
{
    //definitia interfetei
    public interface IStocareMasa
    {
        List<Masa> GetInfo();
        bool UpdateMasa(int _id, bool ocupat = false, string update_total_plata = "");
        void AddMasa(Masa b);
        string GetInfoMasaPentruClient(int ID);
        Masa Cauta(string locatie);
    }
}

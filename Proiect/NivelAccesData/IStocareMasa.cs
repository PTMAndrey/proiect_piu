using System;
using System.Collections.Generic;
using LibrarieClase;

namespace NivelAccesData
{
    //definitia interfetei
    public interface IStocareMasa
    {
        List<Masa> GetInfo();
        bool UpdateMasa(int _id, bool ocupat = false, int locuri = 0, string locatie = "", string update_total_plata = "", bool eliberare_masa = false);
        void AddMasa(Masa b);
        string GetInfoMasaPentruClient(int ID);
        Masa Cauta(string locatie);
    }
}

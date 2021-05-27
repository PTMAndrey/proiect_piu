using System;
using System.Collections.Generic;
using LibrarieClase;

namespace NivelAccesData
{
    //definitia interfetei
    public interface IStocareMasa
    {
        List<Masa> GetInfo();
        bool UpdateMasa(int _id);
        void AddMasa(Masa b);
        string GetInfoMasaPentruClient(int ID);
        Masa Cauta(string locatie);
        public int Generare_Cod_Unic(Masa b);
    }
}

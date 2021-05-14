using System;
using System.Collections;
using LibrarieClase;

namespace NivelAccesData
{
    //definitia interfetei
    public interface IStocareMancare
    {   
        ArrayList GetInfoMancare();
        void AddMancareFisier(Mancare b);
    }
}

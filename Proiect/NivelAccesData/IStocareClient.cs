using System;
using System.Collections;
using LibrarieClase;

namespace NivelAccesData
{
    //definitia interfetei
    public interface IStocareClient
    {
        ArrayList GetInfoClient();
        Client CautaClient(string cnp);
        void AddClientFisier(Client b);
    }
}

using System;
using System.Collections.Generic;
using LibrarieClase;

namespace NivelAccesData
{
    //definitia interfetei
    public interface IStocareClient
    {
        List<Client> GetInfo();
        Client CautaClient(string cnp);
        void AddClient(Client b);
    }
}

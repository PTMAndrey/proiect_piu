﻿using System;
using System.Collections;
using LibrarieClase;

namespace NivelAccesData
{
    //definitia interfetei
    public interface IStocareClient
    {
        ArrayList GetInfo();
        Client CautaClient(string cnp);
        void AddClient(Client b);
    }
}

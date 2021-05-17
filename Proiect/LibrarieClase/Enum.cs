using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieClase
{
    // ####################### MASA ############################
   public enum Locatie
    {
        Interior = 1,
        Separeu = 2,
        Terasa = 3
    }


    // ####################### ALIMENTE ############################

    public enum Tip_aliment
    {
        Mancare = 1,
        Bautura = 2,
        Desert = 3
    }

    [Flags]

    public enum Ingrediente
    {
        oua = 1,
        lapte = 2,
        branza = 3,
        smantana = 4,
        mozzarella = 5,
        salam = 6,
        sunca = 7,
        bacon = 8,
        zmeura = 9,
        banane = 10,
        lamaie = 11,
        portocale = 12,
        grapefruit = 13,
        ciocolata = 14,
        vanilie = 15,
        rom = 16,
        scortisoara = 17,
        sifon = 18

    }
}

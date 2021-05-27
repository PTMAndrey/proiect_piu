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
        mozzarella = 3,
        crap = 4,
        salam = 5,
        sunca = 6,
        pui = 7,
        rosii = 8,
        ardei = 9,
        masline = 10,
        lamaie = 11,
        portocale = 12,
        capsuni = 13,
        ciocolata = 14,
        vodca = 15,
        scortisoara = 16
    }
}

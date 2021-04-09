using System;
using System.Collections.Generic;
using System.Text;

namespace GAMEOFTHRONES
{
    static class moneycollector
    {
        static public void Moneycollector(this HouseBolton houseBolton)
        {
            houseBolton += HouseBolton.Boltons_people;
        }
        static public void Moneycollector(this HouseCerwyn houseCerwyn)
        {
            houseCerwyn += HouseCerwyn.Cerwyns_people;
        }
        static public void Moneycollector(this HouseGlover houseGlover)
        {
            houseGlover += HouseGlover.Glovers_people;
        }
        static public void Moneycollector(this HouseHornwood houseHornwood)
        {
            houseHornwood += HouseHornwood.Hornwoods_people;
        }
        static public void Moneycollector(this HouseMormont houseMormont)
        {
            houseMormont += HouseMormont.Mormonts_people;
        }
        static public void Moneycollector(this HouseReed houseReed)
        {
            houseReed += HouseReed.Reeds_people;
        }
        static public void Moneycollector(this HouseStark houseStark)
        {
            houseStark += HouseStark.Starks_people;
        }
    }
}

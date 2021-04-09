using System;
using System.Collections.Generic;
using System.Text;

namespace GAMEOFTHRONES
{
    class KINGINTHENORTH
    {
        public int treasury { get; set; }
        public static List<northhuman> CouncilMembers = new List<northhuman>();
        public static int Kingcounter { get; set; }
        public  Age Age { get; set; } 
        public  bool Isalive { get; set; } 
        public string Name { get; set; } 
        public northHouses kingshouse { get; set; }
        public HousesCapitals KingdomCapital; 
        public string Councilmeetingtime { get; set; } 
        public northhuman this[int index]
        {
            get { return KINGINTHENORTH.CouncilMembers[index]; }
            set { CouncilMembers[index] = value; }
        }
        public KINGINTHENORTH()
        {
            north.Northcapital = KingdomCapital;
            north.Rulers = kingshouse;
            Kingcounter++;
            if(Kingcounter>1)
            {
                throw new Exception("can't be two king");
            }
            north.king = this;
        }
    }
    
}

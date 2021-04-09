using System;
using System.Collections.Generic;
using System.Text;

namespace GAMEOFTHRONES
{
    class NORTHLORD
    {
        public Profesions profesion { get; set; }
        public static HashSet<northHouses> northHouses_checker = new HashSet<northHouses>();
        public int Age { get; set; } 
        public string Name { get; set; }
        public bool Isalive { get; set; }
        public northHouses LordHouse { get; }
        public NORTHLORD(northHouses _northHouses)
        {
            Isalive = true;
            LordHouse = _northHouses;
            int a = 0;
            foreach (var item in northHouses_checker)
            {
                if(item== LordHouse)
                {
                    a = 1;
                    throw new Exception("you can't have two lord in same house");
                }
            }
            if(a==0)
            {
                northHouses_checker.Add(LordHouse);
            }
        }
        public void NOrthLord_died()
        {
            if(Isalive == false)
            {
                northHouses_checker.Remove(LordHouse);
            }
        }
    }
}

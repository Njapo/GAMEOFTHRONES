using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace GAMEOFTHRONES
{
    static class north  
    {
        public static List<northhuman> northpeople { get; set; } = new List<northhuman>();
        public static List<northhuman> northsoldiers { get; set; } = new List<northhuman>();
        public static KINGINTHENORTH king { get; set; } 
        public static northHouses? Rulers { get; set; }
        public static HousesCapitals? Northcapital{ get; set; } 
        public static void North_collect_army()
        {
            northsoldiers = northpeople.GroupBy(a=>a.GetType()).SelectMany(a=>a.Where(a =>a.Isalive == true && a.Profesion == Profesions.soldier && a.Gender == gender.male && (int)a.age >= 19 && (int)a.age <= 65 || (a.Isalive == true && (int)a.age >= 19 && (int)a.age <= 40) && a.Gender == gender.male)).ToList();
        }
        public static HouseBolton HouseBolton{get;set;}
        public static HouseCerwyn HouseCerwyn{get;set;}
        public static HouseGlover HouseGlover{get;set;}
        public static HouseStark HouseStark  {get;set;}
        public static HouseReed HouseReed  {get;set;}
        public static HouseMormont HouseMormont { get; set; }
        public static HouseHornwood HouseHornwood { get; set; }
    }
}
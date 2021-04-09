using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace GAMEOFTHRONES
{
    class HouseBolton
    { 
        public static int Treasury { get; set; }
        public static new string Words { get; set; }
        public static NORTHLORD NorthLord { get; set; }
        public static northHouses houseRulers = northHouses.HouseBolton;
        public static HousesCapitals housesCapital = HousesCapitals.Dreadfort;
        public static List<Bolton>? Boltons_people = new List<Bolton>();
        public static List<Bolton>? Boltons_soldiers = new List<Bolton>();
        private static int Housecounter{ get; set; }
        public HouseBolton(NORTHLORD _NorthLord)
        {
            Housecounter++;
            if(Housecounter>1)
            {
                throw new Exception("can't be tow same house");
            }
            north.HouseBolton = this;
            NorthLord = _NorthLord;
        }
        public static void soldier_colector()
        {
            Boltons_soldiers = Boltons_people.Where(a => (a.Isalive == true && a.Profesion == Profesions.soldier && a.Gender==gender.male && (int)a.age >= 19 && (int)a.age <= 65) || (a.Isalive == true && (int)a.age >= 19 && (int)a.age <= 40) && a.Gender==gender.male).ToList();
        }
        public static HouseBolton operator +(HouseBolton houseBolton, List<Bolton> boltons_people)
        {
            for (int i = 0; i < boltons_people.Count; i++)
            {
                HouseBolton.Treasury += (boltons_people[i].money / 10);
                boltons_people[i].money -= (boltons_people[i].money / 10);
            }
            return houseBolton;
        }
        public static void Houseupdate()
        {
            for (int i = 0; i < HouseBolton.Boltons_people.Count; i++)
            {
                HouseBolton.Boltons_people[i].update();
            }
        }
    }
    class HouseStark
    { 
        public static int Treasury { get; set; }
        public static  new string Words { get; }
        public static NORTHLORD NorthLord;
        public static northHouses houseRulers = northHouses.HouseStark;
        public static HousesCapitals housesCapital = HousesCapitals.winterfell;
        public static List<Stark>? Starks_people = new List<Stark>();
        public static List<Stark>? Starks_soldiers = new List<Stark>();
        public static void soldier_colector()
        { 
            Starks_soldiers = Starks_people.Where(a => (a.Isalive == true && a.Profesion == Profesions.soldier && a.Gender == gender.male && (int)a.age >= 19 && (int)a.age <= 65) || (a.Isalive == true && (int)a.age >= 19 && (int)a.age <= 40) && a.Gender == gender.male).ToList();
        }
        public HouseStark(NORTHLORD _NorthLord)
        {
            north.HouseStark = this;
            NorthLord = _NorthLord;
        }
        public static HouseStark operator +(HouseStark houseStark, List<Stark> starks_people)
        {
            for (int i = 0; i < starks_people.Count; i++) 
            {
                HouseStark.Treasury += (starks_people[i].money / 10);
                starks_people[i].money -= (starks_people[i].money / 10);
            } 
            return houseStark;
        }
        public static void Houseupdate()
        {
            for (int i = 0; i < HouseStark.Starks_people.Count; i++)
            {
                HouseStark.Starks_people[i].update();
            }
        }
    }
    class HouseCerwyn
    {
        public static int Treasury { get; set; }
        public static new string Words { get; set; }
        public static NORTHLORD NorthLord;
        public static northHouses houseRulers = northHouses.HouseCerwyn;
        public static HousesCapitals housesCapital = HousesCapitals.CastleCerwyn;
        public static List<Cerwyn>? Cerwyns_people = new List<Cerwyn>();
        public static List<Cerwyn>? Cerwyns_soldiers = new List<Cerwyn>();
        public static void soldier_colector()
        {
            Cerwyns_soldiers = Cerwyns_people.Where(a => (a.Isalive == true && a.Profesion == Profesions.soldier && a.Gender == gender.male && (int)a.age >= 19 && (int)a.age <= 65) || (a.Isalive == true && (int)a.age >= 19 && (int)a.age <= 40) && a.Gender == gender.male).ToList();
        }
        public HouseCerwyn(NORTHLORD _NorthLord) 
        {
            north.HouseCerwyn = this;
            NorthLord = _NorthLord; 
        }
        public static HouseCerwyn operator +(HouseCerwyn houseCerwyn, List<Cerwyn> Cerwyns_people)
        {
            for (int i = 0; i < Cerwyns_people.Count; i++)
            {
                HouseCerwyn.Treasury += (Cerwyns_people[i].money / 10);
                Cerwyns_people[i].money -= (Cerwyns_people[i].money / 10);
            }
            return houseCerwyn; 
        }
        public static void Houseupdate()
        {
            for (int i = 0; i < HouseCerwyn.Cerwyns_people.Count; i++)
            {
                HouseStark.Starks_people[i].update();
            }
        }
    }
    class HouseGlover 
    {
        public static int Treasury { get; set; }
        public static new string Words { get; set; }
        public static NORTHLORD NorthLord;
        public static northHouses houseRulers = northHouses.HouseGlover;
        public static HousesCapitals housesCapital = HousesCapitals.DeepwoodMotte;
        public static List<Glover>? Glovers_people = new List<Glover>();
        public static List<Glover>? Glovers_soldiers = new List<Glover>();
        public static void soldier_colector()
        {
            Glovers_soldiers = Glovers_people.Where(a => (a.Isalive == true && a.Profesion == Profesions.soldier && a.Gender == gender.male && (int)a.age >= 19 && (int)a.age <= 65) || (a.Isalive == true && (int)a.age >= 19 && (int)a.age <= 40) && a.Gender == gender.male).ToList();
        }
        public HouseGlover(NORTHLORD _NorthLord) 
        {
            north.HouseGlover = this;
            NorthLord = _NorthLord; 
        } 
        public static HouseGlover operator +(HouseGlover houseGlover, List<Glover> Glovers_people)
        {
            for (int i = 0; i < Glovers_people.Count; i++)
            {
                HouseGlover.Treasury += (Glovers_people[i].money / 10);
                Glovers_people[i].money -= (Glovers_people[i].money / 10);
            }
            return houseGlover;
        }
        public static  void Houseupdate()
        {
            for (int i = 0; i < HouseGlover.Glovers_people.Count; i++)
            {
                HouseStark.Starks_people[i].update();
            }
        }
    }
    class HouseMormont 
    {
        public static int Treasury { get; set; }
        public static new string Words { get; set; }
        public static NORTHLORD NorthLord;
        public static northHouses houseRulers = northHouses.HouseMormont;
        public static HousesCapitals housesCapital = HousesCapitals.BearIsland;
        public static List<Mormont>? Mormonts_people = new List<Mormont>();
        public static List<Mormont>? Mormonts_soldiers = new List<Mormont>();
        public static  void soldier_colector()
        {
            Mormonts_soldiers = Mormonts_people.Where(a => (a.Isalive == true && a.Profesion == Profesions.soldier && a.Gender == gender.male && (int)a.age >= 19 && (int)a.age <= 65) || (a.Isalive == true && (int)a.age >= 19 && (int)a.age <= 40) && a.Gender == gender.male).ToList();
        }
        public HouseMormont(NORTHLORD _NorthLord) 
        {
            north.HouseMormont = this;
            NorthLord = _NorthLord;
        }
        public static HouseMormont operator +(HouseMormont houseMormont, List<Mormont> Mormonts_people)
        {
            for (int i = 0; i < Mormonts_people.Count; i++)
            {
                HouseMormont.Treasury += (Mormonts_people[i].money / 10);
                Mormonts_people[i].money -= (Mormonts_people[i].money / 10);
            }
            return houseMormont;
        }
        public static void Houseupdate()
        {
            for (int i = 0; i < HouseMormont.Mormonts_people.Count; i++)
            {
                HouseStark.Starks_people[i].update();
            }
        }
    }
    class HouseReed
    {
        public static int Treasury { get; set; }
        public static new string Words { get; set; }
        public static NORTHLORD NorthLord;
        public static northHouses houseRulers = northHouses.HouseReed;
        public static HousesCapitals housesCapital = HousesCapitals.GreywaterWatch;
        public static List<Reed>? Reeds_people = new List<Reed>();
        public static List<Reed>? Reeds_soldiers = new List<Reed>();
        public static  void soldier_colector()
        {
            Reeds_soldiers = Reeds_people.Where(a => (a.Isalive == true && a.Profesion == Profesions.soldier && a.Gender == gender.male && (int)a.age >= 19 && (int)a.age <= 65) || (a.Isalive == true && (int)a.age >= 19 && (int)a.age <= 40) && a.Gender == gender.male).ToList();
        }
        public HouseReed(NORTHLORD _NorthLord) 
        {
            north.HouseReed = this;
            NorthLord = _NorthLord;
        }
        public static HouseReed operator +(HouseReed houseReed, List<Reed> Reeds_people)
        {
            for (int i = 0; i < Reeds_people.Count; i++)
            {
                HouseReed.Treasury += (Reeds_people[i].money / 10);
                Reeds_people[i].money -= (Reeds_people[i].money / 10);
            }
            return houseReed;
        }
        public static void Houseupdate()
        {
            for (int i = 0; i < HouseReed.Reeds_people.Count; i++)
            {
                HouseStark.Starks_people[i].update();
            }
        }
    }
    class HouseHornwood 
    {
        public static int Treasury { get; set; }
        public static new string Words { get; set; }
        public static NORTHLORD NorthLord;
        public static northHouses houseRulers = northHouses.HouseHornwood;
        public static HousesCapitals housesCapital = HousesCapitals.Hornwood;
        public static List<Hornwood>? Hornwoods_people = new List<Hornwood>();
        public static List<Hornwood>? Hornwoods_soldiers = new List<Hornwood>();
        public static void soldier_colector()
        {
            Hornwoods_soldiers = Hornwoods_people.Where(a => (a.Isalive == true && a.Profesion == Profesions.soldier && a.Gender == gender.male && (int)a.age >= 19 && (int)a.age <= 65) || (a.Isalive == true && (int)a.age >= 19 && (int)a.age <= 40) && a.Gender == gender.male).ToList();
        }
        public HouseHornwood(NORTHLORD _NorthLord) 
        {
            north.HouseHornwood = this;
            NorthLord = _NorthLord;
        }
        public static HouseHornwood operator +(HouseHornwood houseHornwood, List<Hornwood> Hornwoods_people)
        {
            for (int i = 0; i < Hornwoods_people.Count; i++)
            {
                HouseHornwood.Treasury += (Hornwoods_people[i].money / 10);
                Hornwoods_people[i].money -= (Hornwoods_people[i].money / 10);
            }
            return houseHornwood;
        } 
        public static void Houseupdate()
        {
            for (int i = 0; i < HouseHornwood.Hornwoods_people.Count; i++)
            {
                HouseStark.Starks_people[i].update();
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;
namespace GAMEOFTHRONES
{
    static  class WriteInfo
    {
        public static void Writeinfo(this Stark stark,string filename)
        {
            XDocument xDocument = new XDocument();
            var weaponslist = stark.Weapons.Select(weapons =>new XElement("weapon",weapons));
            XElement xElement = new XElement("name", stark.Name,
                new XElement("Profesions", stark.Profesion),new XElement("Age",stark.age),
                new XElement("money",stark.money),new XElement("Gender",stark.Gender),
                new XElement("eyescolor",stark.Eyescolor),new XElement("isalive",stark.Isalive),new XElement("Health",stark.Health),
                new XElement("fight",new XAttribute("FightSkills",stark.FightSkills),new XAttribute("Durability",stark.Durability),new XAttribute("Quickness",stark.Quickness)),
                new XElement("weapons",weaponslist));
            xDocument.Add(xElement);
            xDocument.Save(filename);
        }
        public static void Writeinfo(this Mormont mormont, string filename)
        {
            XDocument xDocument = new XDocument();
            var weaponslist = mormont.Weapons.Select(weapons => new XElement("weapon", weapons));
            XElement xElement = new XElement("name", mormont.Name,
                new XElement("Profesions", mormont.Profesion), new XElement("Age", mormont.age),
                new XElement("money", mormont.money), new XElement("Gender", mormont.Gender),
                new XElement("eyescolor", mormont.Eyescolor), new XElement("isalive", mormont.Isalive), new XElement("Health", mormont.Health),
                new XElement("fight", new XAttribute("FightSkills", mormont.FightSkills), new XAttribute("Durability", mormont.Durability), new XAttribute("Quickness", mormont.Quickness)),
                new XElement("weapons", weaponslist));
            xDocument.Add(xElement);
            xDocument.Save(filename);
        }
        public static void Writeinfo(this Glover glover, string filename)
        {
            XDocument xDocument = new XDocument();
            var weaponslist = glover.Weapons.Select(weapons => new XElement("weapon", weapons));
            XElement xElement = new XElement("name", glover.Name,
                new XElement("Profesions", glover.Profesion), new XElement("Age", glover.age),
                new XElement("money", glover.money), new XElement("Gender", glover.Gender),
                new XElement("eyescolor", glover.Eyescolor), new XElement("isalive", glover.Isalive), new XElement("Health", glover.Health),
                new XElement("fight", new XAttribute("FightSkills", glover.FightSkills), new XAttribute("Durability", glover.Durability), new XAttribute("Quickness", glover.Quickness)),
                new XElement("weapons", weaponslist));
            xDocument.Add(xElement);
            xDocument.Save(filename);
        }
        public static void Writeinfo(this Reed reed, string filename)
        {
            XDocument xDocument = new XDocument();
            var weaponslist = reed.Weapons.Select(weapons => new XElement("weapon", weapons));
            XElement xElement = new XElement("name", reed.Name,
                new XElement("Profesions", reed.Profesion), new XElement("Age", reed.age),
                new XElement("money", reed.money), new XElement("Gender", reed.Gender),
                new XElement("eyescolor", reed.Eyescolor), new XElement("isalive", reed.Isalive), new XElement("Health", reed.Health),
                new XElement("fight", new XAttribute("FightSkills", reed.FightSkills), new XAttribute("Durability", reed.Durability), new XAttribute("Quickness", reed.Quickness)),
                new XElement("weapons", weaponslist));
            xDocument.Add(xElement);
            xDocument.Save(filename);
        }
        public static void Writeinfo(this Bolton bolton, string filename)
        {
            XDocument xDocument = new XDocument();
            var weaponslist = bolton.Weapons.Select(weapons => new XElement("weapon", weapons));
            XElement xElement = new XElement("name", bolton.Name,
                new XElement("Profesions", bolton.Profesion), new XElement("Age", bolton.age),
                new XElement("money", bolton.money), new XElement("Gender", bolton.Gender),
                new XElement("eyescolor", bolton.Eyescolor), new XElement("isalive", bolton.Isalive), new XElement("Health", bolton.Health),
                new XElement("fight", new XAttribute("FightSkills", bolton.FightSkills), new XAttribute("Durability", bolton.Durability), new XAttribute("Quickness", bolton.Quickness)),
                new XElement("weapons", weaponslist));
            xDocument.Add(xElement);
            xDocument.Save(filename);
        }
        public static void Writeinfo(this Hornwood hornwood, string filename)
        {
            XDocument xDocument = new XDocument();
            var weaponslist = hornwood.Weapons.Select(weapons => new XElement("weapon", weapons));
            XElement xElement = new XElement("name", hornwood.Name,
                new XElement("Profesions", hornwood.Profesion), new XElement("Age", hornwood.age),
                new XElement("money", hornwood.money), new XElement("Gender", hornwood.Gender),
                new XElement("eyescolor", hornwood.Eyescolor), new XElement("isalive", hornwood.Isalive), new XElement("Health", hornwood.Health),
                new XElement("fight", new XAttribute("FightSkills", hornwood.FightSkills), new XAttribute("Durability", hornwood.Durability), new XAttribute("Quickness", hornwood.Quickness)),
                new XElement("weapons", weaponslist));
            xDocument.Add(xElement);
            xDocument.Save(filename);
        }
        public static void Writeinfo(this Cerwyn cerwyn, string filename)
        {
            XDocument xDocument = new XDocument();
            var weaponslist = cerwyn.Weapons.Select(weapons => new XElement("weapon", weapons)).ToList();
            XElement xElement = new XElement("name", cerwyn.Name,
                new XElement("Profesions", cerwyn.Profesion), new XElement("Age", cerwyn.age),
                new XElement("money", cerwyn.money), new XElement("Gender", cerwyn.Gender),
                new XElement("eyescolor", cerwyn.Eyescolor), new XElement("isalive", cerwyn.Isalive), new XElement("Health", cerwyn.Health),
                new XElement("fight", new XAttribute("FightSkills", cerwyn.FightSkills), new XAttribute("Durability", cerwyn.Durability), new XAttribute("Quickness", cerwyn.Quickness)),
                new XElement("weapons", weaponslist));
            xDocument.Add(xElement);
            xDocument.Save(filename);
        }
        public static void writeinfo(this NORTHLORD nORTHLORD,string filename)
        {
            XDocument xDocument = new XDocument();
            XElement xElement = new XElement("name", nORTHLORD.Name, new XElement("LordHouse", nORTHLORD.LordHouse),
                new XElement("isalive", nORTHLORD.Isalive), new XElement("age",nORTHLORD.Age),new XElement("Profesion",nORTHLORD.profesion));
            xDocument.Add(xElement);
            xDocument.Save(filename); 
        }
        public static void writeinfo(this HouseBolton houseBolton, string filename)
        {
            XDocument xDocument = new XDocument();
            var sodiers = HouseBolton.Boltons_soldiers.Select(soldier =>new XElement("name",soldier.Name,new XElement("profession",soldier.Profesion),
               new XElement("Age",soldier.age),new XElement("money",soldier.money),new XElement("Gender",soldier.Gender),new XElement("eyescolor",soldier.Eyescolor),
               new XElement("Isalive",soldier.Isalive),new XElement("Health",soldier.Health),
               new XElement("fight",new XAttribute("Fightskills",soldier.FightSkills),new XAttribute("Durability", soldier.Durability), new XAttribute("Quickness", soldier.Quickness)))).ToList();
            
            var people= HouseBolton.Boltons_people.Select(soldier => new XElement("name", soldier.Name, new XElement("profession", soldier.Profesion),
                new XElement("Age", soldier.age), new XElement("money", soldier.money), new XElement("Gender", soldier.Gender), new XElement("eyescolor", soldier.Eyescolor),
                new XElement("Isalive", soldier.Isalive), new XElement("Health", soldier.Health))).ToList();
                
            XElement xElement = new XElement("HouseBolton", houseBolton, new XElement("HouseWords", HouseBolton.Words),
                new XElement("houseRulers",HouseBolton.houseRulers), new XElement("HousesCapitals", HouseBolton.housesCapital), new XElement("treasury",HouseBolton.Treasury),
                new XElement("northlord",new XElement("name",HouseBolton.NorthLord.Name),new XElement("age",HouseBolton.NorthLord.Age),
                new XElement("house",HouseBolton.NorthLord.LordHouse),new XElement("isalive",HouseBolton.NorthLord.Isalive),new XElement("profession",HouseBolton.NorthLord.profesion)),
                new XElement("soldiers",sodiers),new XElement("people",people));
            xDocument.Add(xElement);
            xDocument.Save(filename);
        }  
        public static void writeinfo(this HouseStark houseStark, string filename)
        {
            XDocument xDocument = new XDocument();
            var sodiers = HouseStark.Starks_soldiers.Select(soldier => new XElement("name", soldier.Name, new XElement("profession", soldier.Profesion),
               new XElement("Age", soldier.age), new XElement("money", soldier.money), new XElement("Gender", soldier.Gender), new XElement("eyescolor", soldier.Eyescolor),
               new XElement("Isalive", soldier.Isalive), new XElement("Health", soldier.Health),
               new XElement("fight", new XAttribute("Fightskills", soldier.FightSkills), new XAttribute("Durability", soldier.Durability), new XAttribute("Quickness", soldier.Quickness)))).ToList();

            var people = HouseStark.Starks_people.Select(soldier => new XElement("name", soldier.Name, new XElement("profession", soldier.Profesion),
                 new XElement("Age", soldier.age), new XElement("money", soldier.money), new XElement("Gender", soldier.Gender), new XElement("eyescolor", soldier.Eyescolor),
                 new XElement("Isalive", soldier.Isalive), new XElement("Health", soldier.Health))).ToList();

            XElement xElement = new XElement("HouseBolton", houseStark, new XElement("HouseWords", HouseStark.Words),
                new XElement("houseRulers", HouseStark.houseRulers), new XElement("HousesCapitals", HouseStark.housesCapital), new XElement("treasury", HouseStark.Treasury),
                new XElement("northlord", new XElement("name", HouseStark.NorthLord.Name), new XElement("age", HouseStark.NorthLord.Age),
                new XElement("house", HouseStark.NorthLord.LordHouse), new XElement("isalive", HouseStark.NorthLord.Isalive), new XElement("profession", HouseStark.NorthLord.profesion)),
                new XElement("soldiers", sodiers), new XElement("people", people));
            xDocument.Add(xElement);
            xDocument.Save(filename);
        } 
        public static void writeinfo(this HouseReed houseReed, string filename)
        {
            XDocument xDocument = new XDocument();
            var sodiers = HouseReed.Reeds_soldiers.Select(soldier => new XElement("name", soldier.Name, new XElement("profession", soldier.Profesion),
               new XElement("Age", soldier.age), new XElement("money", soldier.money), new XElement("Gender", soldier.Gender), new XElement("eyescolor", soldier.Eyescolor),
               new XElement("Isalive", soldier.Isalive), new XElement("Health", soldier.Health),
               new XElement("fight", new XAttribute("Fightskills", soldier.FightSkills), new XAttribute("Durability", soldier.Durability), new XAttribute("Quickness", soldier.Quickness)))).ToList();

            var people = HouseReed.Reeds_people.Select(soldier => new XElement("name", soldier.Name, new XElement("profession", soldier.Profesion),
                 new XElement("Age", soldier.age), new XElement("money", soldier.money), new XElement("Gender", soldier.Gender), new XElement("eyescolor", soldier.Eyescolor),
                 new XElement("Isalive", soldier.Isalive), new XElement("Health", soldier.Health))).ToList();

            XElement xElement = new XElement("HouseBolton", houseReed, new XElement("HouseWords", HouseReed.Words),
                new XElement("houseRulers", HouseReed.houseRulers), new XElement("HousesCapitals", HouseReed.housesCapital), new XElement("treasury", HouseReed.Treasury),
                new XElement("northlord", new XElement("name", HouseReed.NorthLord.Name), new XElement("age", HouseReed.NorthLord.Age),
                new XElement("house", HouseReed.NorthLord.LordHouse), new XElement("isalive", HouseReed.NorthLord.Isalive), new XElement("profession", HouseReed.NorthLord.profesion)),
                new XElement("soldiers", sodiers), new XElement("people", people));
            xDocument.Add(xElement);
            xDocument.Save(filename);
        } 
        public static void writeinfo(this HouseCerwyn houseCerwyn, string filename)
        {
            XDocument xDocument = new XDocument();
            var sodiers = HouseCerwyn.Cerwyns_soldiers.Select(soldier => new XElement("name", soldier.Name, new XElement("profession", soldier.Profesion),
               new XElement("Age", soldier.age), new XElement("money", soldier.money), new XElement("Gender", soldier.Gender), new XElement("eyescolor", soldier.Eyescolor),
               new XElement("Isalive", soldier.Isalive), new XElement("Health", soldier.Health),
               new XElement("fight", new XAttribute("Fightskills", soldier.FightSkills), new XAttribute("Durability", soldier.Durability), new XAttribute("Quickness", soldier.Quickness)))).ToList();

            var people = HouseCerwyn.Cerwyns_people.Select(soldier => new XElement("name", soldier.Name, new XElement("profession", soldier.Profesion),
                 new XElement("Age", soldier.age), new XElement("money", soldier.money), new XElement("Gender", soldier.Gender), new XElement("eyescolor", soldier.Eyescolor),
                 new XElement("Isalive", soldier.Isalive), new XElement("Health", soldier.Health))).ToList();

            XElement xElement = new XElement("HouseBolton", houseCerwyn, new XElement("HouseWords", HouseCerwyn.Words),
                new XElement("houseRulers", HouseCerwyn.houseRulers), new XElement("HousesCapitals", HouseCerwyn.housesCapital), new XElement("treasury", HouseCerwyn.Treasury),
                new XElement("northlord", new XElement("name", HouseCerwyn.NorthLord.Name), new XElement("age", HouseCerwyn.NorthLord.Age),
                new XElement("house", HouseCerwyn.NorthLord.LordHouse), new XElement("isalive", HouseCerwyn.NorthLord.Isalive), new XElement("profession", HouseCerwyn.NorthLord.profesion)),
                new XElement("soldiers", sodiers), new XElement("people", people));
            xDocument.Add(xElement);
            xDocument.Save(filename);
        } 
        public static void writeinfo(this HouseMormont houseMormont, string filename)
        {
            XDocument xDocument = new XDocument();
            var sodiers = HouseMormont.Mormonts_soldiers.Select(soldier => new XElement("name", soldier.Name, new XElement("profession", soldier.Profesion),
               new XElement("Age", soldier.age), new XElement("money", soldier.money), new XElement("Gender", soldier.Gender), new XElement("eyescolor", soldier.Eyescolor),
               new XElement("Isalive", soldier.Isalive), new XElement("Health", soldier.Health),
               new XElement("fight", new XAttribute("Fightskills", soldier.FightSkills), new XAttribute("Durability", soldier.Durability), new XAttribute("Quickness", soldier.Quickness)))).ToList();

            var people = HouseMormont.Mormonts_people.Select(soldier => new XElement("name", soldier.Name, new XElement("profession", soldier.Profesion),
                 new XElement("Age", soldier.age), new XElement("money", soldier.money), new XElement("Gender", soldier.Gender), new XElement("eyescolor", soldier.Eyescolor),
                 new XElement("Isalive", soldier.Isalive), new XElement("Health", soldier.Health))).ToList();

            XElement xElement = new XElement("HouseBolton", houseMormont, new XElement("HouseWords", HouseMormont.Words),
                new XElement("houseRulers", HouseMormont.houseRulers), new XElement("HousesCapitals", HouseMormont.housesCapital), new XElement("treasury", HouseMormont.Treasury),
                new XElement("northlord", new XElement("name", HouseMormont.NorthLord.Name), new XElement("age", HouseMormont.NorthLord.Age),
                new XElement("house", HouseMormont.NorthLord.LordHouse), new XElement("isalive", HouseMormont.NorthLord.Isalive), new XElement("profession", HouseMormont.NorthLord.profesion)),
                new XElement("soldiers", sodiers), new XElement("people", people));
            xDocument.Add(xElement);
            xDocument.Save(filename);
        } 
        public static void writeinfo(this HouseGlover houseGlover, string filename)
        {
            XDocument xDocument = new XDocument();
            var sodiers = HouseGlover.Glovers_soldiers.Select(soldier => new XElement("name", soldier.Name, new XElement("profession", soldier.Profesion),
               new XElement("Age", soldier.age), new XElement("money", soldier.money), new XElement("Gender", soldier.Gender), new XElement("eyescolor", soldier.Eyescolor),
               new XElement("Isalive", soldier.Isalive), new XElement("Health", soldier.Health),
               new XElement("fight", new XAttribute("Fightskills", soldier.FightSkills), new XAttribute("Durability", soldier.Durability), new XAttribute("Quickness", soldier.Quickness)))).ToList();

            var people = HouseGlover.Glovers_people.Select(soldier => new XElement("name", soldier.Name, new XElement("profession", soldier.Profesion),
                 new XElement("Age", soldier.age), new XElement("money", soldier.money), new XElement("Gender", soldier.Gender), new XElement("eyescolor", soldier.Eyescolor),
                 new XElement("Isalive", soldier.Isalive), new XElement("Health", soldier.Health))).ToList();

            XElement xElement = new XElement("HouseBolton", houseGlover, new XElement("HouseWords", HouseGlover.Words),
                new XElement("houseRulers", HouseGlover.houseRulers), new XElement("HousesCapitals", HouseGlover.housesCapital), new XElement("treasury", HouseGlover.Treasury),
                new XElement("northlord", new XElement("name", HouseGlover.NorthLord.Name), new XElement("age", HouseGlover.NorthLord.Age),
                new XElement("house", HouseGlover.NorthLord.LordHouse), new XElement("isalive", HouseGlover.NorthLord.Isalive), new XElement("profession", HouseGlover.NorthLord.profesion)),
                new XElement("soldiers", sodiers), new XElement("people", people));
            xDocument.Add(xElement);
            xDocument.Save(filename);
        } 
        public static void writeinfo(this HouseHornwood houseHornwood, string filename)
        {
            XDocument xDocument = new XDocument();
            var sodiers = HouseHornwood.Hornwoods_soldiers.Select(soldier => new XElement("name", soldier.Name, new XElement("profession", soldier.Profesion),
               new XElement("Age", soldier.age), new XElement("money", soldier.money), new XElement("Gender", soldier.Gender), new XElement("eyescolor", soldier.Eyescolor),
               new XElement("Isalive", soldier.Isalive), new XElement("Health", soldier.Health),
               new XElement("fight", new XAttribute("Fightskills", soldier.FightSkills), new XAttribute("Durability", soldier.Durability), new XAttribute("Quickness", soldier.Quickness)))).ToList();

            var people = HouseHornwood.Hornwoods_people.Select(soldier => new XElement("name", soldier.Name, new XElement("profession", soldier.Profesion),
                 new XElement("Age", soldier.age), new XElement("money", soldier.money), new XElement("Gender", soldier.Gender), new XElement("eyescolor", soldier.Eyescolor),
                 new XElement("Isalive", soldier.Isalive), new XElement("Health", soldier.Health))).ToList();

            XElement xElement = new XElement("HouseBolton", houseHornwood, new XElement("HouseWords", HouseHornwood.Words),
                new XElement("houseRulers", HouseHornwood.houseRulers),new XElement("HousesCapitals",HouseHornwood.housesCapital) ,new XElement("treasury", HouseHornwood.Treasury),
                new XElement("northlord", new XElement("name", HouseHornwood.NorthLord.Name), new XElement("age", HouseHornwood.NorthLord.Age),
                new XElement("house", HouseHornwood.NorthLord.LordHouse), new XElement("isalive", HouseHornwood.NorthLord.Isalive), new XElement("profession", HouseHornwood.NorthLord.profesion)),
                new XElement("soldiers", sodiers), new XElement("people", people));
            xDocument.Add(xElement);
            xDocument.Save(filename);
        }
        public static void writeinfo(this KINGINTHENORTH kINGINTHENORTH,string filename)
        {
            XDocument xDocument = new XDocument();
            var councilmembers = KINGINTHENORTH.CouncilMembers.Select(a => new XElement("councilmemebertype", a.GetType()));
            XElement xElement = new XElement("kinginthenorth",new XElement("Name",kINGINTHENORTH.Name),
               new XElement("Age",kINGINTHENORTH.Age),new XElement("kinghouse",kINGINTHENORTH.kingshouse),
               new XElement("Isalive",kINGINTHENORTH.Isalive),new XElement("treasury",kINGINTHENORTH.treasury),new XElement("councilmembers",councilmembers));
            xDocument.Add(xElement);
            xDocument.Save(filename);
        }
        public static void writeinfoaboutnorth(string filename)
        {
            var councilmembers = KINGINTHENORTH.CouncilMembers.Select(a => new XElement("councilmemebertype", a.GetType()));
            XElement xElement_king = new XElement("kinginthenorth", new XElement("Name", north.king.Name),
               new XElement("Age", north.king.Age), new XElement("kinghouse", north.king.kingshouse),
               new XElement("Isalive", north.king.Isalive), new XElement("treasury", north.king.treasury), new XElement("councilmembers", councilmembers));

            var north_people = north.northpeople.Select(soldier => new XElement("name", soldier.Name, new XElement("profession", soldier.Profesion),
                 new XElement("Age", soldier.age), new XElement("money", soldier.money), new XElement("Gender", soldier.Gender), new XElement("eyescolor", soldier.Eyescolor),
                 new XElement("Isalive", soldier.Isalive), new XElement("Health", soldier.Health))).ToList();
             
            XDocument xDocument1 = new XDocument();
            XElement xElement1 = new XElement("people", north_people);
            xDocument1.Add(xElement1);
            xDocument1.Save("north_people.xml");
            var north_soldiers = north.northsoldiers.Select(soldier => new XElement("name", soldier.Name, new XElement("profession", soldier.Profesion),
               new XElement("Age", soldier.age), new XElement("money", soldier.money), new XElement("Gender", soldier.Gender), new XElement("eyescolor", soldier.Eyescolor),
               new XElement("Isalive", soldier.Isalive), new XElement("Health", soldier.Health),
               new XElement("fight", new XAttribute("Fightskills", soldier.FightSkills), new XAttribute("Durability", soldier.Durability), new XAttribute("Quickness", soldier.Quickness)))).ToList();

            XDocument xDocument = new XDocument();
            XElement xElement = new XElement("north", nameof(north), new XElement("king", xElement_king),
                new XElement("rulersandcapital", new XAttribute("rulersinnorth", north.Rulers), new XAttribute("northcapital", north.Northcapital)),
            new XElement("northpeople", north_people), new XElement("northsoldiers", north_soldiers),
            new XElement("northhouses", new XAttribute("HouseHornwood", north.HouseHornwood), new XAttribute("HouseGlover", north.HouseGlover),
            new XAttribute("HouseMormont", north.HouseMormont), new XAttribute("HouseStark", north.HouseStark), new XAttribute("HouseBolton", north.HouseBolton),
            new XAttribute("HouseCerwyn", north.HouseCerwyn)));
            xDocument.Add(xElement);
            xDocument.Save(filename); 

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GAMEOFTHRONES
{
    class Stark : HouseStark
    {  
        public string Name { get; set; }
        public int money { get; set; }
        public Profesions? Profesion { get; set; }
        public List<weapons> Weapons { get; set; } = new List<weapons>();
        public int Health { get; set; }
        public bool Isalive { get; set; }
        public Age age { get; set; }
        public int FightSkills { get; set; }
        public int Durability { get; set; }
        public int Quickness { get; set; } 
        public eyescolor Eyescolor { get; set; } 
        public gender Gender { get; set; }
        public northhuman Northhuman_stark { get; set; }
        public Stark (): base(NorthLord)
        { 
            Isalive = true;
            HouseStark.Starks_people.Add(this);  
        } 
        public void Died()
        {
            HouseStark.Starks_people.Remove(this);
            if (this.Profesion == Profesions.CouncilMember)
            {
                KINGINTHENORTH.CouncilMembers.Remove(Northhuman_stark);
            }
            if (this.Profesion == Profesions.soldier)
            {
                HouseStark.Starks_soldiers.Remove(this);
            }
        }
        public void update()
        {
            for (int i = 0; i < north.northpeople.Count; i++)
            {
                if(north.northpeople[i]==Northhuman_stark)
                {
                    north.northpeople.Remove(Northhuman_stark);
                }
            }
            Northhuman_stark = new northhuman()
            {
                age = this.age,
                Name = this.Name,
                Profesion = this.Profesion,
                Eyescolor = this.Eyescolor,
                Weapons = this.Weapons,
                FightSkills = this.FightSkills,
                Durability = this.Durability,
                Quickness = this.Quickness,
                Gender = this.Gender,
                Isalive = this.Isalive,
                money = this.money,
                Health = this.Health,
                Type = this.GetType(),
            };
            north.northpeople.Add(Northhuman_stark);
        }
 
    }
    class Bolton : HouseBolton
    { 
        public string Name { get; set; }
        public int money { get; set; }
        public Profesions? Profesion { get; set; }
        public List<weapons> Weapons { get; set; } = new List<weapons>();
        public int Health { get; set; }
        public bool Isalive { get; set; }
        public Age age { get; set; }
        public int FightSkills { get; set; }
        public int Durability { get; set; }
        public int Quickness { get; set; }
        public eyescolor Eyescolor { get; set; }
        public gender Gender { get; set; }
        public northhuman Northhuman_Bolton { get; set; } 
        public Bolton() : base(NorthLord)
        {
            Isalive = true;
            HouseBolton.Boltons_people.Add(this); 
        }
        public void Died() 
        {
            HouseBolton.Boltons_people.Remove(this);
            if (this.Profesion == Profesions.CouncilMember)
            {
                KINGINTHENORTH.CouncilMembers.Remove(Northhuman_Bolton);
            }
            if (this.Profesion == Profesions.soldier)
            {
                HouseBolton.Boltons_soldiers.Remove(this);
            }
        }
        public void update()
        {
            for (int i = 0; i < north.northpeople.Count; i++)
            {
                if (north.northpeople[i] == Northhuman_Bolton)
                {
                    north.northpeople.Remove(Northhuman_Bolton);
                }
            }
            Northhuman_Bolton = new northhuman()
            {
                age = this.age,
                Name = this.Name,
                Profesion = this.Profesion,
                Eyescolor = this.Eyescolor,
                Weapons = this.Weapons,
                FightSkills = this.FightSkills,
                Durability = this.Durability,
                Quickness = this.Quickness,
                Gender = this.Gender,
                Isalive = this.Isalive,
                money = this.money,
                Health = this.Health,
                Type = this.GetType(),
            };
            north.northpeople.Add(Northhuman_Bolton);
        }

    }
    class Cerwyn: HouseCerwyn
    {
        public string Name { get; set; }
        public int money { get; set; }
        public Profesions? Profesion { get; set; }
        public List<weapons> Weapons { get; set; } = new List<weapons>();
        public int Health { get; set; }
        public bool Isalive { get; set; }
        public Age age { get; set; }
        public int FightSkills { get; set; }
        public int Durability { get; set; }
        public int Quickness { get; set; }
        public eyescolor Eyescolor { get; set; }
        public gender Gender { get; set; }  
        public northhuman Northhuman_Cerwyn { get; set; }
        public Cerwyn() : base(NorthLord)
        {
            Isalive = true;
            HouseCerwyn.Cerwyns_people.Add(this); 
        }
        public void Died()
        {
            HouseCerwyn.Cerwyns_people.Remove(this);
            if (this.Profesion == Profesions.CouncilMember)
            {
                KINGINTHENORTH.CouncilMembers.Remove(Northhuman_Cerwyn);
            }
            if (this.Profesion == Profesions.soldier)
            {
                HouseCerwyn.Cerwyns_soldiers.Remove(this);
            }
        }
        public void update()
        {
            for (int i = 0; i < north.northpeople.Count; i++)
            {
                if (north.northpeople[i] == Northhuman_Cerwyn)
                {
                    north.northpeople.Remove(Northhuman_Cerwyn);
                }
            }
            Northhuman_Cerwyn = new northhuman()
            {
                age = this.age,
                Name = this.Name,
                Profesion = this.Profesion,
                Eyescolor = this.Eyescolor,
                Weapons = this.Weapons,
                FightSkills = this.FightSkills,
                Durability = this.Durability,
                Quickness = this.Quickness,
                Gender = this.Gender,
                Isalive = this.Isalive,
                money = this.money,
                Health = this.Health,
                Type = this.GetType(),
            };
            north.northpeople.Add(Northhuman_Cerwyn);
        }
    }
    class Glover: HouseGlover
    {
        public string Name { get; set; }
        public int money { get; set; }
        public Profesions? Profesion { get; set; }
        public List<weapons> Weapons { get; set; } = new List<weapons>();
        public int Health { get; set; }
        public bool Isalive { get; set; }
        public Age age { get; set; }
        public int FightSkills { get; set; }
        public int Durability { get; set; }
        public int Quickness { get; set; }
        public eyescolor Eyescolor { get; set; }
        public gender Gender { get; set; } 
        public northhuman Northhuman_Glover { get; set; }
        public Glover() : base(NorthLord)
        {
            Isalive = true;
            Glover.Glovers_people.Add(this); 
        }
        public void Died()
        {
            HouseGlover.Glovers_people.Remove(this);
            if (this.Profesion == Profesions.CouncilMember)
            {
                KINGINTHENORTH.CouncilMembers.Remove(Northhuman_Glover);
            }
            if (this.Profesion == Profesions.soldier)
            {
                HouseGlover.Glovers_soldiers.Remove(this);
            }
        }
        public void update()
        {
            for (int i = 0; i < north.northpeople.Count; i++)
            {
                if (north.northpeople[i] == Northhuman_Glover)
                {
                    north.northpeople.Remove(Northhuman_Glover);
                }
            }
            Northhuman_Glover = new northhuman()
            {
                age = this.age,
                Name = this.Name,
                Profesion = this.Profesion,
                Eyescolor = this.Eyescolor,
                Weapons = this.Weapons,
                FightSkills = this.FightSkills,
                Durability = this.Durability,
                Quickness = this.Quickness,
                Gender = this.Gender,
                Isalive = this.Isalive,
                money = this.money,
                Health = this.Health,
                Type = this.GetType(),
            };
            north.northpeople.Add(Northhuman_Glover);
        }
    }
    class Mormont: HouseMormont
    {
        public string Name { get; set; }
        public int money { get; set; }
        public Profesions? Profesion { get; set; }
        public List<weapons> Weapons { get; set; } = new List<weapons>();
        public int Health { get; set; }
        public bool Isalive { get; set; }
        public Age age { get; set; }
        public int FightSkills { get; set; }
        public int Durability { get; set; }
        public int Quickness { get; set; }
        public eyescolor Eyescolor { get; set; }
        public gender Gender { get; set; }
        public northhuman Northhuman_Mormont { get; set; } 
        public Mormont() : base(NorthLord)
        {
            Isalive = true;
            Mormont.Mormonts_people.Add(this); 
        }
        public void Died() 
        {
            HouseMormont.Mormonts_people.Remove(this);
            if (this.Profesion == Profesions.CouncilMember)
            {
                KINGINTHENORTH.CouncilMembers.Remove(Northhuman_Mormont);
            }
            if (this.Profesion == Profesions.soldier)
            {
                HouseMormont.Mormonts_soldiers.Remove(this);
            }
        }
        public void update()
        {
            for (int i = 0; i < north.northpeople.Count; i++)
            {
                if (north.northpeople[i] == Northhuman_Mormont)
                {
                    north.northpeople.Remove(Northhuman_Mormont);
                }
            }
            Northhuman_Mormont = new northhuman()
            {
                age = this.age,
                Name = this.Name,
                Profesion = this.Profesion,
                Eyescolor = this.Eyescolor,
                Weapons = this.Weapons,
                FightSkills = this.FightSkills,
                Durability = this.Durability,
                Quickness = this.Quickness,
                Gender = this.Gender,
                Isalive = this.Isalive,
                money = this.money,
                Health = this.Health,
                Type = this.GetType(),
            };
            north.northpeople.Add(Northhuman_Mormont);
        }
    }
    class Reed: HouseReed
    {
        public string Name { get; set; }
        public int money { get; set; }
        public Profesions? Profesion { get; set; }
        public List<weapons> Weapons { get; set; } = new List<weapons>();
        public int Health { get; set; }
        public bool Isalive { get; set; }
        public Age age { get; set; }
        public int FightSkills { get; set; }
        public int Durability { get; set; }
        public int Quickness { get; set; }
        public eyescolor Eyescolor { get; set; }
        public gender Gender { get; set; }
        public northhuman Northhuman_Reed { get; set; }
        public Reed() : base(NorthLord)
        {
            Isalive = true; 
            Reed.Reeds_people.Add(this); 
        }
        public void Died()
        {
            HouseReed.Reeds_people.Remove(this);
            if (this.Profesion == Profesions.CouncilMember)
            {
                KINGINTHENORTH.CouncilMembers.Remove(Northhuman_Reed);
            }
            if (this.Profesion == Profesions.soldier)
            {
                HouseReed.Reeds_soldiers.Remove(this);
            }
        }
        public void update()
        {
            for (int i = 0; i < north.northpeople.Count; i++)
            {
                if (north.northpeople[i] == Northhuman_Reed)
                {
                    north.northpeople.Remove(Northhuman_Reed);
                }
            }
            Northhuman_Reed = new northhuman()
            {
                age = this.age,
                Name = this.Name,
                Profesion = this.Profesion,
                Eyescolor = this.Eyescolor,
                Weapons = this.Weapons,
                FightSkills = this.FightSkills,
                Durability = this.Durability,
                Quickness = this.Quickness,
                Gender = this.Gender,
                Isalive = this.Isalive,
                money = this.money,
                Health = this.Health,
                Type = this.GetType(),
            };
            north.northpeople.Add(Northhuman_Reed);
        }
    }
    class Hornwood : HouseHornwood
    {
        public string Name { get; set; }
        public int money { get; set; }
        public Profesions? Profesion { get; set; }
        public List<weapons> Weapons { get; set; } = new List<weapons>();
        public int Health { get; set; }
        public bool Isalive { get; set; }
        public Age age { get; set; }
        public int FightSkills { get; set; }
        public int Durability { get; set; }
        public int Quickness { get; set; }
        public eyescolor Eyescolor { get; set; }
        public gender Gender { get; set; }
        public northhuman Northhuman_Hornwood { get; set; } 
        public Hornwood() : base(NorthLord)
        {
            Isalive = true;
            Hornwood.Hornwoods_people.Add(this); 
        }
        public void Died()
        {
            HouseHornwood.Hornwoods_people.Remove(this);
            if (this.Profesion == Profesions.CouncilMember)
            {
                KINGINTHENORTH.CouncilMembers.Remove(Northhuman_Hornwood);
            }
            if (this.Profesion == Profesions.soldier)
            {
                HouseHornwood.Hornwoods_soldiers.Remove(this);
            }
        }
        public void update()
        {
            for (int i = 0; i < north.northpeople.Count; i++)
            {
                if (north.northpeople[i] == Northhuman_Hornwood)
                {
                    north.northpeople.Remove(Northhuman_Hornwood);
                }
            }
            Northhuman_Hornwood = new northhuman()
            {
                age = this.age,
                Name = this.Name,
                Profesion = this.Profesion,
                Eyescolor = this.Eyescolor,
                Weapons = this.Weapons,
                FightSkills = this.FightSkills,
                Durability = this.Durability,
                Quickness = this.Quickness,
                Gender = this.Gender,
                Isalive = this.Isalive,
                money = this.money,
                Health = this.Health,
                Type = this.GetType(),
            };
            north.northpeople.Add(Northhuman_Hornwood);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GAMEOFTHRONES
{
    class northhuman
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
        public Type Type { get; set; }
        public void Died()
        {
            north.northpeople.Remove(this);
            if (this.Profesion == Profesions.CouncilMember)
            {
                KINGINTHENORTH.CouncilMembers.Remove(this);
            }
            if (this.Profesion == Profesions.soldier)
            {
                north.northsoldiers.Remove(this);
            }
        }

    }
}

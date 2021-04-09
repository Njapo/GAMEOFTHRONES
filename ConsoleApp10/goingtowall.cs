using System;
using System.Collections.Generic;
using System.Text;

namespace GAMEOFTHRONES
{       
    static class goingtowall
    {   
        public static void Goingtowall(this Stark stark)
        {
            if(stark.Gender==gender.female)
            {
                throw new Exception("woman can't be knightwatch");
            }
            stark.Profesion = null;
            north.king.treasury += stark.money;
            stark.money = 0;
            stark.Weapons.Clear();
            if(stark.Profesion==Profesions.CouncilMember)
            {
                KINGINTHENORTH.CouncilMembers.Remove(stark.Northhuman_stark);
            }
            HouseStark.Starks_people.Remove(stark);
            if(stark.Profesion==Profesions.soldier)
            {
                HouseStark.Starks_soldiers.Remove(stark);
            }
            CastlesontheWall.Knightswatchpeople.Add(stark.Northhuman_stark);
            
        }
        public static void Goingtowall(this Bolton bolton)
        {
            if (bolton.Gender == gender.female)
            {
                throw new Exception("woman can't be knightwatch");
            }
            bolton.Profesion = null;
            north.king.treasury += bolton.money;
            bolton.money = 0;
            bolton.Weapons.Clear();
            if (bolton.Profesion == Profesions.CouncilMember)
            {
                KINGINTHENORTH.CouncilMembers.Remove(bolton.Northhuman_Bolton);
            }
            HouseBolton.Boltons_people.Remove(bolton);
            if (bolton.Profesion == Profesions.soldier)
            {
                HouseBolton.Boltons_soldiers.Remove(bolton);
            }
            CastlesontheWall.Knightswatchpeople.Add(bolton.Northhuman_Bolton);
        }
        public static void Goingtowall(this Cerwyn cerwyn) 
        {
            if (cerwyn.Gender == gender.female)
            {
                throw new Exception("woman can't be knightwatch");
            }
            cerwyn.Profesion = null;
            north.king.treasury += cerwyn.money;
            cerwyn.money = 0;
            cerwyn.Weapons.Clear();
            if (cerwyn.Profesion == Profesions.CouncilMember)
            {
                KINGINTHENORTH.CouncilMembers.Remove(cerwyn.Northhuman_Cerwyn);
            }
            HouseCerwyn.Cerwyns_people.Remove(cerwyn);
            if (cerwyn.Profesion == Profesions.soldier)
            {
                HouseCerwyn.Cerwyns_soldiers.Remove(cerwyn);
            }
            CastlesontheWall.Knightswatchpeople.Add(cerwyn.Northhuman_Cerwyn);
        }
        public static void Goingtowall(this Glover glover) 
        {
            if (glover.Gender == gender.female)
            {
                throw new Exception("woman can't be knightwatch");
            }
            glover.Profesion = null;
            north.king.treasury += glover.money;
            glover.money = 0;
            glover.Weapons.Clear();
            if (glover.Profesion == Profesions.CouncilMember)
            {
                KINGINTHENORTH.CouncilMembers.Remove(glover.Northhuman_Glover);
            }
            HouseGlover.Glovers_people.Remove(glover);
            if (glover.Profesion == Profesions.soldier)
            {
                HouseGlover.Glovers_soldiers.Remove(glover);
            }
            CastlesontheWall.Knightswatchpeople.Add(glover.Northhuman_Glover);
        }
        public static void Goingtowall(this Mormont mormont) 
        {
            if (mormont.Gender == gender.female)
            {
                throw new Exception("woman can't be knightwatch");
            }
            mormont.Profesion = null;
            north.king.treasury += mormont.money;
            mormont.money = 0;
            mormont.Weapons.Clear();
            if (mormont.Profesion == Profesions.CouncilMember)
            {
                KINGINTHENORTH.CouncilMembers.Remove(mormont.Northhuman_Mormont);
            }
            HouseMormont.Mormonts_people.Remove(mormont);
            if (mormont.Profesion == Profesions.soldier)
            {
                HouseMormont.Mormonts_soldiers.Remove(mormont);
            }
            CastlesontheWall.Knightswatchpeople.Add(mormont.Northhuman_Mormont);
        }
        public static void Goingtowall(this Reed reed) 
        {
            if (reed.Gender == gender.female)
            {
                throw new Exception("woman can't be knightwatch");
            }
            reed.Profesion = null;
            north.king.treasury += reed.money;
            reed.money = 0;
            reed.Weapons.Clear();
            if (reed.Profesion == Profesions.CouncilMember)
            {
                KINGINTHENORTH.CouncilMembers.Remove(reed.Northhuman_Reed);
            }
            HouseReed.Reeds_people.Remove(reed);
            if (reed.Profesion == Profesions.soldier)
            {
                HouseReed.Reeds_soldiers.Remove(reed);
            }
            CastlesontheWall.Knightswatchpeople.Add(reed.Northhuman_Reed);
        }
        public static void Goingtowall(this Hornwood hornwood) 
        {
            if (hornwood.Gender == gender.female)
            {
                throw new Exception("woman can't be knightwatch");
            }
            hornwood.Profesion = null;
            north.king.treasury += hornwood.money;
            hornwood.money = 0;
            hornwood.Weapons.Clear();
            if (hornwood.Profesion == Profesions.CouncilMember)
            {
                KINGINTHENORTH.CouncilMembers.Remove(hornwood.Northhuman_Hornwood);
            }
            Hornwood.Hornwoods_people.Remove(hornwood);
            if (hornwood.Profesion == Profesions.soldier)
            {
                Hornwood.Hornwoods_soldiers.Remove(hornwood);
            }
            CastlesontheWall.Knightswatchpeople.Add(hornwood.Northhuman_Hornwood);
        }
    }   
}       
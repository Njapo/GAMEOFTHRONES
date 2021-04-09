using System;
using System.Collections.Generic;
using System.Text;

namespace GAMEOFTHRONES
{
    static  class Council
    {
        public static void BecomeCouncilMember(this Stark stark)
        {
            if (stark.Profesion != Profesions.CouncilMember) throw new Exception("is'not concil member");
            else  KINGINTHENORTH.CouncilMembers.Add(stark.Northhuman_stark);
        }
        public static void BecomeCouncilMember(this Reed reed)
        {
            if (reed.Profesion != Profesions.CouncilMember) throw new Exception("is'not concil member");
            else 
                KINGINTHENORTH.CouncilMembers.Add(reed.Northhuman_Reed);
        }
        public static void BecomeCouncilMember(this Mormont mormont)
        {
            if (mormont.Profesion != Profesions.CouncilMember) throw new Exception("is'not concil member");
            else KINGINTHENORTH.CouncilMembers.Add(mormont.Northhuman_Mormont);
        }
        public static void BecomeCouncilMember(this Glover glover)
        {
            if (glover.Profesion != Profesions.CouncilMember) throw new Exception("is'not concil member");
            else KINGINTHENORTH.CouncilMembers.Add(glover.Northhuman_Glover);
        }
        public static void BecomeCouncilMember(this Cerwyn cerwyn)
        {
            if (cerwyn.Profesion != Profesions.CouncilMember) throw new Exception("is'not concil member");
            else KINGINTHENORTH.CouncilMembers.Add(cerwyn.Northhuman_Cerwyn);
        }
        public static void BecomeCouncilMember(this Hornwood hornwood)
        {
            if (hornwood.Profesion != Profesions.CouncilMember) throw new Exception("is'not concil member");
            else KINGINTHENORTH.CouncilMembers.Add(hornwood.Northhuman_Hornwood);
        }
        public static void BecomeCouncilMember(this Bolton bolton)
        {
            if (bolton.Profesion != Profesions.CouncilMember) throw new Exception("is'not concil member");
            else KINGINTHENORTH.CouncilMembers.Add(bolton.Northhuman_Bolton);
        }
    }

}

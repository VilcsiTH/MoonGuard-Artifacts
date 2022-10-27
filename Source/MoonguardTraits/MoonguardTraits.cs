using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using RimWorld;

namespace MoonguardTraits
{
    public class CompMoonguardWeapon : CompBiocodable
    {
        public List<WeaponTraitDef> TraitsListForReading
        {
            get
            {
                return this.traits;
            }
        }
        private List<WeaponTraitDef> traits = new List<WeaponTraitDef>();
    }
    public class CompProperties_MoonguardWeapon : CompProperties_Biocodable
    {
        public CompProperties_MoonguardWeapon()
        {
            this.compClass = typeof(CompBladelinkWeapon);
        }
    }

}

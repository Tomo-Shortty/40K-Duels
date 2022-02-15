using _40KDuels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40KDuels.Wargear
{
    internal interface IMeleeWeapon
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int ArmourPenetration { get; set; }
        public int Damage { get; set; }
        public DamageType DamageType { get; set; }
        public List<SpecialWeaponProperty> SpecialProperties { get; set; }
    }
}

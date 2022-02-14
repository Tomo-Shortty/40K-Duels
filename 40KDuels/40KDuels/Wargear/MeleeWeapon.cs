using _40KDuels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40KDuels.Wargear
{
    internal class MeleeWeapon : IWeapon
    {
        public MeleeWeapon(string name, int strength, int armourPenetration, int damage)
        {
            Name = name;
            Range = 0;
            Type = WeaponType.Melee;
            Strength = strength;
            ArmourPenetration = armourPenetration;
            Damage = damage;
        }

        public string Name { get; set; }
        public int Range { get; set; }
        public WeaponType Type { get; set; }
        public int Strength { get; set; }
        public int ArmourPenetration { get; set; }
        public int Damage { get; set; }
    }
}

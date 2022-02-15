using _40KDuels.Enums;
using _40KDuels.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40KDuels.Wargear
{
    internal interface IRangedWeapon
    {
        public string Name { get; set; }
        public int Range { get; set; }
        public WeaponType Type { get; set; }
        public int Attacks { get; set; }
        public int Strength { get; set; }
        public int ArmourPenetration { get; set; }
        public int Damage { get; set; }
        public DamageType DamageType { get; set; }
        public List<SpecialWeaponProperty> SpecialProperties { get; set; }

        public void Attack(IModel shooter, IUnit target);
        public void DealDamage(IModel target);
    }
}

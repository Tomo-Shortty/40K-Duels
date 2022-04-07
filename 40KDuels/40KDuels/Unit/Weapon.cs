using _40KDuels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40KDuels.Unit
{
    internal class Weapon
    {
        private string _name;
        private int _range;
        private WeaponType _type;
        private int _attacks;
        private int _strength;
        private int _armourPenetration;
        private int _damage;
        private DamageType _damageType;
        private List<SpecialWeaponProperty> _specialProperties;

        public Weapon(string name, int range, WeaponType type, int attacks, int strength, int armourPenetration, int damage, DamageType damageType)
        {
            _name = name;
            _range = range;
            _type = type;
            _attacks = attacks;
            _strength = strength;
            _armourPenetration = armourPenetration;
            _damage = damage;
            _damageType = damageType;
            _specialProperties = new List<SpecialWeaponProperty>();
        }

        public string Name => _name;
        public int Range => _range;
        public WeaponType Type => _type;
        public int Attacks => _attacks;
        public int Strength => _strength;
        public int ArmourPenetration => _armourPenetration;
        public int Damage => _damage;
        public DamageType DamageType => _damageType;
        public List<SpecialWeaponProperty> SpecialProperties => _specialProperties;

        public void AddSpecialProperties(SpecialWeaponProperty[] properties)
        {
            for (int i = 0; i < properties.Length; i++)
            {
                _specialProperties.Add(properties[i]);
            }
        }
    }
}

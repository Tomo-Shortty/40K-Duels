using _40KDuels.Enums;
using _40KDuels.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40KDuels.Wargear.Ranged_Weapons
{
    //Most likely not needed
    internal class Boltgun
    {
        public Boltgun()
        {
            Name = "Boltgun";
            Range = 24;
            Type = WeaponType.RapidFire;
            Attacks = 1;
            Strength = 4;
            ArmourPenetration = 0;
            Damage = 1;
            DamageType = DamageType.Normal;
            SpecialProperties = new List<SpecialWeaponProperty>(new SpecialWeaponProperty[] { SpecialWeaponProperty.Bolt });
        }

        public string Name { get; set; }
        public int Range { get; set; }
        public WeaponType Type { get; set; }
        public int Attacks { get; set; }
        public int Strength { get; set; }
        public int ArmourPenetration { get; set; }
        public int Damage { get; set; }
        public DamageType DamageType { get; set; }
        public List<SpecialWeaponProperty> SpecialProperties { get; set; }

        public bool MakeHitRoll(Model model, Model target)
        {
            int diceRoll = new Random().Next(1, 7);

            if (diceRoll == 6)
            {
                return true;
            }
            else if (diceRoll == 1)
            {
                return false;
            }
            else
            {
                int result = diceRoll - target.HitDefenceModifier;
                if (result >= model.BallisticSkill)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool MakeSavingThrow(Model target)
        {
            throw new NotImplementedException();
        }

        public bool MakeWoundRoll(Model model, Model target)
        {
            int diceRoll = new Random().Next(1, 7);

            if (diceRoll == 6)
            {
                return true;
            }
            else if (diceRoll == 1)
            {
                return false;
            }
            else
            {
                int result = diceRoll - target.WoundDefenceModifier;
                int requiredWoundResult = DetermineWoundRequirement(target.Toughness);

                if (result >= requiredWoundResult)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void UseWeapon()
        {
            throw new NotImplementedException();
        }

        public int DetermineWoundRequirement(int toughness)
        {
            if (Strength >= (toughness * 2)) {
                return 2;
            }
            else if (Strength > toughness && Strength < (toughness * 2)) {
                return 3;
            }
            else if (Strength < toughness && Strength > (toughness / 2))
            {
                return 5;
            }
            else if (Strength <= (toughness / 2))
            {
                return 6;
            }
            else
            {
                return 4;
            }
        }
    }
}

using _40KDuels.Psychic_Powers;
using _40KDuels.Wargear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40KDuels.Units
{
    internal interface IModel
    {
        public string Name {get; set;}
        public int Movement { get; set; }
        public int WeaponSkill { get; set; }
        public int BallisticSkill { get; set; }
        public int Strength { get; set; }
        public int Toughness { get; set; }
        public int Wounds { get; set; }
        public int Attacks { get; set; }
        public int Leadership { get; set; }
        public int Save { get; set; }
        public List<IRangedWeapon> RangedWeapons { get; set; }
        public List<IMeleeWeapon> MeleeWeapons { get; set;}
        public bool Slain { get; set; }
        public bool Fled { get; set; }

        public IRangedWeapon SelectRangedWeapon(IRangedWeapon weapon);
        public IMeleeWeapon SelectMeleeWeapon(IMeleeWeapon weapon);
        public void CastPsychicPower(IPsychicPower psychicPower, IUnit target);
        public void FireRangedWeapon(IRangedWeapon weapon, IUnit target);
        public void UseMeleeWeapon(IMeleeWeapon weapon, IUnit target);
    }
}

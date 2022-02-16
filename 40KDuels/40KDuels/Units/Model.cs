using _40KDuels.Psychic_Powers;
using _40KDuels.Wargear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40KDuels.Units
{
    internal class Model
    {
        private string _name;
        private int _movement;
        private int _weaponSkill;
        private int _ballisticSkill;
        private int _strength;
        private int _toughness;
        private int _wounds;
        private int _attacks;
        private int _leadership;
        private int _save;
        private int _invulnerableSave;
        private List<Weapon> _rangedWeapons;
        private List<Weapon> _meleeWeapons;
        private bool _inCover;
        private int _toHitModifier;
        private int _hitDefenceModifier;
        private int _toWoundModifier;
        private int _woundDefenceModifier;
        private int _movementModifier;
        private int _weaponSkillModifier;
        private int _ballisticSkillModifier;
        private int _strengthModifier;
        private int _toughnessModifier;
        private int _maximumWounds;
        private int _attacksModifier;
        private int _leadershipModifier;
        private bool _slain;
        private bool _fled;

        public Model(string name, int movement, int weaponSkill, int ballisticSkill, int strength, int toughness, int wounds, int attacks, int leadership, int save)
        {
            _name = name;
            _movement = movement;
            _weaponSkill = weaponSkill;
            _ballisticSkill = ballisticSkill;
            _strength = strength;
            _toughness = toughness;
            _wounds = wounds;
            _attacks = attacks;
            _leadership = leadership;
            _save = save;
            _invulnerableSave = 7;
            _rangedWeapons = new List<Weapon>();
            _meleeWeapons = new List<Weapon>();
            _inCover = false;
            _toHitModifier = 0;
            _hitDefenceModifier = 0;
            _toWoundModifier = 0;
            _woundDefenceModifier = 0;
            _movementModifier = 0;
            _weaponSkillModifier = 0;
            _ballisticSkillModifier = 0;
            _strengthModifier = 0;
            _toughnessModifier = 0;
            _maximumWounds = _wounds;
            _attacksModifier = 0;
            _leadershipModifier = 0;
            _slain = false;
            _fled = false;
        }

        public string Name => _name;
        public int Movement => _movement;
        public int WeaponSkill => _weaponSkill;
        public int BallisticSkill => _ballisticSkill;
        public int Strength => _strength;
        public int Toughness => _toughness;
        public int Wounds => _wounds;
        public int Attacks => _attacks;
        public int Leadership => _leadership;
        public int Save => _save;
        public int InvulnerableSave => _invulnerableSave;
        public List<Weapon> RangedWeapons => _rangedWeapons;
        public List<Weapon> MeleeWeapons => _meleeWeapons;
        public bool InCover => _inCover;
        public int ToHitModifier => _toHitModifier;
        public int HitDefenceModifier => _hitDefenceModifier;
        public int ToWoundModifier => _toWoundModifier;
        public int WoundDefenceModifier => _woundDefenceModifier;
        public int MovementModifier => _movementModifier;
        public int WeaponSkillModifier => _weaponSkillModifier;
        public int BallisticSkillModifier => _ballisticSkillModifier;
        public int StrengthModifier => _strengthModifier;
        public int ToughnessModifier => _toughnessModifier;
        public int MaximumWounds => _maximumWounds;
        public int AttacksModifier => _attacksModifier;
        public int LeadershipModifier => _leadershipModifier;
        public bool Slain => _slain;
        public bool Fled => _fled;

        public Weapon SelectWeapon(Weapon weapon)
        {
            if (weapon.SpecialProperties.Contains(Enums.SpecialWeaponProperty.Unwieldy))
            {
                _toHitModifier += -1;
            }

            return weapon;
        }

        public void ResetModifiers()
        {
            _toHitModifier = 0;
            _hitDefenceModifier = 0;
            _toWoundModifier = 0;
            _woundDefenceModifier = 0;
            _movementModifier = 0;
            _weaponSkillModifier = 0;
            _ballisticSkillModifier = 0;
            _strengthModifier = 0;
            _toughnessModifier = 0;
            _maximumWounds = _wounds;
            _attacksModifier = 0;
            _leadershipModifier = 0;
        }

        /*public void CastPsychicPower(IPsychicPower psychicPower, IUnit target)
        {

        }
        
        public void FireRangedWeapon(IWeapon weapon, IUnit target)
        {

        }

        public void UseMeleeWeapon(IWeapon weapon, IUnit target)
        {

        }*/
    }
}

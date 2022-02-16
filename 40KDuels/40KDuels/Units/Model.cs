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
        private List<IWeapon> _rangedWeapons;
        private List<IWeapon> _meleeWeapons;
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
            _rangedWeapons = new List<IWeapon>();
            _meleeWeapons = new List<IWeapon>();
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
        public List<IWeapon> RangedWeapons => _rangedWeapons;
        public List<IWeapon> MeleeWeapons => _meleeWeapons;
        public bool Slain => _slain;
        public bool Fled => _fled;

        public IWeapon SelectWeapon(IWeapon weapon)
        {
            return weapon;
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

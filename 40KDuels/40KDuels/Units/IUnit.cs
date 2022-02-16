using _40KDuels.Auras;
using _40KDuels.Enums;
using _40KDuels.Wargear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40KDuels.Units
{
    internal interface IUnit
    {
        public string Name { get; set; }
        public int PowerRating { get; set; }
        public List<Model> Models { get; set; }
        public int NumberOfModels { get; set; }
        public int MinimumNumberOfModels { get; set; }
        public int MaximumNumberOfModels { get; set; }
        public List<Weapon> WargearOptions { get; set; }
        public List<FactionKeyword> FactionKeywords { get; set; }
        public List<Keyword> Keywords { get; set; }
        public List<IAura> Auras { get; set; }
        public bool InEngagementRange { get; set; }
        public bool HasDeploymentAbility { get; set; }
        public bool MovementCannotBeModified { get; set; }
        public bool WeaponSkillCannotBeModified { get; set; }
        public bool BallisticSkillCannotBeModified { get; set; }
        public bool StrengthCannotBeModified { get; set; }
        public bool ToughnessCannotBeModified { get; set; }
        public bool AttacksCannotBeModified { get; set; }
        public bool LeadershipCannotBeModified { get; set; }
        public bool MovedThisTurn { get; set; }
        public bool AdvancedThisTurn { get; set; }
        public bool ChargedThisTurn { get; set; }
        public int CasualtiesThisTurn { get; set; }

        public void LoadModels();
        public void AddModel(Model model);
        public void ReplaceModelWargear(Model model);
        //public void ReceiveDamage(int damage, DamageType damageType);

        /*public void Command();
        public int Move();
        public bool CastPsyhcicPower();
        public bool DenyTheWitch();
        public void Shoot(IUnit target);
        public int Charge(IUnit target);
        public void Fight(IUnit target);
        public void MakeMoraleTest();*/
    }
}

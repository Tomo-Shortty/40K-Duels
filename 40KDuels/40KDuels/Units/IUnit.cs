using _40KDuels.Auras;
using _40KDuels.Enums;
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
        public FactionKeyword FactionKeywords { get; set; }
        public Keyword Keywords { get; set; }
        public List<IAura> Auras { get; set; }
        public bool HasDeploymentAbility { get; set; }
        public bool InCover { get; set; }
        public int ToHitModifier { get; set; }
        public int HitDefenceModifier { get; set; }
        public int ToWoundModifier { get; set; }
        public int WoundDefenceModifier { get; set; }
        public int CasualtiesThisTurn { get; set; }
        public bool CompletedCommandPhase { get; set; }
        public bool CompletedMovementPhase { get; set; }
        public bool CompletedPsychicPhase { get; set; }
        public bool CompletedShootingPhase { get; set; }
        public bool CompletedChargePhase { get; set; }
        public bool CompletedFightPhase { get; set; }
        public bool CompletedMoralePhase { get; set; }

        public void LoadModels(Model[] models);
        public void ReplaceModelWargear();       
        public void ReceiveDamage(int damage, DamageType damageType);

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

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
        public List<IModel> Models { get; set; }
        public int NumberOfModels { get; set; }
        public int MinimumNumberOfModels { get; set; }
        public int MaximumNumberOfModels { get; set; }
        public FactionKeyword FactionKeywords { get; set; }
        public Keyword Keywords { get; set; }
        public int CasualtiesThisTurn { get; set; }
        public bool CompletedCommandPhase { get; set; }
        public bool CompletedMovementPhase { get; set; }
        public bool CompletedPsychicPhase { get; set; }
        public bool CompletedShootingPhase { get; set; }
        public bool CompletedChargePhase { get; set; }
        public bool CompletedFightPhase { get; set; }
        public bool CompletedMoralePhase { get; set; }

        public void DetermineWargearOptions();
        public void Command();
        public void Move();
        public void PerformPsychicPowers();
        public void Shoot();
        public void Charge(IUnit target);
        public void Fight();
        public void MakeMoraleTest();
    }
}

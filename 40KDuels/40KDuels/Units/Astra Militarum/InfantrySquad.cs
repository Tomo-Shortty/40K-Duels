﻿using _40KDuels.Auras;
using _40KDuels.Enums;
using _40KDuels.Wargear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40KDuels.Units.Astra_Militarum
{
    internal class InfantrySquad : IUnit
    {
        public InfantrySquad()
        {
            Name = "Infantry Squad";
            PowerRating = 3;
            Models = new List<Model>();
            LoadModels();
            NumberOfModels = Models.Count;
            MinimumNumberOfModels = 10;
            MaximumNumberOfModels = 10;
            WargearOptions = new List<Weapon>();
            FactionKeywords = new List<FactionKeyword>(new FactionKeyword[] {FactionKeyword.Imperium, FactionKeyword.AstraMilitarum});
            Keywords = new List<Keyword>(new Keyword[] {Keyword.Infantry});
            Auras = new List<IAura>();
            InEngagementRange = false;
            HasDeploymentAbility = false;
            MovementCannotBeModified = false;
            WeaponSkillCannotBeModified = false;
            BallisticSkillCannotBeModified = false;
            StrengthCannotBeModified = false;
            ToughnessCannotBeModified = false;
            AttacksCannotBeModified = false;
            LeadershipCannotBeModified = false;
            MovedThisTurn = false;
            AdvancedThisTurn = false;
            ChargedThisTurn = false;
            CasualtiesThisTurn = 0;
        }

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

        public void AddModel(Model model)
        {
            Models.Add(model);
        }

        public void LoadModels()
        {
            throw new NotImplementedException();
        }

        public void ReplaceModelWargear(Model model)
        {
            throw new NotImplementedException();
        }
    }
}

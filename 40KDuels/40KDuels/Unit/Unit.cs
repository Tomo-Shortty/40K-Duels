using _40KDuels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40KDuels.Unit
{
    internal class Unit
    {
        private string _name;
        private int _modelQuantity;
        private int _powerRating;
        private List<Model> _models;
        private List<FactionKeyword> _factionKeywords;
        private List<Keyword> _keywords;

        public Unit(string name, int modelQuantity, int powerRating)
        {
            _name = name;
            _modelQuantity = modelQuantity;
            _powerRating = powerRating;
            _models = new List<Model>();
            _factionKeywords = new List<FactionKeyword>();
            _keywords = new List<Keyword>();
        }

        public string Name => _name;
        public int ModelQuantity => _modelQuantity;
        public int PowerRating => _powerRating;
        public List<Model> Models => _models;
        public List<FactionKeyword> FactionKeywords => _factionKeywords;
        public List<Keyword> Keywords => _keywords;

        public void AddModels(Model[] models)
        {
            for (int i = 0; i < models.Length; i++)
            {
                _models.Add(models[i]);
            }
        }
    }
}

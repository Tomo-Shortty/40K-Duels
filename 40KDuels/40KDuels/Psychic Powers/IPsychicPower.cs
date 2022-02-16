using _40KDuels.Enums;
using _40KDuels.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40KDuels.Psychic_Powers
{
    internal interface IPsychicPower
    {
        public int Name { get; set; }
        public PsychicPowerType Type { get; set; }
        public int Range { get; set; }
        public int WarpCharge { get; set; }

        public void MakePsychicTest(Model model);
        public void UsePower();
        public void MakeAdditionalRolls(IUnit target);
        public void ApplyPower(IUnit target);
    }
}

using _40KDuels.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40KDuels.Auras
{
    internal interface IAura
    {
        public string Name { get; set; }
        public int Size { get; set; }

        public void AuraEffect(IUnit unit);
    }
}

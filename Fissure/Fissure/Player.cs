using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fissure.Zone;

namespace Fissure
{
    public class Player
    {
        public int LifeTotal { get; set; }
        public Hand Hand { get; set; }
        public Field Field { get; set; }
        public Fissure.Zone.Void Void { get; set; }
    }
}

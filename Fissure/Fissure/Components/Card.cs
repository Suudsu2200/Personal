using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fissure.Components
{
    public class Card
    {
        public Supertype Supertype;
        public Subtype[] Suptypes;
        public string FlavorText;
        public int Cost;
        public Ability[] Abilities;
    }
}

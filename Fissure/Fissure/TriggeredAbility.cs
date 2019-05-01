using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Scripting.Hosting;

namespace Fissure
{
    public class TriggeredAbility
    {
        private IGameScript<bool> _triggerCondition;
        private IGameScript<IEnumerable<Effect>> _triggerEffects;
    }
}

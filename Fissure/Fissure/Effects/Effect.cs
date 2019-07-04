using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fissure.Effects
{
    public class Effect
    {
        private IGameScript<object> _playerInteractionScript;
        private IGameScript<IEnumerable<GameAction>> _resolutionScript;
    }
}


using Fissure.Components;
using Newtonsoft.Json;

namespace Fissure
{
    public class ScriptInterpreter
    {
        public Card InterpretCard(string script)
        {
            CardData data = JsonConvert.DeserializeObject<CardData>(script);
            return null;

        }

        public class CardData
        {

        }
    }
}

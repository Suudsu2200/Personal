using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fissure.Components;
using Fissure.Components.Permanents;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Fissure
{
    public class JsonCardReader
    {
        private string _basePath;
        public JsonCardReader(string basePath)
        {
            _basePath = basePath;
        }
        public Card Read(string cardName)
        {
            string fileContents = File.ReadAllText($"{_basePath}/{cardName}.json");
            JObject raw = JObject.Parse(fileContents);

            Summon mySummon;
            switch (raw["Supertype"].ToString())
            {
                case "Summon":
                    mySummon = JsonConvert.DeserializeObject<Summon>(fileContents);
                    break;
                default:
                    throw new Exception();
            }

            return mySummon;
        }

    }

}

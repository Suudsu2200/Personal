using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fissure.Components;

namespace Fissure
{
    public interface ICardDataStore
    {
        void LoadAll();
        Card GetById(int cardId);
    }
}

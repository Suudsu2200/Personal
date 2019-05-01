using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fissure.Components;

namespace Fissure
{
    public class InMemoryCardDataStore : ICardDataStore
    {
        private Dictionary<int, Card> cardsById;

        public InMemoryCardDataStore()
        {
            cardsById = new Dictionary<int, Card>();
        }

        public void LoadAll()
        {

        }

        public Card GetById(int cardId)
        {
            return cardsById[cardId];
        }
    }
}

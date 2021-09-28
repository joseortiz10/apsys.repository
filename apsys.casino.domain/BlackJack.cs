using apsys.casino.domain.Shared;
using System;
using System.Collections.Generic;

namespace apsys.casino.domain
{
    public class BlackJack
    {
        public IEnumerable<Card> BuildDeck()
        {
            IList<Card> card = new List<Card>();
            foreach (var suit in CardConstants.GetAllValidSuits())
            {
                foreach (var cardValue in CardConstants.GetAllValidValues())
                {
                    card.Add(new Card{ Suit = suit, Value = cardValue });
                    
                }
            }

            return card;
        }
    }
}

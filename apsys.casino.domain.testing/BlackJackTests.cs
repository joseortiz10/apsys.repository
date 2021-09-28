using apsys.casino.domain.Shared;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace apsys.casino.domain.testing
{
    public class BlackJackTests
    {
        [Test]
        public void BuildDeck_ReturnValidDeck()
        {
            //Arrange
            BlackJack backJack = new BlackJack();
            //Act
            IEnumerable<Card> deck = backJack.BuildDeck();
            //Assert
            Assert.NotNull(deck);
            Assert.That(deck.Count, Is.EqualTo(52));
            foreach(var suit in CardConstants.GetAllValidSuits())
            {
                foreach(var cardValue in CardConstants.GetAllValidValues())
                {
                    Assert.That(deck.Count(c=>c.Suit ==suit && c.Value ==cardValue), Is.EqualTo(1));
                }
            }
        }
    }
}

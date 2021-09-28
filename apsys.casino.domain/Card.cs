using apsys.casino.domain.Shared;
using System.Collections.Generic;
using System.Linq;

namespace apsys.casino.domain
{
    public class Card: ITesteable
    {
        public string Suit { get; set; }
        public string Value { get; set; }

        public bool IsValid()
            => CardConstants.GetAllValidSuits().Contains(this.Suit)
            && CardConstants.GetAllValidValues().Contains(this.Value);

        public void SetMockData()
        {
            this.Suit = CardConstants.Diamonds;
            this.Value = "1";
        }
    }
}

using apsys.casino.domain.Shared;
using System.Collections.Generic;
using System.Linq;

namespace apsys.casino.domain
{
    public class Card
    {
        public string Suit { get; set; }
        public string Value { get; set; }

        public bool IsValid()
        {
            IList<string> cases = new List<string>() { SuitConstant.Diamonds, SuitConstant.Spades, SuitConstant.Clubs, SuitConstant.Hearts};
            string[] validValues = new string[] { "1", "2", "3", "4", "5", "6", "7", "10", "J", "Q", "K"};


            if ((cases.Any(x=>x==this.Suit)) && validValues.Contains(this.Value))
                return true;
            return false;
        }

        public void SetMockData()
        {
            this.Suit = SuitConstant.Diamonds;
            this.Value = "1";
        }
    }
}

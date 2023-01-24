using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankV2.Models
{
    public class User : Human
    {
        public List<BankCard> BankCards { get; private set; }

        public User(string firtName, string middleName, string lastName, List<BankCard> cards)
        {
            FirstName = firtName;
            MiddleName = middleName;
            LastName = lastName;
            BankCards = cards;
        }

        public User()
        {

        }

        public void CreateNewBankCard(string numberCard)
        {
            BankCard card = new BankCard(numberCard, 0);
            BankCards.Add(card);
        }
    }
}

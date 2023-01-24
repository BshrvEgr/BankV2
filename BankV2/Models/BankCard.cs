using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankV2.Models
{
    public class BankCard
    {
        public string NumberCard { get; private set; }
        public int Cash { get; private set; }

        public BankCard(string numberCard, int cash)
        {
            NumberCard = numberCard;
            Cash = cash;
        }

        public BankCard()
        {

        }

        public void TakeOnMoney(int money)
        {
            Cash += money;
        }

        public void TakeOffMoney(int money)
        {
            if(money <= Cash)
                Cash -= money;
        }
    }
}

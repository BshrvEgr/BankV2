using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankV2.Models;
using System.Threading;

namespace BankV2
{
    class Program
    {
        static User user;

        static void GetCards()
        {
            int iter = 0;
            int numberCard = 0;
            Console.WriteLine($"{user.MiddleName} {user.FirstName} {user.LastName}, выберите карту:");

            foreach(var card in user.BankCards)
            {
                iter++;
                Console.WriteLine($"{iter}. {card.NumberCard}");
            }

            Console.WriteLine($"{user.BankCards.Count + 1}. Создать новую карту");

            numberCard = Convert.ToInt32(Console.ReadLine());

            if (numberCard > 0 && numberCard <= user.BankCards.Count)
            {
                Console.Clear();
                BankCardTransactions(user.BankCards[numberCard - 1]);
            }

            else
            {
                if(numberCard == user.BankCards.Count + 1)
                {
                    Console.Clear();
                    string userNumberCard = "";

                    Console.Write("Введите номер новой карты: ");
                    userNumberCard = Console.ReadLine();
                    user.CreateNewBankCard(userNumberCard);
                    Console.Clear();
                    GetCards();
                }

                else
                {
                    Console.Clear();
                    GetCards();
                }
            }
        }

        static void BankCardTransactions(BankCard selectedCard)
        {
            int numberCommand = 0;
            Console.WriteLine("1. Снять\n2. Пополнить\n3. Посмотреть баланс");

            numberCommand = Convert.ToInt32(Console.ReadLine());

            switch (numberCommand)
            {
                case 1:
                    Console.Clear();
                    int takeOffMoney = 0;
                    Console.Write("Введите сумму: ");
                    takeOffMoney = Convert.ToInt32(Console.ReadLine());
                    selectedCard.TakeOffMoney(takeOffMoney);
                    Console.Clear();
                    GetCards();
                    break;

                case 2:
                    Console.Clear();
                    int takeOnMoney = 0;
                    Console.Write("Введите сумму: ");
                    takeOnMoney = Convert.ToInt32(Console.ReadLine());
                    selectedCard.TakeOnMoney(takeOnMoney);
                    Console.Clear();
                    GetCards();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine($"Ваш баланс на данной карте составляет: {selectedCard.Cash}");
                    Thread.Sleep(2000);
                    Console.Clear();
                    GetCards();
                    break;
            }
        }

        static void Main(string[] args)
        {
            List<BankCard> bankCards = new List<BankCard>()
            {
                new BankCard("2202 2003 1234 4342", 1200), 
                new BankCard("5420 5472 8183 9152", 7904)
            };

            user = new User("Егор", "Башаров", "Сергеевич", bankCards);

            GetCards();
            Console.ReadKey();
        }
    }
}

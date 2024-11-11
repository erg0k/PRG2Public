using System;

namespace S12345678_CashCardApp
{
    class Program
    {
        static void InitCardList(List<CashCard> cardList)
        {
            cardList.Add(new CashCard("001", 25));
            cardList.Add(new CashCard("002", 25));
            cardList.Add(new CashCard("003", 30));
            cardList.Add(new CashCard("004", 30));
            cardList.Add(new CashCard("005", 50));
        }

        static CashCard? Search(List<CashCard> cardList, string id)
        {
            foreach(CashCard card in cardList)
            {
                if (card.Id == id)
                {
                    return card;
                }
            }

            return null;
        }

        static void Main()
        {
            List<CashCard> cardList = new List<CashCard>();
            InitCardList(cardList);

            foreach(CashCard card in cardList)
            {
                Console.WriteLine(card.ToString());
            }

            Console.Write("Enter search id: ");
            string searchId = Console.ReadLine();

            CashCard? found = Search(cardList, searchId);

            if (found != null)
            {
                Console.WriteLine($"Current balance: {found.Balance}");

                Console.Write("Enter deduction amount: ");
                double deductionAmount = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Deducation status: {found.Deduct(deductionAmount)}");
                Console.WriteLine($"New balance: {found.Balance}");
            }

            else
            {
                Console.WriteLine("No ID found");
            }
        }
    }
}

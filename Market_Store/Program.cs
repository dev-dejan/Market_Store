using System;

namespace Market_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Bronze_card BronzeCard = new Bronze_card("Tom", "Hanks", 100, 150);
            Silver_card SilverCard = new Silver_card("Jack", "Nicholson", 600, 850);
            Gold_card GoldCard = new Gold_card("Johnny", "Depp", 1500, 1300);

            Console.WriteLine("Bronze:");
            Console.WriteLine(BronzeCard.ToString());
            Console.WriteLine("\nSilver:");
            Console.WriteLine(SilverCard.ToString());
            Console.WriteLine("\nGold:");
            Console.WriteLine(GoldCard.ToString());
            Console.ReadKey();
        }
    }
}

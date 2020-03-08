using System;

namespace Bank
{
    class Program
    {
        static Banker honestBanker = new HonestBanker("Harry");
        static Banker sneakyBanker = new SneakyBanker("Luke");

        static float money1 = 20, money2 = 30;

        static void Main(string[] args)
        {
            Console.WriteLine("Obu bankierom dano do wyliczenia wypłatę z dwóch kwot: {0} PLN i {1} PLN.", money1, money2);
            Console.WriteLine("{0} wyliczył kwotę {1} PLN.", honestBanker.name, honestBanker.Count(money1, money2));
            Console.WriteLine("{0} wyliczył kwotę {1} PLN.", sneakyBanker.name, sneakyBanker.Count(money1, money2));
        }
    }
}

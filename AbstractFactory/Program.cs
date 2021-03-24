using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar volkswagen = new Volkswagen();
            Client volkswagenClient = new Client(volkswagen);
            Console.WriteLine(volkswagenClient.GetNormalCarDetail());
            Console.WriteLine(volkswagenClient.GetSportCarDetail());

            ICar mercedes = new MercedesBenz();
            Client mercedesBenzClient = new Client(mercedes);
            Console.WriteLine(mercedesBenzClient.GetNormalCarDetail());
            Console.WriteLine(mercedesBenzClient.GetSportCarDetail());
        }
    }
}

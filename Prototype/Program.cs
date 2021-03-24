using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person
            {
                Age = 25,
                City = "Diyarbakır",
                Name = "Ziya",
                Surname = "Gökalp"
            };
            Person person2 = person1.Clone() as Person;
            Console.WriteLine($"Klonlanan yazar adı: { person2.Name } soyadı: { person2.Surname }");

        }
    }
}

using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var carACreator = new CarCreator(new CarABuilder());
            carACreator.CreateCar();
            var carA = carACreator.GetCar();
            carA.ShowInfo();

            var carBCreator = new CarCreator(new CarBBuilder());
            carBCreator.CreateCar();
            var carB = carBCreator.GetCar();
            carB.ShowInfo();

        }
    }
}

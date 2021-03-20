using System;

namespace Builder
{
    /// <summary>
    /// Product Classım
    /// </summary>
    public class Car
    {
        public int Model { get; set; }
        public string Engine { get; set; }
        public string Fuel { get; set; }
        public double Price { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Motor: {0}", Engine);
            Console.WriteLine("Yakıt Türü: {0}", Fuel);
            Console.WriteLine("Fiyat: {0}", Price);
        }
    }
}

namespace Builder
{
    /// <summary>
    /// A tipi için kullandığım concrete builder class - Concrete Builder
    /// </summary>
    public class CarABuilder : ICarBuilder
    {
        Car car = new Car();
        public Car GetCar()
        {
            return car;
        }

        public void SetEngine()
        {
            car.Engine = "2.0 Motor";
        }

        public void SetFuel()
        {
            car.Fuel = "Dizel";
        }

        public void SetModel()
        {
            car.Model = 2020;
        }

        public void SetPrice()
        {
            car.Price = 269.90;
        }
    }
}

namespace Builder
{
    /// <summary>
    /// B tipi için kullandığım concrete builder class - Concrete Builder
    /// </summary>
    public class CarBBuilder : ICarBuilder
    {
        Car car = new Car();
        public Car GetCar()
        {
            return car;
        }

        public void SetEngine()
        {
            car.Engine = "1.5 Motor";
        }

        public void SetFuel()
        {
            car.Fuel = "Benzinli";
        }

        public void SetModel()
        {
            car.Model = 2012;
        }

        public void SetPrice()
        {
            car.Price = 169.50;
        }
    }
}

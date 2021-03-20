namespace Builder
{
    /// <summary>
    /// Direktör classım - Director
    /// </summary>
    public class CarCreator
    {
        private ICarBuilder _carBuilder;
        public CarCreator(ICarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }
        public void CreateCar()
        {
            _carBuilder.SetEngine();
            _carBuilder.SetFuel();
            _carBuilder.SetModel();
            _carBuilder.SetPrice();
        }
        public Car GetCar()
        {
            return _carBuilder.GetCar();
        }
    }
}

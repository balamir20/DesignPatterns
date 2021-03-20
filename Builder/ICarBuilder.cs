namespace Builder
{
    /// <summary>
    /// Builder interface
    /// </summary>
    public interface ICarBuilder
    {
        void SetModel();
        void SetEngine();
        void SetFuel();
        void SetPrice();
        Car GetCar();
    }
}

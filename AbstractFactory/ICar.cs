namespace AbstractFactory
{
    /// <summary>
    /// Abstract Factorynin arayüzü
    /// </summary>
    public interface ICar
    {
        INormalCar GetNormalCar();
        ISportCar GetSportCar();
    }
}

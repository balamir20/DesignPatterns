namespace AbstractFactory
{
    /// <summary>
    /// Concrete sınıfım
    /// </summary>
    public class Volkswagen : ICar
    {
        public INormalCar GetNormalCar()
        {
            return new VolkswagenPolo();
        }

        public ISportCar GetSportCar()
        {
            return new VolkswagenArteon();
        }
    }
}

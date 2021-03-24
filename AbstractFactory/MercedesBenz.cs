namespace AbstractFactory
{
    /// <summary>
    /// Diğer Concrete sınıfım
    /// </summary>
    public class MercedesBenz : ICar
    {
        public INormalCar GetNormalCar()
        {
            return new MercedesBenzC200();
        }

        public ISportCar GetSportCar()
        {
            return new MercedesBenzAmgCoupe();
        }
    }
}

namespace AbstractFactory
{
    public class Client
    {
        ISportCar sportCar;
        INormalCar normalCar;
        public Client(ICar factory)
        {
            sportCar = factory.GetSportCar();
            normalCar = factory.GetNormalCar();
        }
        public string GetSportCarDetail()
        {
            return sportCar.GetEnginePower();
        }
        public string GetNormalCarDetail()
        {
            return normalCar.GetEnginePower();
        }
    }
}

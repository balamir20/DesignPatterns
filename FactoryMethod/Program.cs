namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportTypeFactory logisticsFactory = new TransportTypeFactory();

            ITransport truck = logisticsFactory.GetTransportType(TransportType.Truck);
            truck.TransportType();

            ITransport ship = logisticsFactory.GetTransportType(TransportType.Ship);
            ship.TransportType();

            ITransport plane = logisticsFactory.GetTransportType(TransportType.Plane);
            plane.TransportType();
        }
    }
}

namespace Factory
{
    public interface ITransportTypeFactory
    {
        ITransport GetTransportType(TransportType transportType);
    }
    /// <summary>
    /// Sınıflardan nesne üretecek. Parametre olarak aldığı enum'ı kullanarak üretmesini istediğimiz tipi söylüyoruz.
    /// </summary>
    public class TransportTypeFactory : ITransportTypeFactory
    {
        public ITransport GetTransportType(TransportType transportType)
        {
            ITransport transport = null;
            switch (transportType)
            {
                case TransportType.Truck:
                    transport = new TruckLogistics();
                    break;
                case TransportType.Ship:
                    transport = new ShipLogistics();
                    break;
                case TransportType.Plane:
                    transport = new PlaneLogistics();
                    break;
            }
            return transport;
        }
    }
}

using System;

namespace Factory
{
    public class ShipLogistics : ITransport
    {
        public void TransportType()
        {
            Console.WriteLine("Gemi ile nakliyat");
        }
    }
}

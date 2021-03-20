using System;

namespace Factory
{
    public class TruckLogistics : ITransport
    {
        public void TransportType()
        {
            Console.WriteLine("Kamyon ile nakliyat");
        }
    }
}

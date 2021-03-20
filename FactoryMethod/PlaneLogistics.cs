using System;

namespace Factory
{
    public class PlaneLogistics : ITransport
    {
        public void TransportType()
        {
            Console.WriteLine("Uçak ile nakliyat");
        }
    }
}

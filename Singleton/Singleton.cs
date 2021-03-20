using System;

namespace Singleton
{
    /// <summary>
    /// Singleton bir programın yaşam süresince belirli bir nesneden sadece bir örneğinin (instance) olmasını sağlar
    /// Kodun herhangi bir yerinden nesnelere erişmenizi sağlar. Bununla birlikte, bu örneğin üzerine başka bir kodun yazılmasını da önler.
    /// </summary>
    public class Singleton
    {
        private static Singleton _singleton;
        private static Object _lockControl = new object();

        private Singleton()
        {

        }
        public static Singleton GetInstance()
        {

            if (_singleton == null)
                _singleton = new Singleton();
            return _singleton;
        }

        ///// <summary>
        ///// Eğer çok kanallı(multi thread) bi uygulama geliştiriyorsak aynı anda birden fazla thread aynı nesneyi üretebilir.
        ///// Farklı threadlerin aynı nesneyi tekrar yaratmasını engellemek için ekstra kontrol yapmak zorundayız.  
        ///// </summary>
        ///// <returns></returns>
        //public static Singleton GetInstance()
        //{

        //    if (_singleton == null)
        //        lock (_lockControl)
        //        {
        //            if (_singleton==null)
        //            {
        //                _singleton = new Singleton();
        //            }
        //        }
        //    return _singleton;
        //}
    }
}

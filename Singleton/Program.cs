using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton pattern doğru uygulandı, her iki değişken de aynı instance(örneği) içerir");
            }
            else
            {
                Console.WriteLine("Singleton başarısız, değişkenler farklı örnekler içeriyor.");
            }
        }
    }
}

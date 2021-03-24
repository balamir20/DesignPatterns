using System;

namespace Prototype
{
    public class Person : ICloneable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        public object Clone()
        {
            return (Person)this.MemberwiseClone();
        }
    }
}

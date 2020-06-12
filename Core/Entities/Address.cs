using System;

namespace Core.Entities
{
    class Address : EntityBased
    {
        public String Street { get; set; }
        public string City { get; set; }
        public string Number { get; set; }
    }
}

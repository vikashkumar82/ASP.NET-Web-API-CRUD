using Sieve.Attributes;

namespace ReactAPI_CRUD.Model
{
    public class Employee
    {

        [Sieve(CanFilter = true, CanSort = true)]
        public int ID { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public string? Name { get; set; }
        public string? Age { get; set; }
        public int  isActive { get; set; }

    }
}

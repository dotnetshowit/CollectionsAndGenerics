using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndGenerics
{
    internal class Employee
    {
        public Employee()
        {
            Cards = new List<Card>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Card> Cards { get; set; }

        public string CityID { get; set; }
        public string CountryId { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}

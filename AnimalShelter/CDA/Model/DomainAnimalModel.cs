using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDA.Model
{
    public class DomainAnimalModel
    {
        public int AnimalID { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public DateTime DateOfArrival { get; set; }
        public Decimal WeightAtArrivalKG { get; set; }
    }
}

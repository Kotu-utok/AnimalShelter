using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("animalsinfo")]
    public class DALAnimalModel
    {
        [Key]
        public int AnimalID { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public DateTime DateOfArrival { get; set; }
        public float WeightAtArrivalKG { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("prescription")]
    public class DALPrescriptionModel
    {
        [Key]
        public int MedicationID { get; set; }
        public int AnimalID { get; set; }
        public string Prescription { get; set; }
    }
}

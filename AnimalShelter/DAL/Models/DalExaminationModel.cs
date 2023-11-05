using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("excamination")]
    public class DalExaminationModel
    {
        [Key]
        public int ExaminationID { get; set; }
        public int AnimalID { get; set; }
        public int MedicationID { get; set; }
        public float Weight { get; set; }
        public string Observations { get; set; }
        public string VaccinationStatus { get; set; }
        public string RehabiliationStatus { get; set; }
        public string QuarantineStatus { get; set; }
    }
}

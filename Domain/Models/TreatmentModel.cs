using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models {
    public class TreatmentModel {
        [Key]
        public int Id {  get; set; }
        public string? Description {  get; set; }
        public string Type {  get; set; }
        public string? Room {  get; set; }
        public RemarkModel? Remark {  get; set; }
        public TherapistModel TreatmentBy {  get; set; }
        public DateTime TreatmentDate { get; set; }

        public TreatmentModel() {
            
        }

    }
}

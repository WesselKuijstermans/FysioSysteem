using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models {
    public class RemarkModel {
        [Key]
        public int Id {  get; set; }
        public string Remark {  get; set; }
        public DateTime Date {  get; set; }
        public TherapistModel Therapist {  get; set; }
        public bool VisibleToPatient {  get; set; }
        public RemarkModel() {
          
        }
    }
}

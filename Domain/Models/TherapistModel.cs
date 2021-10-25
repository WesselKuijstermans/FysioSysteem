using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models {
    public class TherapistModel : PersonModel {

        public int StaffId {  get; set; }
        public int BIGNumber {  get; set; }
        public string Availability { get; set; }

        public TherapistModel() {
           
        }
    }
}

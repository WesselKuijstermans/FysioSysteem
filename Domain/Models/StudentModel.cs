using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models {
    public class StudentModel : PersonModel {

        public int StudentId { get; set; }
        public string Availability {  get; set; }

        public StudentModel() {  
            
        }
    }
}

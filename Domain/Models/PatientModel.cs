
using System;
using System.ComponentModel.DataAnnotations;

namespace DomainModel.Models {
    public class PatientModel : PersonModel {
        public string DateOfBirth { get; set; }
        public string Gender {  get; set; }
        public string Picture { get; set; }
        public int ID {  get; set; }
        public int TypeID {  get; set; }
        public PatientFileModel PatientFile { get; set; }

        public PatientModel()  {
            
        }
    }
}
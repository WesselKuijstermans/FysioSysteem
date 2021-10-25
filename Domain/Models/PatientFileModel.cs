
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DomainModel.Models {
    public class PatientFileModel {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string IllnessDescription { get; set; }
        public string DiagnoseCodeAndDescription { get; set; }
        public bool IsStudent { get; set; }
        public TherapistModel IntakeDoneBy { get; set; }
        public TherapistModel IntakeSupervisedBy { get; set; }
        public TherapistModel MainTherapist { get; set; }
        public DateTime DateOfSignUp { get; set; }
        public DateTime DateOfDismissal { get; set; }
        public List<RemarkModel> Remarks { get; set; }
        public string TreatmentPlan { get; set; }
        public List<TreatmentModel> Treatments { get; set; }

    }
}
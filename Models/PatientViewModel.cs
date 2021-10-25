using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FysioSysteem.Models {
    public class PatientViewModel {
        [Required(ErrorMessage = "Voer uw naam in")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Voer uw email adress in")]
        [EmailAddress]
        public string Email { get; set; }

        [BindProperty, DataType(DataType.Date)]
        [Required(ErrorMessage = "Voer uw geboortedatum in")]
        public String DateOfBirth { get; set; }   
        
        [Required(ErrorMessage = "Voer uw telefoonnummer in")]
        public string Phone { get; set; }
    }
}

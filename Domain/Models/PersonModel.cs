
using System;
using System.ComponentModel.DataAnnotations;

namespace DomainModel.Models {
    public abstract class PersonModel {
        
        public string Name { get; set; }
        [Key]
        public string Email { get; set; }

        public PersonModel() {
           
        }
    }
}
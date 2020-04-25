using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_School.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(50, ErrorMessage = "This field can not be empty")]
        public string Name { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }
        
        // Aplicación de una expresión regular para validar el NIF en el mismo modelo. 
        [RegularExpression("((([X-Z])|([LM])){1}([-]?)((\\d){7})([-]?)([A-Z]{1}))|((\\d{8})([-]?)([A-Z]))", ErrorMessage = "Invalid Nif")]
        public string Nif { get; set; }
        
        [StringLength(15)]
        public string Gender { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "This field can not be empty")] // Los campos fecha siempre son requeridos.
        [Display(Name = "Date Of Birth")]
        public DateTime BirthDate { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(500)]
        public string Address { get; set; }
        [StringLength(5)]
        public string Cp { get; set; }
        public bool Active { get; set; }

        public int? StudentId { get; set; }
        public int? TeacherId { get; set; }
        public int? TutorId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Tutor Tutor { get; set; }

    }
}

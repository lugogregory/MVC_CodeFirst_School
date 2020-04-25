using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_School.Models
{
    public class Tutor
    {
        public int Id { get; set; }
        public string Occupation { get; set; }
        public virtual ICollection<TutorStudent> TutorStudents { get; set; }
        
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_School.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public double Salary { get; set; }
        public virtual ICollection<TeacherCareer> TeacherCareers { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
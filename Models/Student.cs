using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_School.Models
{
    public class Student
    {
        public int Id { get; set; }
        public double Average { get; set; }
        public DateTime EnrollmentDay { get; set; }
        public virtual ICollection<StudentDiploma> StudentDiplomas { get; set; }
        public virtual ICollection<TutorStudent> TutorStudents { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
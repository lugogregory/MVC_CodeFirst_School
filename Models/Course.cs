using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_School.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int AreaId { get; set; }
        public virtual Area Area { get; set; }
        public virtual  ICollection<Enrollment> Enrollments { get; set; }
    }
}
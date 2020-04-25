using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_School.Models
{
    public class Section
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Grade { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_School.Models
{
    public class Lapse  //También tengo dudas con este nombre, pero creo que si es corecto
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}

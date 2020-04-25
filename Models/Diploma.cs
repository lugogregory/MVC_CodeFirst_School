using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_School.Models
{
    public class Diploma
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<StudentDiploma> StudentDiplomas { get; set; }
    }
}

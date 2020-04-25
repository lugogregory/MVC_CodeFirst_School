using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_School.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public DateTime Date { get; set; }
        public double Grade { get; set; }  
        public int? StudentId { get; set; }
        public int? TeacherId { get; set; }
        public int? CourseId { get; set; }
        public int? LapseId { get; set; }
        public int? SectionId { get; set; }

        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public Course Course { get; set; }
        public Lapse Lapse { get; set; }
        public Section Section { get; set; }
    }
}

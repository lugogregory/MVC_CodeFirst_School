using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_School.Models
{
    public class TeacherCareer
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        
        public int CareerId { get; set; }
        public Teacher Teacher { get; set; }
        public Career Career { get; set; }
    }
}

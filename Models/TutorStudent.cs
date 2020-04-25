using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_School.Models
{
    public class TutorStudent
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int TutorId { get; set; }
        public Tutor Tutor { get; set; }
        public Student Student { get; set; }
    }
}

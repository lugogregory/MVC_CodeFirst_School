﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_School.Models
{
    public class StudentDiploma
    {

        public int Id { get; set; }
        public int StudentId { get; set; }
        public int DiplomaId { get; set; }

        public Student Student { get; set; }
        public Diploma  Diploma { get; set; }
    }
}

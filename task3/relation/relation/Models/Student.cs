﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace relation.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int GroupID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public Group group { get; set; }
    }
}

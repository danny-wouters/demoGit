﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp_Models
{
    class Course
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public double Price { get; set; }
        public string RequiredSkills { get; set; }
        public int MaximumStudents { get; set; }
    }
}
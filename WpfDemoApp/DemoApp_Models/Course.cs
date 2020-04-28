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
        public string Description { get; set; }
        public string FullDescription { get; set; }
        public int Duration { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp_Models
{
    class Book: Product
    {
        public string Author { get; set; }
        public string Genre { get; set; }
        public string ISBN { get; set; }
    }
}

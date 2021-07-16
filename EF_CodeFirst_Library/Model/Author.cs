using System;
using System.Collections.Generic;
using System.Text;

namespace EF_CodeFirst_Library.Model
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
    }
}
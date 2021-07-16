using System;
using System.Collections.Generic;

namespace EF_CodeFirst_Library.Model
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Headquarters { get; set; }
        public DateTime EstablishedYear { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaAPI.Models
{
    public class Movie
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public decimal Rating { get; set; } 
    }
}

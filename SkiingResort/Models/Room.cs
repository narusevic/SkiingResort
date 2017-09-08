using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkiingResort.Models
{
    public class Room
    {
        public int Number { get; set; }
        public bool Available { get; set; }
        public double Price { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiderPattern.Models
{
    internal class House
    {
        public int Walls {  get; set; }
        public int Doors {  get; set; }
        public int Windows {  get; set; }

        public override string ToString()
        {
            return $"House with {Walls} Walls, {Doors} Doors, and {Windows} Windows.";
        }
    }
}

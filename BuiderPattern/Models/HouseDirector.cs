using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiderPattern.Models
{
    internal class HouseDirector
    {
        private IHouseBuilder builder;

        public HouseDirector(IHouseBuilder builder1)
        {
            builder = builder1;

        }
        public House BuildSimpleHouse()
        {
            return builder.BuildWalls(4).BuildDoors(1).BuildWindows(2).Build();
        }
        public House BuildLuxuryHouse()
        {
            return builder.BuildWalls(10).BuildDoors(4).BuildWindows(8).Build();
        }
    }
}

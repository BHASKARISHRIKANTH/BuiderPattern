using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiderPattern.Models
{
    internal class HouseBuilder:IHouseBuilder
    {
        private House house=new House();

        public IHouseBuilder BuildWalls(int walls)
        {
            house.Walls = walls;
            return this;

        }
        public IHouseBuilder BuildDoors(int doors)
        {
            house.Doors = doors;
            return this;
        }
        public IHouseBuilder BuildWindows(int windows)
        {
            house.Windows = windows;
            return this;
        }
        public House Build()
        {
            return house;
        }
    }
}

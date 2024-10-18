using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiderPattern.Models
{
    internal interface IHouseBuilder
    {
        IHouseBuilder BuildWalls(int walls);
        IHouseBuilder BuildDoors(int doors);
        IHouseBuilder BuildWindows(int windows);
        House Build();
    }
}

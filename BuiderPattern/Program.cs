using BuiderPattern.Models;

namespace BuiderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHouseBuilder builder = new HouseBuilder();

            HouseDirector director=new HouseDirector(builder);

            House simpleHouse=director.BuildSimpleHouse();
            Console.WriteLine("Simple"+simpleHouse);

            House LuxuryHouse=director.BuildLuxuryHouse();
            Console.WriteLine("Luxury"+LuxuryHouse);
        }
    }
}

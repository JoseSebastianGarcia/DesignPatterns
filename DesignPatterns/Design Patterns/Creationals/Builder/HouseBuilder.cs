using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Creationals.Builder
{
    public class HouseBuilder
    {
        private House _house;

        public HouseBuilder (int rooms, int windows) 
        {
            _house = new House();
            _house.Rooms = rooms;
            _house.Windows = windows;
        }

        public HouseBuilder WithGarage(bool automaticDoor, int cars) 
        {

            _house.Garage = new Garage() { 
                AutomaticDoor = automaticDoor,
                Cars = cars
            };

            return this;
        }
        public HouseBuilder WithSwimmingPool(int width, int height, int depth)
        {

            _house.SwimmingPool = new SwimmingPool()
            {
                Depth = depth,
                Height = height,
                Width = width
            };

            return this;
        }
        public HouseBuilder WithPark(int fountains, int trees)
        {
            _house.Park = new Park()
            {
                Fountains = fountains,
                Trees= trees
            };

            return this;
        }
        public House Build() 
        {
            return _house;
        }
    }
}

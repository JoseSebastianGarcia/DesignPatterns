using DesignPatterns.Design_Patterns.Creationals.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DesignPatterns.Views;

namespace DesignPatterns.Views.Design_Patterns.Creationals
{
    public class BuilderView : IView
    {
        public void Render()
        {
            Console.Clear();

            House milton = new HouseBuilder(3, 2).Build();
            Console.WriteLine($"Milton 6631\n{JsonSerializer.Serialize(milton)}");
            Console.WriteLine();

            House paraguay = new HouseBuilder(2, 0).WithGarage(false,3).Build();
            Console.WriteLine($"Paraguay 232\n{JsonSerializer.Serialize(paraguay)}");
            Console.WriteLine();

            House cordoba = new HouseBuilder(5, 3).WithPark(3,2).WithSwimmingPool(50,8,3).Build();
            Console.WriteLine($"Cordoba 611\n{JsonSerializer.Serialize(cordoba)}");
            Console.WriteLine();

            House messisPentHouse = new HouseBuilder(8, 6).WithPark(8, 50).WithSwimmingPool(100, 20, 8).WithGarage(true,50).Build();
            Console.WriteLine($"Messi's Penthouse\n{JsonSerializer.Serialize(messisPentHouse)}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

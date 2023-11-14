using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Creationals.Builder
{
    public class House
    {
        public Garage? Garage { get; set; }
        public SwimmingPool? SwimmingPool { get; set; }
        public Park? Park { get; set; }
        public int Windows { set; get; }
        public int Rooms { set; get; }
    }       
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Structure.Facade
{
    public class ComplexVideoSubsystem
    {
        public string RenderVideo(bool r) => (r ? "Video rendered" : "Video not rendered");
    }
}

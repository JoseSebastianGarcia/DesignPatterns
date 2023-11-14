using DesignPatterns.Design_Patterns.Structure.Facade;
using DesignPatterns.Design_Patterns.Structure.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Views.Design_Patterns.Structure
{
    public class FacadeView : IView
    {
        public void Render()
        {
            Console.Clear();

            ComplexVideoSubsystem videoSubsystem = new ComplexVideoSubsystem();
            ComplexAudioSubsystem audioSubsystem = new ComplexAudioSubsystem();

            //Utilizo ambas librerías complejas para ensamblar el audio y renderizar un video
            IFacade facade = new Facade(audioSubsystem, videoSubsystem);
            facade.Run(); 

            Console.ReadKey();

        }
    }
}

using DesignPatterns.Design_Patterns.Behavior.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Views.Design_Patterns.Behavior
{
    public class VisitorView : IView
    {
        public void Render()
        {
            Console.Clear();

            SystemVisitor visitor = new SystemVisitor();

            SsdDiskAdapter diskAdapter = new SsdDiskAdapter(Guid.NewGuid().ToString());
            WifiAdapter wifiAdapter = new WifiAdapter(Guid.NewGuid().ToString());

            //Anfitrión
            diskAdapter.Accept(visitor);
            wifiAdapter.Accept(visitor);

            //Visitante: Ejemplo para mostrar reversibilidad
            visitor.Visit(diskAdapter); //Idem linea 22
            visitor.Visit(wifiAdapter); //Idem linea 23

            Console.ReadKey();
        }
    }
}

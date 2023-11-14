using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DesignPatterns.Design_Patterns.Prototype;

namespace DesignPatterns.Views
{
    public class PrototypeView : IView
    {
        public void Render()
        {
            Console.Clear();
            Person person = new Person();
            person.Id = 1;
            person.Name = "Juan";
            person.Description = "A man";
            person.Age = 19;
            person.Pet.Type = "DOG";
            person.Pet.Name = "MAX";

            Console.WriteLine("Normal person");
            Console.WriteLine(JsonSerializer.Serialize(person));

            Person clonedPerson = (Person)person.Clone();
            clonedPerson.Id = 2;
            clonedPerson.Name = "Pepe";
            clonedPerson.Age = 20;
            clonedPerson.Pet = new Pet()
            {
                Type = "CAT",
                Name = "FIGARO"
            };

            Console.WriteLine("Shallow cloned person");
            Console.WriteLine(JsonSerializer.Serialize(clonedPerson));

            Console.ReadKey();
        }
    }
}

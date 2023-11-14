using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Chain_of_Responsibility
{
    public abstract class Link
    {
        private Link? next;

        public Link? SetNext(Link link) 
        {
            next = link;
            return link;
        }
        
        public abstract void Handle(string command);

        protected void Next(string command) 
        {
            if (next != null)
                next.Handle(command);
        }
    }
}

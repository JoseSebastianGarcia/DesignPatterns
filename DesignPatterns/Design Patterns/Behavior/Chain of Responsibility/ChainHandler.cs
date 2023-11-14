using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Chain_of_Responsibility
{
    public class ChainHandler
    {
        private Link? _link;
        private Link? _firstLink;
        public void AddLink(Link link) 
        {
            if (_link == null)
            {
                _link = link;
                _firstLink = link;
            }
            else
            {
                _link.SetNext(link);
                _link = link;
            }
        }

        public void Execute(string command)
        {
            if (_firstLink != null)
                _firstLink.Handle(command);
        }
    }
}

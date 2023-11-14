using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Singleton
{
    public class MessageContext
    {
        #region Singleton
        private static MessageContext? _context;
        public static MessageContext GetInstance() 
        {
            if(_context == null) 
                _context = new MessageContext();
            
            return _context;
        }
        private MessageContext() { }
        #endregion

        public string Message() => "Mensaje";
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Behavior.Command
{
    public static class Clipboard
    {
        private static string _text = string.Empty;

        public static void Set(string text) 
        {
            _text = text;
        }

        public static string Get() => _text;
    }
}

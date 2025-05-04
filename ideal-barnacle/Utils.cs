using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ideal_barnacle
{
    public static class Utils
    {
        public static void ShowHelp()
        {
            Console.WriteLine("USAGE: ideal-barnacle [HOSTNAME] <port>");
            Console.WriteLine("The square brackets show mandatory fields");
            Console.WriteLine("The angled brackets show optional fields");
            Console.WriteLine("--version    Display version");
            Console.WriteLine("--help       Display help text");
        }
    }
}

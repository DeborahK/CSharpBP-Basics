using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public class LoggingService
    {
        public void LogAction(string action)
        {
            Console.WriteLine(DateTime.Now + ": " + action);
        }

        public string SayHello()
        {
            return "Hello from the logging service";
        }
    }
}

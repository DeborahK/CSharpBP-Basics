using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    /// <summary>
    /// Provides logging.
    /// </summary>
    public static class LoggingService
    {
        /// <summary>
        /// Logs actions.
        /// </summary>
        /// <param name="action">Action to log.</param>
        public static void LogAction(string action)
        {
            Console.WriteLine(DateTime.Now + ": " + action);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        /// <returns></returns>
        public static string SayHello()
        {
            return "Hello from the logging service";
        }
    }
}

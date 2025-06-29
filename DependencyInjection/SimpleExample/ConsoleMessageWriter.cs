using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.SimpleExample
{
    internal class ConsoleMessageWriter : IMessageWriter
    {
        public void write(string message)
        {
            Console.WriteLine(message);
        }
    }
}

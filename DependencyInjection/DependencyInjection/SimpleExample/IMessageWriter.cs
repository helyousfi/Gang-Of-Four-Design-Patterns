using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.SimpleExample
{
    internal interface IMessageWriter
    {
        void write(string message);
    }
}

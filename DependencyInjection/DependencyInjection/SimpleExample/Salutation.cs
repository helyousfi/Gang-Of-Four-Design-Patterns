using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.SimpleExample
{
    internal class Salutation
    {
        private readonly IMessageWriter _messageWriter;
        public Salutation(IMessageWriter messageWriter)
        {
            if (messageWriter == null)
                throw new ArgumentNullException("Message Writer");
            _messageWriter = messageWriter;
        }
        public void Exclaim(string message)
        { 
            this._messageWriter.write(message);
        }
    }
}

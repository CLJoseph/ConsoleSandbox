using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSandbox
{
    class Message
    {
        public Message(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        public void Terminate()
        {
            Console.WriteLine("Done, press any key to terminate");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSandbox
{
    class Message
    {
        public string Filename { get; set; }

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

        public void getFileName()
        {
            Console.Write(" Enter Filename (nb .txt extension added automatically) :");  
            Filename =  Console.ReadLine() + ".txt";
        }

        public void FileNameIs()
        {
            Console.WriteLine("File name is :"+ Filename);
        }        


    }
}

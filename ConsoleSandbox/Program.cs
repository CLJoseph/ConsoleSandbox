using System;

namespace ConsoleSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Message Test = new Message("Hello out there");

            Test.getFileName();
            Test.FileNameIs();


            Test.Terminate();
        }
    }
}

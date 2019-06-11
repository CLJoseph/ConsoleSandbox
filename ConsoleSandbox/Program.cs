using System;
using System.IO;
using System.Text;

namespace ConsoleSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Message Test = new Message("Hello out there");

            Test.getFileName();
            Test.FileNameIs();
            // now create and write something to a file. 
            string path = ".\\" + Test.Filename;
            if (File.Exists(path)) { File.Delete(path); }

            FileStream fs = new FileStream(path,FileMode.Create);
            string msg = "here is some text for the file";
            byte[] tofile = new UTF8Encoding(true).GetBytes(msg);
            fs.Write(tofile);
            fs.Close();

            Test.Terminate();
        }
    }
}

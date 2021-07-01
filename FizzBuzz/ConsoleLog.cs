using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FizzBuzz
{
    public class ConsoleLog : IConsoleWriter
    {
        private string FileName;

        public ConsoleLog()
        {
            string filePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Results\"));
            FileName = String.Format("{0}/{1}.{2}", filePath, DateTime.Now.ToString("yyyy-MM-dd_HHmmss"), @"txt");
        }

        public void WriteLine(string format)
        {
            Console.WriteLine(format);
        }

        public void Output(int number)
        {
            Output(String.Format("{0}", number));
        }

        public void Output(string str)
        {
            WriteLine(str);
            using (StreamWriter w = File.AppendText(FileName))
            {
                w.WriteLine(str);
            }
        }
        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        ConsoleKeyInfo IConsoleWriter.ReadKey()
        {
            //throw new NotImplementedException();
            return new ConsoleKeyInfo();
        }
    }
}
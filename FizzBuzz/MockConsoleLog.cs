using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class MockConsoleLog : IConsoleWriter
    {
        public List<string> OutputData { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        private bool bReadStarted = false;

        public MockConsoleLog(int start, int end)
        {
            OutputData = new List<string>();
            Start = start;
            End = end;
        }

        public void WriteLine(string format)
        {
            // Do nothing
        }

        public void Output(int number)
        {
            Output(String.Format("{0}", number));
        }

        public void Output(string str)
        {
            OutputData.Add(str);
        }

        public ConsoleKeyInfo ReadKey()
        {
            return new ConsoleKeyInfo();
        }

        public string ReadLine()
        {
            if (!bReadStarted)
            {
                bReadStarted = true;
                return String.Format("{0}", Start);
            }
            return String.Format("{0}", End);
        }
    }
}
using System;

namespace FizzBuzz
{
    public interface IConsoleWriter
    {
        void WriteLine(string format);
        void Output(int number);
        void Output(string str);
        ConsoleKeyInfo ReadKey();
        string ReadLine();
    }
}
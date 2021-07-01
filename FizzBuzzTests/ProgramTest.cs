using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
using System.IO;
using FizzBuzz;
using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace FizzBuzzTests
{
    [TestClass]
    public class ProgramTest
    {  
        [TestMethod]
        public void TestOneToFifteen()
        {
            int start = 1, end = 15;
            MockConsoleLog console = new MockConsoleLog(start, end);

            FizzBuzz.Program.FizzBuzz(console, start, end);

            Assert.AreEqual(15, console.OutputData.Count, "Expecting 15 outputs");
            Assert.AreEqual("4", console.OutputData[3], "Expecting 4th entry to be 4");
            Assert.AreEqual("Buzz", console.OutputData[4], "Expecting 5th entry to be Buzz");
            Assert.AreEqual("Fizz", console.OutputData[5], "Expecting 6th entry to be Fizz");
            Assert.AreEqual("7", console.OutputData[6], "Expecting 7th entry to be 7");
            Assert.AreEqual("8", console.OutputData[7], "Expecting 8th entry to be 8");
            Assert.AreEqual("Fizz", console.OutputData[8], "Expecting 9th entry to be Fizz");
            Assert.AreEqual("Buzz", console.OutputData[9], "Expecting 10th entry to be Buzz");
            Assert.AreEqual("11", console.OutputData[10], "Expecting 11th entry to be 11");
            Assert.AreEqual("Fizz", console.OutputData[11], "Expecting 12th entry to be Fizz");
            Assert.AreEqual("13", console.OutputData[12], "Expecting 13th entry to be 13");
            Assert.AreEqual("14", console.OutputData[13], "Expecting 14th entry to be 14");
            Assert.AreEqual("FizzBuzz", console.OutputData[14], "Expecting 15th entry to be FizzBuzz");
        }

        [TestMethod]
        public void TestOneToThree()
        {
            int start = 1, end = 3;
            MockConsoleLog console = new MockConsoleLog(start, end);

            FizzBuzz.Program.FizzBuzz(console, start, end);

            Assert.AreEqual(3, console.OutputData.Count, "Expecting 3 outputs");
            Assert.AreEqual("1", console.OutputData[0], "Expecting 1st entry to be 1");
            Assert.AreEqual("2", console.OutputData[1], "Expecting 2nd entry to be 2");
            Assert.AreEqual("Fizz", console.OutputData[2], "Expecting 3rd entry to be Fizz");
        }

        [TestMethod]
        public void RunFizzBuzzTests()
        {
            StringWriter output = new StringWriter();
            Console.SetOut(output);
            int start = 1, end = 20;
            MockConsoleLog console = new MockConsoleLog(start, end);
            FizzBuzz.Program.FizzBuzz(console, start, end);
            Assert.AreEqual(string.Format("1{0}2{0}Fizz{0}4{0}Buzz{0}Fizz{0}7{0}8{0}Fizz{0}Buzz{0}11{0}Fizz{0}13{0}14{0}FizzBuzz{0}16{0}17{0}Fizz{0}19{0}Buzz{0}", Environment.NewLine), output.ToString());
        }
    }
}

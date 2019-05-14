using Demo;
using System.Runtime.CompilerServices;
using NUnit.Framework;
using System;
using System.IO;

namespace Tests
{
    [TestClass]
    public class Test
    {

       

        [TestCase()]
        public void invalidFiles()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.readFileLineByLine("dummy dummy");
                string expected = string.Format("No files{0}", Environment.NewLine);
                Assert.AreEqual(expected,sw.ToString());
                Console.Write("Test case pass");

            }

        }

        [TestCase()]
        public void validFiles()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.readFileLineByLine("/Users/shalvigupta/Projects/Demo/Demo");
                string expected = string.Format("Comparsion is done !{0}", Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
                Console.Write("Test case pass");

            }

        }
    }
}

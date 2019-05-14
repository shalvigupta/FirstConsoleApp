using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Demo
{
    class Program
    {
        static void Main(string[] args)

        {
            if (args.Length == 0)
            {
                Console.WriteLine("Empty directory passed");
                return;
            }

            readFileLineByLine(args[0].ToString());

        }

       public static void readFileLineByLine(string directoryPath)
        {
            if (File.Exists(Path.Combine(directoryPath, "fileA.csv")) && File.Exists(Path.Combine(directoryPath, "fileB.csv")))
            {
                String[] linesA = File.ReadAllLines(Path.Combine(directoryPath, "fileA.csv"));
                String[] linesB = File.ReadAllLines(Path.Combine(directoryPath, "fileB.csv"));

                IEnumerable<String> onlyB = linesB.Except(linesA);
                File.WriteAllLines(Path.Combine(directoryPath, "Result.txt"), onlyB);

                Console.WriteLine("Comparsion is done !");
            }
            else
            {
                Console.WriteLine("No files");
            }


        }
    }
}

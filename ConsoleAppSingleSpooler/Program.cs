using System;

namespace ConsoleAppSingleSpooler
{
    class Program
    {
        static void Main(string[] args)
        {

            //Print spooler is a software service that manages the printing process.
            //The spooler accepts print jobs from computers and makes sure that printer resources are available.
            //It also schedules the order in which jobs are sent to the print queue for printing.
            //In the early days of personal computers, you had to wait until a document printed before you could do anything else.


            PrintSpooler printSpooler1 = PrintSpooler.Instance;
            PrintSpooler printSpooler2 = PrintSpooler.Instance;

            if (printSpooler1 == printSpooler2)
            {
                Console.WriteLine("Both singletons contain the same the same reference");
            }
        }
    }
}

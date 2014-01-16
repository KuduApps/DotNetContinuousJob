using System;
using System.Configuration;
using System.Threading;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Working on " + ConfigurationManager.AppSettings["Work"]);
                Console.WriteLine("Connection string is " + ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                Thread.Sleep(1000);
            }
        }
    }
}
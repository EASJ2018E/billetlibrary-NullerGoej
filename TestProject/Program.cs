using System;
using BilletLibrary;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Bil bil = new Bil("Nummerplade");
            Console.WriteLine(bil.Pris());

            Console.ReadLine();
        }
    }
}

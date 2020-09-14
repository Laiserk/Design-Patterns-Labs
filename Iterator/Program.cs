using System;
using IteratorClasses;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path to the file...");
            string path = Console.ReadLine();
            StringCollection stringCollection = new StringCollection();
            stringCollection.readFile(path);
            //stringCollection
            Console.ReadKey();
        }
    }
}
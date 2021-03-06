﻿using System;
using IteratorClasses;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path to the file...");
            string path = Console.ReadLine();
            FileStringCollection stringCollection = new FileStringCollection(path);
            StringIterator iterator = (StringIterator)stringCollection.CreateIterator();
            while(iterator.HasMore())
            {
                Console.WriteLine(iterator.Next());
                Console.ReadKey();
            }
            Console.WriteLine("--- End of file ---");
            Console.ReadKey();
        }
    }
}
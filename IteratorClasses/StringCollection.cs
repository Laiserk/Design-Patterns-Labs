using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace IteratorClasses
{
    public class FileStringCollection : IterableCollection
    {
        public string[] strings { get; private set; }
        public Iterator CreateIterator()
        {
            return new StringIterator(this);
        }

        public void ReadFile(string path)
        {
            try
            {
                strings = File.ReadAllLines(path);
            }
            catch
            {
                throw new FileNotFoundException("There's no such file");
            }
        }
    }
}
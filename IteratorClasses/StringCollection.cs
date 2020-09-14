using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace IteratorClasses
{
    class StringCollection:IterableCollection
    {
        private string[] strings;
        public Iterator CreateIterator()
        {
           return new StringIterator(this);
        }

        public bool ReadFile(string path)
        {
            if (File.Exists(path))
            {
                strings = File.ReadAllLines(path);
                return true;
            }
            else
                return false;
        }
    }
}

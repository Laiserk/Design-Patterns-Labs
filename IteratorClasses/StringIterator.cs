using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorClasses
{
    public class  StringIterator : Iterator
    {
       public StringIterator(FileStringCollection strcoll)
        {
            col = strcoll;
        }
        private int current;
        FileStringCollection col;
        public object Next()
        {
            
            object item = null;
            if (current < col.strings.Length)
            {
                item = col.strings[current];
            }
            current++;
            return item;
        }
        public bool HasMore()
        {
            return current <= col.strings.Length;
        }
    
    }
}

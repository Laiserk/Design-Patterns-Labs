using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorClasses
{
    public class  StringIterator : Iterator
    {
       public StringIterator(StringCollection strcoll)
        {
            col = strcoll;
        }
        private int current;
        StringCollection col;
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
        //public  object CurrentItem()
        //{
        //    return col[current];
        //}
    }
}

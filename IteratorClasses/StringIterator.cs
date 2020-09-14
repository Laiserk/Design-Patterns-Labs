using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorClasses
{
    class StringIterator : Iterator
    {
        StringIterator(StringCollection strcoll)
        {
            col = strcoll;
        }
        private int current;
        StringCollection col;
        public object Next()
        {
            current++;
            object item = null;
            if (current < col.Count())
            {
                item = col[current];
            }
            return item;
        }
        public bool HasMore()
        {
            return current >= col.Count();
        }
        //public  object CurrentItem()
        //{
        //    return col[current];
        //}
    }
}

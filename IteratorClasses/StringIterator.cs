using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorClasses
{
    class StringIterator : Iterator
    {
        private int current;
        StringCollection col;
        public  bool Next()
        {
            current++;
            StringCollection item = null;
            if(current < col.Count())
            {
                item = col[current];
            }
            bool isDone = false;
            return isDone;
        }
        //public  object CurrentItem()
        //{
        //    return col[current];
        //}
    }
}

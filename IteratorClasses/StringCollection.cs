using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorClasses
{
    class StringCollection 
    {
        Iterator CreateIterator()
        {
            return (Iterator)new StringIterator(this);
        }
    }
}
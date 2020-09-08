using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorClasses
{
    interface IterableCollection
    {
        Iterator CreateIterator();
    }
}

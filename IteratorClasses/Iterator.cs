using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorClasses
{
    interface Iterator
    {
        bool Next();
        string CurrentItem();
    }
}

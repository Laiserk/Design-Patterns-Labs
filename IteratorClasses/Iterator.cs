using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorClasses
{
    interface Iterator
    {
        object Next();
        bool HasMore();

    }
}

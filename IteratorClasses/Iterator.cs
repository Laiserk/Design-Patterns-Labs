using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorClasses
{
    interface Iterator
    {
        void First();
        void Next();

        bool IsDone();

        string CurrentItem();
    }
}

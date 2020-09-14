using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorClasses
{
    interface Iterator
    {
         object Next();
         object CurrentItem(); // заменить object на другой тип

        bool HasMore();

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorClasses
{
   public interface Iterator
    {
        object Next();
        bool HasMore();

    }
}

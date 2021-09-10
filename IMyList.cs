using System;
using System.Collections.Generic;

namespace deleg2
{
    interface IMyList<T>
    {
        T this[int index] { get; }
        int CountItems { get;}

        void AddItem(T item);
    }

    
}

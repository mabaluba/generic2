using System;
using System.Collections.Generic;

namespace deleg2
{
    public class MyList<T> : IMyList<T>
    {
        private List<T> listItems;

        public MyList() => listItems = new List<T>();// конструктор

        public void AddItem(T item)
        {
            listItems.Add(item);
        }


        public T this[int index] { get { return listItems[index]; } }
        public int CountItems { get { return listItems.Count; } }
    }
    
    
}

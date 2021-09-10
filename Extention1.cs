using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deleg2
{
    public static class ExtentionMethod
    {
        public static T[] GetArray<T>(this MyList<T> list)// копирует существующий лист в новый массив
        {
            var array = new T[list.CountItems];
            for (int i = 0; i < list.CountItems; i++)
            {
                array[i] = list[i];
            }
            return array;
        }

    }
}

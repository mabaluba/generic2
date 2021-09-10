using System;
using System.Collections.Generic;

namespace deleg2
{

    class Program
    {
        static void Main(string[] args)
        {
            var item1 = new MyList<string>();
            item1.AddItem("sdf");
            item1.AddItem("fb");
            item1.AddItem("15");
            for (int i=0;i<item1.CountItems; i++)
            {
                Console.WriteLine(item1[i]);
            }
            Console.WriteLine(item1.CountItems);
            Console.WriteLine(item1[0]);
            Console.WriteLine();
            var array1 = item1.GetArray();
            foreach (var i in array1)
            {
                Console.WriteLine(i);
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic_type__Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> Languages = new SortedList<int, string>();
            Languages.Add(1990, "Python");
            Languages.Add(1002, "C#");
            Languages.Add(1995, "Java");
            foreach (var item in Languages)
            {
                Console.WriteLine($"Created year: {item.Key}, Language:{item.Value}");
            }
            foreach (var item in Languages)
            {
                Languages.((x, y) => string.Compare(x.Value, y.Value));??????????
            }



        }
        

    }
}

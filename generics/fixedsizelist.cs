using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public class fixedsizelist
    {
        public int capasity { get; set; }
        public fixedsizelist(int _capasity)
        {
            capasity = _capasity;
        }
        public void addFixedSizeList<T>(T[] list)
        {
            Console.WriteLine("enter array size");
            int size = int.Parse(Console.ReadLine());

            string message = "you excceded the limit";
            //T[] list = new T[size];
            if (size > capasity)

                throw new Exception(message);

            //for (int i = 0; i < size; i++)
            //{

            //    Console.WriteLine($"enter element{i + 1}");

            //    T x = T.Parse(Console.ReadLine());

            //    list[i] = x;

            //}
            foreach (T item in list) { Console.WriteLine(item); }
        }
    }
}

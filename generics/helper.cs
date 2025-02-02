using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public static class helper<T> where T : IComparable<T>
    {

        public static void swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static void bubblesort(T[] arr)
        {
            if (arr?.Length == 0)
                return;
            bool swapped = true;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) == 1)
                    {
                        swap(ref arr[j], ref arr[j + 1]);
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;
            }


        }

        public static void reversed(T[] arr)
        {
            T[] list = new T[arr.Length];
            int k = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                list[k] = arr[i];

                k++;

            }
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                arr[i] = list[i];

            }
            foreach (T i in arr)
                Console.WriteLine(i);
        }

        public static void even(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }

        }
        public static void even(point[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].x % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }

        }

        public static void repeated(string x)
        {
           
            for (int i = 0; i < x.Length/*11*/; i++)
            {
                bool repeated = false;
                for (int j = 0; j < x.Length/*11*/; j++)/*0<11*/ /*j=10*//*i=7*/
                {
                   if (i == j && j !=x.Length-1) {  j++; } 
                    if (x[j] == x[i] && j != x.Length)
                    {
                        repeated = true;
                        break;
                    }


                }
                if (repeated==false)
                {
                         
                    Console.WriteLine($"{x[i]} is the first not repeated element");
                    return;
                }
              
        }
            
                Console.WriteLine(-1);
        
        }
    }
}

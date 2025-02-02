using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public  class genericrange<T> where T:IComparable<T>
    {

        public T max { get; set; }
        public T min { get; set; }
        public int size { get; set; }
       
        public  T[] arr ;

        public genericrange( T _max, T _min) {
        
                                min = _min;
                                max = _max;
            int size = (dynamic)max - (dynamic)min + 1;// ensure full range is included; 
            arr = new T[size]; 
        }
        public dynamic range() {

                int k=0;
        
            for (int i=(dynamic)min; i<=(dynamic)max;i++)
            {
                arr[k] =(dynamic) i;
                k++;
            }
            foreach (T t in arr)
            {
                Console.WriteLine(t);
            }

            return 1;
                          }        
        public dynamic length() {

            T rangee= (dynamic)max - (dynamic)min;
            Console.WriteLine(rangee);
            return rangee;
                          }

        public bool InRange(T value)
        {
            range();
        
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                    return false;
                if ((dynamic)value.Equals(arr[i]) )
                    return true;

           
            }
            return false;
        }
     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public class point:IComparable<point>
    {
        public int x { get; set; }
        public int y { get; set; }

        public point(int _x,int _y)
        {
            x=_x;
            y=_y;

        }
        public override string ToString()
        {
            return $"{x} ,{y}";
                
                
                }


        int IComparable<point>.CompareTo(point? other)
        {
           if(other == null) return 1;
           if(this.x < other.x) return -1;
            if (this.x > other.x) return 1;
            if(this.x==other.x) return 0;
            return 0;
        }
    }
}

using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Collections;
using System.Security.Cryptography;
using System.Xml.Linq;
using System;
using System.Numerics;

namespace generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            // 1.The Bubble Sort algorithm has a time complexity of O(n ^ 2) in its worst
            //and average cases, which makes it inefficient for large datasets. How we
            //can optimise the Bubble Sort algorithm
            //And implement the code of this optimised bubble sort algorithm

            //int[] numbers = { 5, 6, 7,1, 2, 8, 3, 4 };
            //helper<int>.bubblesort(numbers);
            //foreach (int i in numbers) {Console.Write(i);}
            /////////////////////////swap
            //point p1 = new point(5, 3);
            //point p2 = new point(4, 5);
            //helper<point>.swap(ref p1, ref p2);
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            /////////////////////////bubble
            // point[] points =
            // {
            //     new point(5, 3),
            //     new point(0, 5),
            //     new point(4, 5),
            // };
            //helper<point>.bubblesort(points);
            // foreach (point p in points) {Console.WriteLine(p);}
            #endregion


            #region 2
            //2.create a generic Range < T > class that represents a range of values from a
            //minimum value to a maximum value.The range should support basic
            //operations such as checking if a value is within the range and
            //determining the length of the range.
            //Requirements: 
            //1. Create a generic class named Range<T> where T represents the type
            //of values.
            //2. Implement a constructor that takes the minimum and maximum
            //values to define the range. 
            //3. Implement a method IsInRange(T value) that returns true if the given
            //value is within the range, otherwise false. 
            //4. Implement a method Length() that returns the length of the range
            //(the difference between the maximum and minimum values). 
            //5. Note: You can assume that the type T used in the Range<T> class
            //implements the IComparable<T> interface to allow for comparisons.
            ////////////////////////////////

            //genericrange<int> rangee = new (10,5);
            //rangee.length();
            //Console.WriteLine(rangee.InRange(11));

            #endregion

            #region 3
            //3. You are given an ArrayList containing a sequence of elements. try to
            //reverse the order of elements in the ArrayList in-place(in the same
            //arrayList) without using the built-in Reverse.Implement a function that
            //takes the ArrayList as input and modifies it to have the reversed order of
            //elements.
            //int[] arr = { 10, 4, 3, 8, 9, 10 };
            //helper<int>.reversed(arr); 
            //string[] arr = {"aliaaa","ahmed","soha" };
            // helper<string>.reversed(arr);
            //string[] arr = {"aliaaa","ahmed","soha" };
            // helper<string>.reversed(arr);
            ///////////////////////////////
            //point[] points =
            //{new point(5,6),
            //new point(7,8),
            //new point(9,10),
            //new point(11,12),

            //};
            //helper<point>.reversed(points);
            #endregion

            #region 4
            //4. You are given a list of integers.Your task is to find and return a new list
            //containing only the even numbers from the given list.
            //int[] arr = { 1, 2, 3, 4, 5 ,6,7};
            //helper<int>.even(arr);
            /////////////////
            //point[] points =
            //{new point(2,11),
            //new point(7,8),
            //new point(8,1),
            //new point(11,12),

            //};
            //helper<point>.even(points);
            #endregion

            #region 5
            //5. implement a custom list called FixedSizeList<T> with a predetermined
            //capacity. This list should not allow more elements than its capacity and
            //should provide clear messages if one tries to exceed it or access invalid
            //indices.
            //Requirements: 
            //1. Create a generic class named FixedSizeList<T>.
            //2. Implement a constructor that takes the fixed capacity of the list as a
            //parameter.
            //3.Implement an Add method that adds an element to the list, but
            //throws an exception if the list is already full. 
            //4.Implement a Get method that retrieves an element at a specific index
            //in the list but throws an exception for invalid indices.
            ///////////////////////////////////////
            //fixedsizelist list = new fixedsizelist(10);
            //list.addFixedSizeList<int>();
            #endregion

            #region 6
            //6.Given a string, find the first non - repeated character in it and return its
            //index.If there is no such character, return -1.Hint you can use dictionary
            //string x = "hello hamsa";
            //helper<string>.repeated(x);
            #endregion
        }
    }
}

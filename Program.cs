using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace EnumerableTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enumerable Test :\n");
            enumableTest();
            Console.ReadLine();
        }

        static void enumableTest()
        {
            RandomList t = new RandomList();
            Console.WriteLine("TestList foreach ver:");
            foreach ( double i in t ) {
                Console.WriteLine(i);
            }
            t.Reset();
            Console.WriteLine("");


            Console.WriteLine("TestList GetEnumerator ver:");
            var tor = t.GetEnumerator();
            while ( tor.MoveNext() ) {
                double i  = tor.Current;
                Console.WriteLine(i);
            }
            Console.WriteLine("");


            List<int> list = new List<int>(){1,2,4,3,6,5};
            IEnumerable<int> ie = list;
            
            Console.WriteLine("IEnumerable foreach ver:");            
            foreach ( int i in ie ) {
                Console.WriteLine(i);
            }
            Console.WriteLine("");


            Console.WriteLine("IEnumerable GetEnumerator ver:");
            var e = ie.GetEnumerator();
            while ( e.MoveNext() ) {
                int i  = e.Current;
                Console.WriteLine(i);
            }
            Console.WriteLine("");


            Console.WriteLine("List foreach ver:");
            foreach ( int i in list ) {
                Console.WriteLine(i);
            }
            Console.WriteLine("");


            Console.WriteLine("List for ver:");
            for ( int i = 0 ; i < list.Count ; i++ ) {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("");
        }
    }
}

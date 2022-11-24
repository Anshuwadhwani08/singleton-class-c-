using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counter_with_singleton_class
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = Counter.GetCounter();
            int b = a.Increment;
            Console.WriteLine("incremented value ="+ b);
            int c = a.Decrement;
            Console.WriteLine("decremented value =" + c);
            Console.ReadKey();
            
        }
        public class Counter
        {
            private static readonly Counter instance = new Counter();
            private  int countvalue;
            private Counter()
            {
                countvalue = 10;
            }

            public static Counter GetCounter()
            {
                return instance;
            }
            public int Increment
            {
                get
                {
                    int inc = countvalue;
                    return inc + 1;
                }
            }

            public int Decrement
            {
                get
                {
                    int dec = countvalue;
                    return dec - 1;
                }

            }
        }
    }
}

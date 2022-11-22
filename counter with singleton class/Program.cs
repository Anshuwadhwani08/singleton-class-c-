using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counter_with_singleton_class
{
    internal class Program
    {
        public class Counter
        {
            
            public int count = 8;
            private static readonly Counter instance = new Counter();
            private Counter() { }

            public static Counter getInstance() { return instance; }
            public void  Increment()
            {
                Console.WriteLine("count increment = " + ++count);
                
            }
            public void Decrement()
            {
                Console.WriteLine("count decrement = " + --count);
                
            }
        }
        static void Main(string[] args)
        {
            Counter counter = Counter.getInstance();
            Console.WriteLine(counter.count);
            counter.Increment();
            counter.Decrement();
            Console.ReadLine();
        }
        
    }
}

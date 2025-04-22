using System;
using System.Xml.Linq;
namespace parallelloops
{
    class program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\nusing traditional for loop");
            ////for (int i = 0; i <= 10; i++) {

            ////    Console.WriteLine("i = {0}executed by thread with ID {1}", 1, Thread.CurrentThread.ManagedThreadId);
            ////    Thread.Sleep(100);

            ////}
            //Console.WriteLine("\n using parallel for");
            //Parallel.For(0, 5, i =>
            //{
            //    Console.WriteLine("i={0} executed by thread with id {1}", 5, Thread.CurrentThread.ManagedThreadId);
            //    Thread.Sleep(100);
            //});

            string[] arr = new string[] { "abhi", "ram", "sham", "harry", "raj", "yash" };
            var query = from string name in arr select name;
            Console.WriteLine("NAmes retrived usimh sequential LINQ");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            var plinqQuery = from string name in arr.AsParallel()select name;
            Console.WriteLine("names retrived using PLINQ:");
            foreach(var item in plinqQuery)
            {
                Console.WriteLine(item);
            }
        }
    }

}



       

        
        
    

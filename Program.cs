using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace const_Lab
{
    internal class Program
    {
        public const int MaxValue = 100; // Must be initialized when declared
        public const string Greeting = "Hello, World!";
        static void Main(string[] args)
        {
            Console.WriteLine("MaxValue: " + MaxValue);
            //MaxValue = 10; // Compile error if uncommented. 
            // ❌ Error CS0131: const cannot be assigned
            Console.WriteLine("Greeting: " + Greeting);
            //Greeting = "Hi"; // Compile error if uncommented. 
            // ❌ Error CS0131: const cannot be assigned
            Console.ReadLine();
        }
    }
}

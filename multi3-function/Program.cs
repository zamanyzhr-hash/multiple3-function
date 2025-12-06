using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi3_function
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 3;
            Console.WriteLine("enter number:");
            int n = int.Parse(Console.ReadLine());
            multi3(n, s);
            Console.ReadKey();
        }
        static void multi3(int n, int s)
        {
            if (s >= n)
                return;
            Console.WriteLine(s);
            multi3(n, s + 3);
        }
    }
}

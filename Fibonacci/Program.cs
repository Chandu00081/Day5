using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, num;
            Console.WriteLine("Enter the no of elements");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(n1 + "" + n2 + "");
            for(i=2;i<num;i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + "");
                n1 = n2;
                n2 = n3;
            }
           
           
        }
    }
}

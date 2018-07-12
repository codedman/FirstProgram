using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            float Result;
            Console.Write("\n Enter the value A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter the value B: ");
            B = Convert.ToInt32(Console.ReadLine());
            Result = A + B;
            Console.Write("\n The Answer is: " + Result);
            Console.ReadLine();
        }
    }
}

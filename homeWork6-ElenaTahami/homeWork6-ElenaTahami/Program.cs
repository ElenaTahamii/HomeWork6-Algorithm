using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork6_ElenaTahami
{
    class Program
    {
        public static void Main()
        {
            int n=Convert.ToInt32(Console.ReadLine());
            Fibonacci fibonacci = new Fibonacci();
          Console.WriteLine( fibonacci.Calculate(n));
              
        }


    }

}

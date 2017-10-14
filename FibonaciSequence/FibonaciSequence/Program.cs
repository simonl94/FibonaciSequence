using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonaciSequence
{
    class Program
    {
        static int Main(string[] args)
        {
            int n, i = 0, c;
            Console.WriteLine("Enter the desired number"); //Asks the user for desired input
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci series\n");

            for (c = 1; c <= n; c++)
            {
                int result = FibonacciFunction(i); //Calls the Fibonacci method with logic
                Console.Write(result + " "); //Print Fibonacci sequence
                i++;
            }
            Console.ReadLine();
            return 0;
        }

        public static int FibonacciFunction(int n)
        {
            //Recursive logic
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return (FibonacciFunction(n - 1) + FibonacciFunction(n - 2));
                /*Remember:
                   - Logic is held on the stack, waiting to be done
                   - Logic will follow backwards i.e returns from where it's called from
                   - Should return something even if it's null / void
                   */
            }
        }
    }
}

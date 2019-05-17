using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -7, 1, 5, 2, -4, 3, 0 };
            int n = arr.Length;

            Console.WriteLine("Equilibrium index is " + Equilibrium.EquilibriumIndex(arr, n));
            Console.ReadKey(); 
        }
    }
}

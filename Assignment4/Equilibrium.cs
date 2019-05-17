using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Equilibrium
    {
        public static int EquilibriumIndex(int[] arr, int n)
        {
            int totalSum = 0;
            int leftSum = 0;

            for(int i=0; i<n; i++)
            {
                totalSum += arr[i];
            }

            for(int j=0; j<n; j++)
            {
                totalSum -= arr[j];

                if(leftSum == totalSum)
                {
                    return j;
                }

                leftSum += arr[j];
            }

            return -1;
        }
    }
}

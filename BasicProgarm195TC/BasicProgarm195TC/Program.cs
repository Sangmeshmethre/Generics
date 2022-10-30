using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgarm195TC
{
    public class Progarm
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 4, 5, 6, 7 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
            char[] charArray = { 'S', 'A', 'N', 'G', 'M', 'E', 'S', 'H' };

            new PrintArray<int>(intArray).toPrint();
            new PrintArray<double>(doubleArray).toPrint();
            new PrintArray<char>(charArray).toPrint();
        }
    }
}
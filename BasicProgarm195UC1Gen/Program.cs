using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgarm195UC1Gen
{
    public class Progarm
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArray = { 'S', 'A', 'N', 'G', 'M', 'E', 'S', 'H' };

            Generis.toPrinrt(intArray);
            Generis.toPrinrt(doubleArray);
            Generis.toPrinrt(charArray);
        }
    }
}
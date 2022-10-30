using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicaProgarmTestCaseUC4
{
    public class Progarm
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 112, 252, 585, 666, 857 };
            GanericMaximum<int>ganeric = new GanericMaximum<int>(intArray);
            ganeric.PrintMaxValue();

            double[] doubleArray = { 118.25, 252.24, 585.458, 666.54, 457.457 };
            GanericMaximum<double> ganeric1 = new GanericMaximum<double>(doubleArray);
            ganeric1.PrintMaxValue();

            string[] stringArray = { "S", "A", "N", "G", "M", "E", "S", "H" };
            GanericMaximum<string> ganeric3 = new GanericMaximum<string>(stringArray);
            ganeric3.PrintMaxValue();


        }
    }
}
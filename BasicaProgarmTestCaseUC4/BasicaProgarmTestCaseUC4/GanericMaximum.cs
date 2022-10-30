﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicaProgarmTestCaseUC4
{
    public  class GanericMaximum<T> where T : IComparable
    {
        public T[] value;
        public GanericMaximum(T[] value)
        {
            this.value = value;
        }   
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_value = Sort(value);
            return sorted_value[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum Value is " + max);
        }
    }
}

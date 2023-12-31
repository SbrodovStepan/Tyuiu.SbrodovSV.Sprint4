﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SbrodovSV.Sprint4.Task4.V13.Lib
{
    public class DataService : ISprint4Task4V13
    {
        public int Calculate(int[,] array)
        {
            int sum = 0;
            foreach (var item in array) if (item % 2 == 0) sum += item;
            return sum;
        }
    }
}

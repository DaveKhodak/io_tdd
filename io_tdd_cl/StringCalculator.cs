﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_tdd_cl
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers == "")
                return 0;
            int sum = 0;
            string[] nums = numbers.Split(',');
            foreach(var num in nums)
            {
                sum += int.Parse(num);
            }
            return sum;
        }
    }
}

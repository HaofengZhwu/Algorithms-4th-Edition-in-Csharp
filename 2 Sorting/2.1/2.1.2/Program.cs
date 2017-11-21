﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2
{
    /*
     * 2.1.2
     * 
     * 在选择排序中，一个元素最多可能会被交换多少次？
     * 平均可能会被交换多少次？
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            // 最多 N 次
            // 构造这样一个数列，它由一个有序数列将循环右移一位得到
            // 对这样的数列进行选择排序，第一个元素将被交换 N 次
            // 下面是一个例子：
            // 9 0 1 2 3 4 5 6 7 8
            // 0 9 1 2 3 4 5 6 7 8
            // 0 1 9 2 3 4 5 6 7 8
            // 0 1 2 9 3 4 5 6 7 8
            // 0 1 2 3 9 4 5 6 7 8
            // 0 1 2 3 4 9 5 6 7 8
            // 0 1 2 3 4 5 9 6 7 8
            // 0 1 2 3 4 5 6 9 7 8
            // 0 1 2 3 4 5 6 7 9 8
            // 0 1 2 3 4 5 6 7 8 9
            // 
            // 平均每个元素被交换了 N / N = 1 次
        }
    }
}

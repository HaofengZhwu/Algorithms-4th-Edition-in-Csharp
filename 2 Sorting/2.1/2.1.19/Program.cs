﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._19
{
    /*
     * 2.1.19
     * 
     * 希尔排序的最坏情况。
     * 用 1 到 100 构造一个含有 100 个元素的数组并用希尔排序和
     * 递增序列 1 4 13 40 对其排序，
     * 使比较次数尽可能多。
     * 
     */
    class Program
    {
        // 开放题，没有标准答案
        // 共参考的最差情况为 n^(3/2)
        // 本例共 793 次
        static void Main(string[] args)
        {
            int[] p = new int[5] { 121, 40, 13, 4, 1 };
            int[] b;
            ShellSort sort = new ShellSort();
            b = ShellSortWorstCase.GetWorst(p, 100);
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();
            sort.Sort(b);
        }
    }
}

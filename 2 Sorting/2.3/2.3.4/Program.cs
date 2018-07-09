﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._4
{
    /*
     * 2.3.4
     * 
     * 假如跳过开头打乱数组的操作，给出六个含有 10 个元素的数组，
     * 使得 Quick.sort() 所需的比较次数达到最坏情况。
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            // 每次只让枢轴变为已排序，这就是最坏情况
            // 这种时候枢轴是当前子数组的最大值/最小值
            // 让每个元素都充当一次枢轴，比较次数达到 O(n)
            // 例如：
            // 1 2 3 4 5 6 7 8 9 10
            // 1 1 1 1 1 1 1 1 1 1
            // 10 9 8 7 6 5 4 3 2 1
            // 10 1 9 2 8 3 7 4 6 5
            // 1 10 2 9 3 8 4 7 5 6
            // 1 2 3 4 5 10 9 8 7 6
        }
    }
}
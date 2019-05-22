/*
求众数
给定一个大小为 n 的数组，找到其中的众数。众数是指在数组中出现次数大于 ⌊ n/2 ⌋ 的元素。

你可以假设数组是非空的，并且给定的数组总是存在众数。

示例 1:

输入: [3,2,3]
输出: 3
示例 2:

输入: [2,2,1,1,1,2,2]
输出: 2
 */
using System;
using System.Collections.Generic;

public class Program2
{
    public static void Run()
    {
        Console.WriteLine("Result: " + func(new int[] { 3, 2, 3 }));
        Console.WriteLine("Result: " + func(new int[] { 2, 2, 1, 1, 1, 2, 2 }));
    }

    // Solution 1
    // 通过 Map 的特性
    private static int func(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            int count = 0;
            dict.TryGetValue(num, out count);
            count++;
            dict[num] = count;
        }

        var max = 0;
        var ret = 0;
        foreach (var key in dict.Keys)
        {
            if (dict[key] > max)
            {
                max = dict[key];
                ret = key;
            }
        }
        return ret;
    }
}
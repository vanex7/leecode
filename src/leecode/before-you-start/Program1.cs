/*
给定一个非空整数数组，除了某个元素只出现一次以外，其余每个元素均出现两次。找出那个只出现了一次的元素。

说明：

你的算法应该具有线性时间复杂度。 你可以不使用额外空间来实现吗？

示例 1:

输入: [2,2,1]
输出: 1
示例 2:

输入: [4,1,2,1,2]
输出: 4

引申：
如果每个元素均出现两次呢？
*/
using System;
using System.Collections;
using System.Collections.Generic;

public class Program1
{
    public static void Run()
    {
        // 只出现一次的数字
        Console.WriteLine("result: " + SingleNumber(new int[] { 4, 1, 2, 1, 2 }));
        Console.WriteLine("result: " + SingleNumber(new int[] { 2, 2, 1 }));
        Console.WriteLine("result: " + SingleNumber(new int[] { 1, 0, 1 }));
    }

    // Solution 1
    // 暴力循环
    // 时间复杂度 O(n²)
    // private static int SingleNumber(int[] nums)
    // {
    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         bool hasSame = false;
    //         for (int j = 0; j < nums.Length; j++)
    //         {
    //             if (i != j && nums[i] == nums[j])
    //             {
    //                 hasSame = true;
    //             }
    //         }
    //         if (!hasSame)
    //         {
    //             return nums[i];
    //         }
    //     }
    //     return 0;
    // }

    // Solution 2
    // 利用 Hash 表
    // 时间复杂度 O(n) 空间复杂度  O(n)
    // private static int SingleNumber(int[] nums)
    // {
    //     var dict = new Dictionary<int, int>();
    //     foreach (var num in nums)
    //     {
    //         int count = 0;
    //         dict.TryGetValue(num, out count);
    //         dict[num] = count + 1;
    //     }

    //     // foreach (var key in dict.Keys)
    //     // {
    //     //     Console.Write("{0}:{1}\t", key, dict[key]);
    //     // }
    //     // Console.WriteLine();

    //     foreach (var key in dict.Keys)
    //     {
    //         if (dict[key] == 1)
    //             return key;
    //     }
    //     return 0;
    // }


    /*
        Solution 3
        以上都不满足题目的要求， 要求是 O(n) 且无额外空间
        利用异或结果来达到目的：
            2 ^ 2 = 0
            0 ^ 3 = 3
            4 ^ 1 ^ 2 ^ 1 ^ 2 = 2 ^ 2 ^ 1 ^ 1 ^ 4 = 0 ^ 4 = 4
     */
    private static int SingleNumber(int[] nums)
    {
        int retValue = nums[0];
        if (nums.Length == 1)
            return retValue;

        for (int i = 1; i < nums.Length; i++)
        {
            retValue ^= nums[i];
        }
        return retValue;
    }
}
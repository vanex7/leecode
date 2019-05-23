/*
 搜索二维矩阵 II
编写一个高效的算法来搜索 m x n 矩阵 matrix 中的一个目标值 target。该矩阵具有以下特性：

每行的元素从左到右升序排列。
每列的元素从上到下升序排列。
示例:

现有矩阵 matrix 如下：

[
  [1,   4,  7, 11, 15],
  [2,   5,  8, 12, 19],
  [3,   6,  9, 16, 22],
  [10, 13, 14, 17, 24],
  [18, 21, 23, 26, 30]
]
 */
using System;

public class Program3
{
    public static void Run()
    {
        // Console.WriteLine("Result: " + func(new int[,] {
        //         {1, 4, 7, 11, 15},
        //         {2, 5, 8, 12, 19},
        //         {3, 6, 9, 16, 22},
        //         {10, 13, 14, 17, 24},
        //         {18, 21, 23, 26, 30}
        //     },
        //     5));

        // Console.WriteLine("Result: " + func(new int[,] {
        //         {-5}
        //     },
        // -5));

        // Console.WriteLine("Result: " + func(new int[,] {
        //         {-1, 3}
        //     },
        // 3));

        // Console.WriteLine("Result: " + func(new int[,] {
        //         {1, 4},
        //         {2, 5}
        //     },
        // 5));

        Console.WriteLine("Result: " + func(new int[,] {
                {  1,  2,  3,  4,  5},
                {  6,  7,  8,  9, 10},
                { 11, 12, 13, 14, 15},
                { 16, 17, 18, 19, 20},
                { 21, 22, 23, 24, 25}
            },
        25));
    }

    /*
         Solution 1
         从左上角找到右下角
     */
    private static bool func(int[,] matrix, int target)
    {
        /*
            [0, 0]

            [1, 0]
            [0, 1]

            [2, 0]
            [1, 1]
            [0, 2]

            [3, 0]
            [2, 1]
            [1, 2]
            [0, 3]

            --> 4
            --> 5
         */
        // var len1 = matrix.GetLength(0);
        // var len2 = matrix.GetLength(1);
        // var forLen = len1 > len2 ? len1 : len2;
        // forLen = 2 * forLen - 1;
        // System.Console.WriteLine("len1:{0}, len2：{1}, forLen:{2}", len1, len2, forLen);
        // for (int i = 0; i <= forLen; i++)
        // {
        //     for (int j = 0; j <= i; j++)
        //     {
        //         var x = j;
        //         var y = i - j;
        //         if (x >= len1 || y >= len2)
        //         {
        //             Console.WriteLine("continue on [{0}, {1}]", x, y);
        //             continue;
        //         }
        //         var v = matrix[x, y];
        //         Console.WriteLine("[{0}, {1}] {2}{3}{4}", x, y, v, v == target ? "==" : "!=", target);
        //         if (v == target)
        //             return true;
        //     }
        //     System.Console.WriteLine();
        // }
        // return false;

        var len1 = matrix.GetLength(0);
        var len2 = matrix.GetLength(1);


        for (int i = 0; i < len1; i++)
        {
            for (int j = 0; j < len2; j++)
            {
                if (matrix[i, j] == target)
                    return true;
                else if (matrix[i, j] > target)
                    break;
            }
        }
        return false;
    }
}
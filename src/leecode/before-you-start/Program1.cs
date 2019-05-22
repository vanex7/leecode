using System;
public class Program1
{
    public static void Run()
    {
        // 只出现一次的数字
        Console.WriteLine(SingleNumber(new int[] { 4, 1, 2, 1, 2 }));
        Console.WriteLine(SingleNumber(new int[] { 2, 2, 1 }));
        Console.WriteLine(SingleNumber(new int[] { 1, 0, 1 }));
    }

    private static int SingleNumber(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                
            }
        }
        return default;
    }
}
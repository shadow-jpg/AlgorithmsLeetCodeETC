using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {

        int[] data = new int[10] { 1, 2, 3, 5, 7, 8, 10, 12, 10, 2 };
        int res = MissingNumber(data);
        Console.Write($"{res}");
    }
    public static int MissingNumber(int[] nums)
    {
        HashSet<int> data = new(nums.Length);
        for(int i=0; i < nums.Length; i++)
            data.Add(nums[i]);

        for(int i = 0; i < nums.Length; i++)
        {
            if (!data.Contains(i + 1))
                return i + 1;
        }
        if (nums.Length == 1)
            if (nums[0] == 1)
                return 0;
            else
                return -1;

        return 0;
    }
}
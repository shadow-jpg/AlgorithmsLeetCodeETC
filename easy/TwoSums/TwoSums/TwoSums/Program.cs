public class Solution
{
    public static void Main()
    {
        int[] data = new int[10] { 1, 2, 1, 5, 7, 8, 10, 12, 10, 2 };
        data = TwoSum(data,14);
        Console.Write($"[{data[0]},{data[1]}]"); 

    }
    public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> res = new(nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                    if (!res.ContainsKey(target - nums[i]))
                    {
                        if (!res.ContainsKey(nums[i]))
                            res[nums[i]] = i;
                    }
                    else
                        return [res[target - nums[i]], i];
            }
            return new int[] { };
        }
}
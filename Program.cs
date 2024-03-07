namespace TwoSum
{
    using System;

    public class Pog
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numMap.ContainsKey(complement))
                {
                    return new int[] { numMap[complement], i };
                }
                numMap[nums[i]] = i;
            }

            throw new ArgumentException("No two sum solution");
        }
    }

    public class Prog
    {
        public static void Main()
        {
            Pog pog = new Pog();

           
            Console.WriteLine("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element at index {i}: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            Console.WriteLine("Enter the target sum:");
            int target = Convert.ToInt32(Console.ReadLine());

            try
            {
                int[] result = pog.TwoSum(nums, target);
                Console.WriteLine($"Output: [{result[0]}, {result[1]}]");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

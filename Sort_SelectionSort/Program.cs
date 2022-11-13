namespace Sort_SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, -2, 12, 9, 20, 17, 2, -8, 11, 7 };

            // display result
            string arrString = "";
            var sorted = SelectionSortForNum(nums);
            foreach (var item in sorted)
            {
                arrString = arrString + item.ToString() + ", ";
            }

            Console.WriteLine(arrString);
        }

        private static int[] SelectionSortForNum(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                var minIndex = i;
                for(int j = i+1; j < nums.Length; j++)
                {
                    if(nums[j] < nums[minIndex])
                    {
                        // Record new min index
                        minIndex = j;
                    }

                    if(j == nums.Length - 1 && minIndex != i)
                    {
                        // Swap
                        var temp = nums[i];
                        nums[i] = nums[minIndex];
                        nums[minIndex] = temp;
                    }
                }
            }
            return nums;
        }
    }
}
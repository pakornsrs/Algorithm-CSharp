namespace Sort_BubbleSort
{
    public class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, -2, 12, 9, 20, 17, 2, -8, 11, 7 };

            // display result
            string arrString = "";
            var sorted = BubbleSortForNum(nums);
            foreach (var item in sorted)
            {
                arrString = arrString + item.ToString() + ", ";
            }

            Console.WriteLine(arrString);
        }

        private static int[] BubbleSortForNum(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                bool Swapped = false;
                for(int j = 0; j < nums.Length - 1; j++)
                {
                    if(nums[j] > nums[j + 1])
                    {
                        // Swap
                        var temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;

                        Swapped = true;
                    }
                }

                if(Swapped == false)
                {
                    break;
                }
            }

            return nums;
        }

    }
}
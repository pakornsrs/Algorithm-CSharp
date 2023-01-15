using System.Globalization;

namespace Sort_SelectionSort
{
    internal class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, -3, 4, 1, 2 };

            Console.WriteLine(ConvertArrToString(nums));

            // display result
            var sorted = SelectionSortForNum(nums);

            Console.WriteLine(ConvertArrToString(sorted));
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

                    Console.WriteLine(ConvertArrToString(nums));
                }
            }
            return nums;
        }

        private static string ConvertArrToString(int[] input)
        {
            string arrString = "";

            foreach (var item in input)
            {
                arrString = arrString + item.ToString() + ", ";
            }

            return arrString;
        }
    }
}
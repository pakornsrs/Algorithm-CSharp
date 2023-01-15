namespace Sort_InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 6, 7, -3, 9, 1, 2 };

            // display problem array
            Console.WriteLine(ConvertArrToString(nums));

            var sorted = InsertionSortForNum(nums);

            // display result
            Console.WriteLine(ConvertArrToString(sorted));
        }

        private static int[] InsertionSortForNum(int[] nums)
        {
            for(int i = 1; i < nums.Length; i++)
            {
                var currentVal = nums[i];

                for (int j = i-1; j >= 0; j--)
                {
                    if (currentVal > nums[j]) break;

                    nums[j+1] = nums[j];
                    nums[j] = currentVal;

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
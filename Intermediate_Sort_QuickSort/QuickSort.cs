namespace Intermediate_Sort_QuickSort
{
    internal class QuickSort
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 4, 2, 8, -16, 3, 71, -2, 19, 25, 23 };
            Console.WriteLine(ConvertArrToString(nums));

            var result = QuickSortForNum(nums,0, nums.Length);
            Console.WriteLine(ConvertArrToString(result));
        }

        private static int[] QuickSortForNum(int[] nums, int left, int right)
        {
            if (left < right)
            {
                var pivotIndex = PivotArr(nums, left);

                // Left
                nums = QuickSortForNum(nums, left, pivotIndex - 1);
                // Right
                nums = QuickSortForNum(nums, pivotIndex + 1, nums.Length);
            }

            return nums;
        }

        private static int PivotArr(int[] nums, int startIndex)
        {
            int pivot = nums[startIndex];
            int swapIndex = startIndex;

            for (int i = startIndex + 1; i < nums.Length; i++)
            {
                if (nums[i] < pivot)
                {
                    swapIndex++;
                    nums = SwapArrIndex(nums, i, swapIndex);
                }
            }

            nums = SwapArrIndex(nums, startIndex, swapIndex);

            return swapIndex;
        }

        private static int[] SwapArrIndex(int[] nums, int index1, int indx2)
        {
            var temp = nums[index1];
            nums[index1] = nums[indx2];
            nums[indx2] = temp;

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
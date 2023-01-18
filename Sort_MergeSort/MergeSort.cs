using System;

namespace Sort_MergeSort
{
    internal class MergeSort
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 4, 2, 8, -16, 3, 71, -2, 19, 25, 23 };

            var result = MergeSortForNum(nums);
            Console.WriteLine(ConvertArrToString(result));
        }

        private static int[] MergeSortForNum(int[] nums)
        {
            if (nums.Length <= 1) return nums;

            var left = nums.Take(nums.Length / 2).ToArray();
            var splitLeft = MergeSortForNum(left);

            var right = nums.Skip(nums.Length / 2).ToArray();
            var splitRight = MergeSortForNum(right);

            return MergeArray(splitLeft, splitRight);
        }

        private static int[] MergeArray(int[] numArr1, int[] numArr2)
        {
            List<int> result = new List<int>();

            int i = 0; int j = 0;

            while(i < numArr1.Length && j < numArr2.Length)
            {
                if(numArr1[i] < numArr2[j])
                {
                    result.Add(numArr1[i]);
                    i++;
                }
                else{
                    result.Add(numArr2[j]);   
                    j++;
                }
            }
            while(i < numArr1.Length)
            {
                result.Add(numArr1[i]);
                i++;
            }
            while (j < numArr2.Length)
            {
                result.Add(numArr2[j]);
                j++;
            }

            return result.ToArray();
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
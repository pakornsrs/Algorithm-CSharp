using System;

namespace Intermediate_Sort_RadixSort
{
    internal class RadixSort
    {
        static void Main(string[] args)
        {
            int[] nums = { -180 ,245521, 16, 177, -320, 912, 1541, 21452, 11, 158468 };
            //int[] nums = { 1, 4, 2, 8, -16, 3, 71, -2, 19, 25, 23 };
            Console.WriteLine("Array : " + ConvertArrToString(nums));

            var sorted = RadixSortForNum(nums);
            Console.WriteLine("\nSorted array : " + ConvertArrToString(sorted));

        }

        private static int[] RadixSortForNum(int[] nums)
        {
            // 1 Identify max length of num in array
            // 2 The outer loop is increased from k = 0 to k < max length
            // 3 Implement the bucket (list of list int) seperate by 0-9
            // 3.1 To modify Radix sort for negative value a another bucket for negative number
            // 4 Implement inner loop for filling num in input array to bucket
            // 5 In the inner loop get the k-position digit of num
            // 6 Filling digit in (5) to the bucket (seperate bucket for negative and positive)
            // 7 Re-processing until k is reached to max length !

            var MaxLength = GetMaxLength(nums);

            for (int k = 0; k < MaxLength; k++)
            {
                var PositiveBuckets = CreateBuckets();
                var NegativeBuckets = CreateBuckets();

                for (int j = 0; j < nums.Length; j++)
                {
                    var digit = GetDigitByPosition(nums[j], k);
                    
                    if(digit >= 0)
                    {
                        PositiveBuckets[digit].Add(nums[j]);
                    }
                    else
                    {
                        digit = Math.Abs(digit);
                        NegativeBuckets[digit].Add(nums[j]);
                    }
                }

                //PrintBacket(NegativeBuckets);
                //PrintBacket(PositiveBuckets);

                var sorted = new List<int>();

                for (int i = NegativeBuckets.Count - 1; i > 0; i--)
                {
                    sorted.AddRange(NegativeBuckets[i]);
                }

                for (int i = 0; i < PositiveBuckets.Count; i++)
                {
                    sorted.AddRange(PositiveBuckets[i]);
                }

                nums = sorted.ToArray();
            }

            return nums;
        }

        private static int GetMaxLength(int[] nums)
        {
            int max = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                var value = Math.Floor(Math.Log10(Math.Abs(nums[i]))) + 1;
                if(value > max)
                {
                    max = Convert.ToInt32(value);
                }
            }

            return max;
        }

        private static int GetDigitByPosition(double num, int position)
        {
            if(num < 0)
            {
                return Convert.ToInt32(Math.Ceiling((num / Math.Pow(10, position))) % 10);
            }
            else
            {
                return Convert.ToInt32(Math.Floor((num / Math.Pow(10, position))) % 10);
            }
        }

        private static List<List<int>> CreateBuckets()
        {
            var Buckets = new List<List<int>>();
            for(int i = 0; i < 10; i++)
            {
                Buckets.Add(new List<int>());
            }
            return Buckets;
        }

        private static void PrintBacket(List<List<int>> Breaket)
        {
            int i = 0;
            foreach(var item in Breaket)
            {
                Console.Write(i.ToString() + " : ");
                foreach(var item2 in item)
                {
                    Console.Write(" " + item2.ToString());
                }
                i++;
                Console.WriteLine("");
            }
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
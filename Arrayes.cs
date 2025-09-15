using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace problem_solving_using_c_
{
    public static class Arrayes
    {
        //find max and minimum element in array 
        public static void FindMinMax(int[] num)
        {
            int min = num[0];
            int max = num[0];
            foreach (int n in num)
            {
                if (n < min) min = n;
                if (n > max) max = n;
            }
            // sort 
            // for (int j = 0; j < num.Length; j++)
            // {
            //     for (int i = 1; i < num.Length; i++)
            //     {
            //         if (num[i] < num[i - 1])
            //         {
            //             int temp = num[i];
            //             num[i] = num[i - 1];
            //             num[i - 1] = temp;
            //         }
            //     }
            // }
            // min = num[0];
            // max = num[num.Length - 1];
            Console.WriteLine(min);
            Console.WriteLine(max);


        }

        // reverse array
        public static void ReverseArr(int[] num)
        {
            int left = 0;
            int right = num.Length - 1;
            while (left < right)
            {
                int temp = num[left];
                num[left] = num[right];
                num[right] = temp;
                left++;
                right--;
            }
            foreach (int n in num)
            {
                Console.WriteLine(n);

            }
        }

        //  Find the second largest element in an array
        public static void Secondlarge(int[] num)
        {
            int frist = int.MinValue, second = int.MinValue;
            foreach (int n in num)
            {
                if (n > frist)
                {
                    second = frist;
                    frist = n;
                }
                else if (n > second && n != frist)
                {
                    second = n;
                }
            }
            Console.WriteLine(second);

        }

        //4️⃣ Move all zeros to the end of an array
        public static void MoveZero(int[] num)
        {
            int index = 0;
            foreach (int n in num)
            {
                if (n != 0)
                {
                    num[index++] = n;
                }
            }
            while (index < num.Length)
            {
                num[index++] = 0;

            }
            foreach (int n in num)
            {
                Console.WriteLine(n);
            }
        }

        // 5️⃣ Find missing number in a sequence (1 to n)
        public static int MissingNumber(int[] num)
        {
            int n = num.Length + 1;
            int total = n * (n + 2) / 2;
            int sum = 0;
            foreach (int number in num)
            {
                sum += number;

            }
            return total - sum;
        }

        // 6️⃣ Find duplicate elements in an array
        public static void Duplicates(int[] num)
        {
            HashSet<int> seen = new HashSet<int>();
            HashSet<int> duplicate = new HashSet<int>();
            foreach (int n in num)
            {
                if (seen.Contains(n))
                {
                    duplicate.Add(n);
                }
                else
                {
                    seen.Add(n);
                }
            }
            Console.WriteLine(string.Join(" , ", duplicate));
        }
        // 7️⃣ Rotate an array by k steps
        public static void Rotate(int[] num, int k)
        {
            k = k % num.Length;
            // Array.Reverse(num, 0, num.Length);
            // Array.Reverse(num, 0, k);
            Array.Reverse(num, k, num.Length - k);
            foreach (int n in num)
            {
                System.Console.WriteLine(n);
            }
        }
        //8️⃣ Find pairs with given sum in array
        public static void FindPairs(int[] num, int target)
        {
            HashSet<int> seen = new HashSet<int>();
            foreach (int n in num)
            {
                int complement = target - n;
                if (seen.Contains(complement))
                {
                    System.Console.WriteLine($"{n} {complement}");
                }
                seen.Add(n);
            }
        }



    }
}
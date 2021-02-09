using System;
using System.Linq;
namespace Convertor
{

    class Program
    {
        const int smallPosition = 96;
        const int bigPosition = 64;
        static char[] consts = { 'a', 'e', 'i', 'd', 'h', 'j' };
        public static char ConvertToChar(int value)
        {
            char result = Convert.ToChar(value + smallPosition);
            if (consts.Contains(result))
            {
                return Convert.ToChar(value + bigPosition);
            }
            return result;
        }
        static void Main(string[] args)
        {
            int i, j, k;
            int arraysize;
            Console.WriteLine("Enter size of array: ");
            int.TryParse(Console.ReadLine(), out arraysize);
            int[] nums = new int[arraysize];
            char[] arr1 = new char[arraysize];
            char[] arr2 = new char[arraysize];
            var rand = new Random();
            for (int x = 0; x < arraysize; x++)
            {
                nums[x] = rand.Next(1, 26);
            }
            for (i = 0, j = 0, k = 0; i < arraysize; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    arr1[j] = ConvertToChar(nums[i]);
                    j++;
                }
                else
                {
                    arr2[j] = ConvertToChar(nums[i]);
                    k++;
                }

            }
            string result1 = string.Join(" ", arr1);
            string result2 = string.Join(" ", arr2);
            int upper1 = result1.Where(x => Char.IsUpper(x)).Count();
            int upper2 = result2.Where(x => Char.IsUpper(x)).Count();
            if (upper1 > upper2)
            {
                Console.WriteLine("arr1 has more uppercase characters by: " + (upper1 - upper2));
            }
            else if (upper2 > upper1)
            {
                Console.WriteLine("arr2 has more uppercase characters by: " + (upper2 - upper1));
            }
            else
            {
                Console.WriteLine("uppercase in arr1 and arr2 are equal");
            }
            Console.WriteLine(result1);
            Console.WriteLine("\n*********************************************************\n");
            Console.WriteLine(result2);
        }
    }
}

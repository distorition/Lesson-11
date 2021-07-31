using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonn_11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[] { random.Next(1, 1000) };
            
            Console.WriteLine(BinataySearch(arr,16));
        }

        public static int BinataySearch(int[]arr, int searchIndex)
        {
            int min = 0;
            int max = arr.Length - 1;
            while(min<=max)
            {
                int mid = (min + max) / 2;
                if(searchIndex==arr[mid])
                {
                    return mid;
                }
                if (searchIndex < arr[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SumOf2NumbersToK
    {
        public static bool Sum(int[] arr, int k)
        {
            if (arr.Length == 0 || arr.Length==1) return false;
            else
            { 
                for(int i = 0; i < arr.Length; i++)
                {
                    if (arr.Contains(k - arr[i]))
                        return true;
                }
                
            }
            return false;
        }
        //public static void Main()
        //{
        //    int[] arr = { 10, 15, 3, 9 };
        //    SumOf2NumbersToK.Sum(arr, 17);
        //}
    }
}

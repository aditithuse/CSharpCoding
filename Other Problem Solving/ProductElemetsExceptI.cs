using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ProductElemetsExceptI
    {
        public static void Main()
        {
            ProductElemetsExceptI.Product(new int[] { 1, 2, 3, 4, 5 });
        }

        public static int[] Product(int[] arr)
        {
            int len = arr.Length;
            int[] final = new int[arr.Length];

            int[] product_Left = new int[len];
            int[] product_Right = new int[len];

            product_Left[0] = 1;
            product_Right[len - 1] = 1;

            for(int i = 1; i < len; i++)
            {
                product_Left[i] = product_Left[i - 1] * arr[i - 1];
            }

            for (int i = len-2; i >=0; i--)
            {
                product_Right[i] = product_Right[i + 1] * arr[i + 1];
            }

            for(int i = 0; i < len; i++)
            {
                final[i] = product_Left[i] * product_Right[i];
            }

            return final;

        }
    }
}

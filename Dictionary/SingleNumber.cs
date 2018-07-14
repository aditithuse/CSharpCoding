/*Given a non-empty array of integers, every element appears twice except for one. Find that single one.*/

 using System.Collections.Generic;
using System.Linq;

public class SingleNumber   
{
    public static int FindSingleNumber(int[] nums)
    {
        Dictionary<int, int> di = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (di.ContainsKey(nums[i]))
                di[nums[i]] += 1;
            else
                di.Add(nums[i], 1);
        }

        var myKey = di.FirstOrDefault(x => x.Value == 1).Key;

        return myKey;

    }

}

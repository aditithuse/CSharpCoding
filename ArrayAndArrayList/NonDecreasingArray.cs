public class Solution {

    public bool CheckPossibility(int[] nums)
    {
        if (nums.Length  <= 2) return true;
        bool changed = false;
        if (nums[1] < nums[0])
            changed = true;
        
        for (int i = 2; i < nums.Length; i++)
        {
            if ((nums[i] < nums[i - 1]))
            {

                if (!changed)
                {
                    changed = true; 

                    if (nums[i] < nums[i - 2]) 
                        nums[i] = nums[i - 1];
                }
                else
                    return false;
            }
         }
        return true;

    }
    
}

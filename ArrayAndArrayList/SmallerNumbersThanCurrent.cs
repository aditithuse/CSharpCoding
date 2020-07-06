public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] finalArray = new int[nums.Length];
             
        for(int i=0;i<nums.Length;i++){
            for(int j=0;j<nums.Length;j++){
                if(j!=i && nums[i]>nums[j]){
                    finalArray[i]+=1;
                }
            }
        }
        return finalArray;
    }
}

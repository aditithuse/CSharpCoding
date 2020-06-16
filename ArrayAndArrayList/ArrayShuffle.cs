public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] arr = new int[nums.Length];
        int index = 0;
        for(int i = 0; i < n; i++){
            arr[index] = nums[i];
            index++;
            arr[index] = nums[i+n];
            index++; 
        }
        return arr;
    }
}

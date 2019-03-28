public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i=0;
        int j = numbers.Length-1;
        int sum=0;
        
        while(i<j){
            sum = numbers[i]+numbers[j];
            if(sum<target)   i++;
            else if(sum>target)  j--;
            else return new int[]{i+1,j+1};
        }
        return null;
    }
}

public class Solution {
    public int XorOperation(int n, int start) {
        int[] nums=new int[n];
        nums[0]=start+2*0;
        int xor=nums[0];
        
        for(int i=1;i<n;i++){
            nums[i]=start+2*i;
            xor=nums[i]^xor;
            
        }
        
       
        
        return xor;
    }
}

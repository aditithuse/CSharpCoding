public class Solution {
    public int XorOperation(int n, int start) {
        int xor=start;
        
        for(int i=1;i<n;i++){
            xor^=(start+2*i);
            
        }
        return xor;
    }
}

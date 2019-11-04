public class Solution {
    public int[] CountBits(int num) {
        int[] final = new int[num+1];
        
        
        for(int i = 0 ; i <= num ; i++){
            string binary = Convert.ToString(i, 2);

            int count = binary.Count(f => f == '1');
            
            final[i] = count;
        }
        
        return final;
        
    }
}

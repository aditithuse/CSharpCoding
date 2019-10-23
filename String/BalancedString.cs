public class Solution {
    public int BalancedStringSplit(string s) {
        
        int rCount = 0;
        int lCount = 0;
        int balanceCount = 0;
        
        for(int i = 0; i < s.Length ; i++){
            
            if(s[i]=='R')
                rCount ++;
            
            else
                lCount ++;
            
            if(rCount == lCount){
                balanceCount ++;
                rCount ++;
                lCount ++;
            }
                
        }
        return balanceCount;
    }
}

public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        
        IList<int> final = new List<int>();
        
        for(int i = left ; i <= right ; i++){
            if(Verify(i))
                final.Add(i);
        }
        return final;
    }
    
    public bool Verify(int n){
        string number=n.ToString();
        
        for(int j = 0 ; j < number.Length ; j++){
            int num = int.Parse(number[j].ToString());
            
            if(num == 0)
                return false;
            
            if(n%num != 0)
                return false;
        }
        
        return true;
        
    }
}

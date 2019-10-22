public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        
        IList<IList<int>> result = new List<IList<int>>(numRows);
        
        for(int i = 1 ; i <= numRows ; i++){
            IList<int> row = new List<int>(new int[i]);
            result.Add(row);
            
            for(int j = 0 ; j < i ; j++){
                
                if(j==0 || j==i-1){
                    row[j] = 1;
                }
                else{
                    row[j] = result[i-2][j-1]+result[i-2][j];
                }
            }
        }
        return result;
    }
}

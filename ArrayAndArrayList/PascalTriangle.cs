public class Solution {
    public IList<int> GetRow(int rowIndex) {
       int[] res = new int[]{1};
        for(int loop=0;loop<rowIndex;loop++)
            res = GetTriangle(res);
        
        IList<int> final = res.OfType<int>().ToList(); 
        return final;
    }
    
    
    private int[] GetTriangle(int[] result){
        int[] arr = new int[result.Length+1];
        arr[0] = result[0];;
        arr[arr.Length-1]=result[result.Length-1];
        
        int i=0;
        int k=1;
        while(i<result.Length-1){
            int sum = result[i]+result[i+1];
            arr[k++]=sum;
            i++;
        }
        
        return arr;
    }
}

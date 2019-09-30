public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        
        Dictionary<int,int> result = new Dictionary<int,int>();
        
        for(int i = 0 ; i < arr.Length ; i++ ){
            if(result.ContainsKey(arr[i]))
                result[arr[i]]++;
            
            else
                result.Add(arr[i],1);
            
        }
        
        var duplicateValues = result.GroupBy(x => x.Value).Where(x => x.Count() > 1);
            
        foreach(var item in duplicateValues)  

            return false;

            
        return true;
    }
}

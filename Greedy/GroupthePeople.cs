public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        
        IList<IList<int>> finalList = new List<IList<int>>();
        
        Dictionary<int, List<int>> finalDictionary = new Dictionary<int, List<int>>();
        
        for(int i=0;i<groupSizes.Length;i++){
            if(finalDictionary.ContainsKey(groupSizes[i])){
                finalDictionary[groupSizes[i]].Add(i);
            }
            else{
                finalDictionary.Add(groupSizes[i], new List<int>() {i});
            }
        }
        
        foreach(var item in finalDictionary){
            IList<int> smallList = new List<int>();
            
            foreach(var smallItem in item.Value){
                if(smallList.Count < item.Key)
                    smallList.Add(smallItem);
                
                if(smallList.Count==item.Key){
                    finalList.Add(smallList);
                    smallList = new List<int>();
                }
                
            }
            
        }
        
        
        return finalList;
        
        
    }
}

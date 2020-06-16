public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        IList<bool> finalList = new List<bool>();
        
        for(int i=0;i<candies.Length;i++){
            int candiesExtra=candies[i]+extraCandies;
            var max = candies.Select((n, i) => (Number: n, Index: i)).Max();
            
            if(candiesExtra >= max.Number)
                finalList.Add(true);
            else
                finalList.Add(false);
            
        }
        
        
        return finalList;
        
    }
}

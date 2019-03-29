public class Solution {
    public int[] SortedSquares(int[] A) {
        int[] result = new int[A.Length];
        for(int i=0;i<A.Length;i++)
            result[i]=A[i]*A[i];
        
        Array.Sort(result);
        return result;
    }
}

public class Solution {
    public bool RotateString(string A, string B) {
        
        if(A.Length!=B.Length) return false;
        return (A+A).Contains(B);
    }
}

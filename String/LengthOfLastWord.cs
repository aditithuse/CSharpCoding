
public class Solution {
    public int LengthOfLastWord(string s) {
        s=s.TrimEnd();
        if(s=="")
            return 0;
        string[] words = s.Split(' ');
        return words[words.Length-1].Length;
    }
}

public class Solution {
    public string ReverseWords(string s) {
        string[] words = s.Split(' ');
        string finalString="";
        
        for(int i=0; i < words.Length ; i++){
            finalString += " "+ReverseString(words[i]);
        }
        
        return finalString.Trim();
    }
    
    public string ReverseString(string s)
    {
        char[] array = s.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }

}

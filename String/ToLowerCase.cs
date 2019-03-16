public class Solution {
    public string ToLowerCase(string str) {
        
        string strNew = "";
        
        for(int i=0;i<str.Length;i++){
            if((int)str[i]>=65 && (int)str[i]<=90)
                strNew += (char)((int)str[i]+32);
            else strNew += (char)str[i];
        }
        
        return strNew;
         
    }
}

public class Solution {
    public int NumUniqueEmails(string[] emails) {
        
        List<string> final = new List<string>();
        int len = emails.Length;
        
        for(int i=0;i<len;i++){
            string[] str= emails[i].Split('@');
            str[0] = str[0].Replace(".","");
            int indexOfPlus =  str[0].IndexOf('+');
            if(indexOfPlus!=-1)
                str[0]=str[0].Remove(indexOfPlus);
            
            string finalString = str[0]+"@"+str[1];
            
            if(!final.Contains(finalString)){
                final.Add(finalString);
            }
            
            
        }
       return(final.Count);
    }
}

public class Solution {
    public IList<string> FindAndReplacePattern(string[] words, string pattern) {
        int len = words.Length;
        IList<string> final = new List<string>();
        
        for(int i=0;i<len;i++){
            if(IsMatch(words[i], pattern))
               final.Add(words[i]) ;
        }
        
        return final;
    }
    
    public bool IsMatch(string word, string pattern){
        Dictionary<char,char> map1 = new Dictionary<char,char>();
        Dictionary<char,char> map2 = new Dictionary<char,char>();
        
        for(int i=0;i<word.Length;i++){
            char w=word[i];
            char p=pattern[i];
            
            if(!map1.ContainsKey(w))
                map1.Add(w,p);
            if(!map2.ContainsKey(p))
                map2.Add(p,w);
            
            if(map1[w]!=p || map2[p]!=w)
                return false;
            
        }
        return true;
        
    }
}

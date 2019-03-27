public class Solution {
    public int CalPoints(string[] ops) {
        int sum = 0;
        Stack<int> res = new Stack<int>();
        
        for(int i=0;i<ops.Length;i++){
         
            int number;
            bool success = Int32.TryParse(ops[i], out number);
            
            if(success==true){
                res.Push(number);
                sum+=number;    
            }
            
            else if(ops[i]=="C"){
                sum-=res.Pop();
            }
            
            else if(ops[i]=="+"){
                int numUp = res.Pop();
                int roundPlus=numUp+res.Peek();
                sum+=roundPlus;
                res.Push(numUp);
                res.Push(roundPlus);
            }
            else if(ops[i]=="D"){
                int num = res.Peek();
                sum+=(num*2);
                res.Push(num*2);
            }
        }
        return sum;
    }
}

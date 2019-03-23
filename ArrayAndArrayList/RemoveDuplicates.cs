public class Solution {
    public int RemoveDuplicates(int[] arr) {
        
        if(arr.Length==0) return 0;
        int j = 0;

        for (int i = 1; i < arr.Length; i++)
        {

            if (arr[i] != arr[j])
            {
                j++;
                arr[j] = arr[i];
            }   

        }
        return j + 1;
    }
}

public class Solution {
    public IList<int> LuckyNumbers (int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int[] rows=new int[m];
        int[] cols=new int[n];
        IList<int> finalList = new List<int>();
                
        for(int i=0;i<m;i++){
            var minInRow=matrix[i][0];
            for(int j=0;j<n;j++){
                if(matrix[i][j]<minInRow){
                    minInRow=matrix[i][j];
                }
                rows[i]=minInRow;
            }
        }
        
        for(int i=0;i<n;i++){
            var minInCol=matrix[0][i];
            for(int j=0;j<m;j++){
                if(matrix[j][i]>minInCol){
                    minInCol=matrix[j][i];
                }
                cols[i]=minInCol;
            }
        }
        
        for(int i=0;i<rows.Length;i++){
            if(cols.Contains(rows[i]))
                finalList.Add(rows[i]);
        }        
        return finalList;
    }
}

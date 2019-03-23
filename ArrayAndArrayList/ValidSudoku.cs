public class Solution {
    public bool IsValidSudoku(char[,] board)
        {

            List<int> intermediate;

            //row
            for (int i = 0; i < 9; i++)
            {
                intermediate = new List<int>();

                for (int j = 0; j < 9; j++)
                    if (intermediate.Contains(board[i, j]))
                        return false;
                    else if (board[i, j] != '.')
                        intermediate.Add(board[i, j]);
            }

            //column 
            for (int i = 0; i < 9; i++)
            {
                intermediate = new List<int>();

                for (int j = 0; j < 9; j++)
                    if (intermediate.Contains(board[j, i]))
                        return false;
                    else if (board[j, i] != '.')
                        intermediate.Add(board[j, i]);
            }

            //call to function
            for (int i = 0; i < 9; i = i + 3)
            {
                for (int j = 0; j < 9; j = j + 3)
                {
                    bool res = ThreeByThree(board, i, j);
                    if (res == false) return false;
                }
            }

            return true;
        }

        public bool ThreeByThree(char[,] arr, int startRow, int startCol)
        {
            List<char> box = new List<char>();

            for (int i = startRow; i < startRow+3; i++)
            {
                for (int j = startCol; j < startCol+3; j++)
                {
                    if (box.Contains(arr[i, j]))
                        return false;
                    else if (arr[i, j] != '.')
                        box.Add(arr[i, j]);
                }
            }

            return true;
        }
}

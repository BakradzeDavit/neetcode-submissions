public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        for (int row = 0; row < board.Length; row++)
        {
            for (int col = 0; col < board[row].Length; col++)
            {
               if (board[row][col] != '.' && !IsValidPlacement(board, row, col))
                {
                    return false;
                }
            }
        }
        return true;
    }

    private bool IsValidPlacement(char[][] board, int row, int col)
    {
        char value = board[row][col];
        
        for (int i = 0; i < 9; i++)
        {
            if (i != col && board[row][i] == value)
            {
                return false;
            }
            if (i != row && board[i][col] == value)
            {
                return false;
            }
        }

        int startRow = (row / 3) * 3;
        int startCol = (col / 3) * 3;

        for (int i = startRow; i < startRow + 3; i++)
        {
            for (int j = startCol; j < startCol + 3; j++)
            {
                if ((i != row || j != col) && board[i][j] == value)
                {
                    return false;
                }
            }
        }


        return true;


    }
}

public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        
        int right = 0;
    
        for (int i = 0; i < matrix.Length; i++) //matrix = [[1, 3, 5]] 3
        {
            if (matrix[i][matrix[i].Length - 1] >= target)
            {
                right = matrix[i].Length - 1; // 2
                int left = 0;
                while (left <= right)
                {

                    int middle = left +(right - left) / 2;
                    
                    if (matrix[i][middle] == target)
                    {
                        return true;
                    }
                    else if (matrix[i][middle] > target)
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }
                return false;
            }
        }
        return false;
    }
}

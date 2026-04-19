public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
  

        for (int i = 0; i < matrix.Length; i++)
        {
            int left = 0;
            int right = matrix[i].Length - 1;
            
            while(left <= right)
            {
                int middle = left + (right - left) / 2;

                if(matrix[i][middle] == target)
                    return true;

                if(target > matrix[i][middle])
                {
                    left = middle + 1;
                }else{
                    right = middle - 1;
                }

            }
        }
        return false;
    }
}

public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;
        
        while (left < right)
        {
            int result = numbers[left] + numbers[right];
            if(result == target){
                return new  int[] {left + 1, right + 1};
            }

            if(result < target){
                left++;
            }
            else{
                right--;
            }
        }
        return new int[] { };
        
    }
}

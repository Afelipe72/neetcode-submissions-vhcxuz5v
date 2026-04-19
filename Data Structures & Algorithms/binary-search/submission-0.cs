public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0; //0
        int right = nums.Length - 1; // 9
        while(left <= right){
            // left plus the middle from that array
            int middle = left + (right - left) / 2; //4 

            if(nums[middle] == target)
                return middle;

            if(target > nums[middle]){
                left = middle + 1; //5
            }else{
                right = middle - 1;
            }
        }
        
        return -1;

    }
}

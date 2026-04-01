public class Solution {
    public int LongestConsecutive(int[] nums) {

        if (nums.Length == 0) return 0;

        Array.Sort(nums);

        int currentStreak = 1;
        int maxStreak = 1;

        for (int i = 1; i < nums.Length; i++) {

            if (nums[i] == nums[i - 1]) {
                continue; // ignore duplicates
            }

            if (nums[i] == nums[i - 1] + 1) {
                currentStreak++;
            } else {
                currentStreak = 1;
            }

            maxStreak = Math.Max(maxStreak, currentStreak);
        }

        return maxStreak;
    }
}

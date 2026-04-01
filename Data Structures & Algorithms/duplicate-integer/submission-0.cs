public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> duplicates = new HashSet<int>();
        foreach(int num in nums){
            if (duplicates.Contains(num)){
                return true;
            }
            duplicates.Add(num);
        }
        return false;

    }
}

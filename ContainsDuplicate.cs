// Subject Arrays & Hashing
// Time Complexity O(N)
// Space Complexity O(N)

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, int> dict = new();

        for (int i = 0; i < nums.Length; i++) {
            if (dict.ContainsKey(nums[i])) {
                return true;
            } else {
                dict.TryAdd(nums[i], 1);
            }
        }

        return false;
    }
}
// Subject Arrays & Hashing
// Time Complexity O(N)
// Space Complexity O(N)

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int arrLength = nums.Length;
        int[] result = new int[arrLength];
        result[0] = 1;
        int prefix = 1;

        for (int i = 1; i < arrLength; i++) {
            result[i] = nums[i - 1] * prefix;
            prefix *= nums[i - 1];
        }

        int postfix = 1;
        for (int i = arrLength - 2; i >= 0; i--) {
            postfix *= nums[i + 1];
            result[i] *= postfix;
        }

        return result;
    }
}
// Subject BinarySearch
// Time Complexity O(N)
// Space Complexity O(1)

public class Solution {
    public int Search(int[] nums, int target) {

        int l = 0, middle = 0, r = nums.Length - 1;
        
        while(l <= r) {
            middle = (l + r) / 2;
            if (nums[middle] == target) return middle;
            else if (nums[middle] > target) r = middle - 1;
            else l = middle + 1;
        }

        return -1;
    }
}
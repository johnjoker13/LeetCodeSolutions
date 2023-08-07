// Subject Arrays & Hashing
// Time Complexity O(N)
// Space Complexity O(N)

public class Solution {

    public int[] TwoSum(int[] nums, int target) {

       Dictionary<int, int> dict = new();

       for (int i = 0; i < nums.Length; i++) {
           
           int curr = nums[i];
           int num = target - curr;

           if (dict.ContainsKey(num)) {
               return new int[2] { i, dict[num] };
           }

          dict.TryAdd(curr, i);

       }

       return new int[] {};

    }
}
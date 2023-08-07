// Subject Two Pointers
// Time Complexity O(N)
// Space Complexity O(1)


public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0, r = numbers.Length - 1;

        while (numbers[l] + numbers[r] != target) {
          if (numbers[l] + numbers[r] > target) r--;
          else l++;
          
        }

        return new int[] {++l, ++r};
    }
}
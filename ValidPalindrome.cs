// Subject Two Pointers
// Time Complexity O(N)
// Space Complexity O(1)

public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0;
        int r = s.Length - 1;
        while (l <= r) {
          char currLeft = s[l];
          char currRight = s[r];

          if (!Char.IsLetterOrDigit(currLeft)) {
              l++;
          } else if (!Char.IsLetterOrDigit(currRight)) {
              r--;
          } else {
              if (Char.ToLower(currLeft) != Char.ToLower(currRight)) {
                  return false;
              }
              l++;
              r--;
          }
        }

        return true;
    }
}
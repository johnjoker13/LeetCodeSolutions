// Subject Arrays & Hashing
// Time Complexity O(N)
// Space Complexity O(1)

public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        int[] freq = new int[26];

        for (int i = 0; i < s.Length; i++) {
            freq[s[i] - 'a']++;
            freq[t[i] - 'a']--;
        }

        for (int i = 0; i < freq.Length; i++) {
            if (freq[i] != 0) return false;
        }

        return true;
    }
}
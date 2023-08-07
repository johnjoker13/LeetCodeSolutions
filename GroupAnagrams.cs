// Subject Arrays & Hashing
// Time Complexity O(N*MLogM)
// Space Complexity O(N)

public class Solution {

    public string SortStr (string str) {
        char[] strArr = str.ToArray();
        Array.Sort(strArr);
        return new string(strArr);
    }

    public IList<IList<string>> GroupAnagrams(string[] strs) {

        Dictionary<string, List<string>> dict = new();

        List<IList<string>> result = new();

        for (int i = 0; i < strs.Length; i++) {

            string currStr = SortStr(strs[i]);

            if (dict.ContainsKey(currStr)) {

                dict[currStr].Add(strs[i]);

            } else {

                dict.Add(currStr, new List<string>{strs[i]});

            }
        }

        foreach (var key in dict) {

            result.Add(key.Value);
            
        }

        return result;
    }
}
// Subject Arrays & Hashing
// Time Complexity O(NLogN)
// Space Complexity O(N + K)

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        Dictionary<int, int> dict = new();
        PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>(
            Comparer<int>.Create((a, b) => b - a));
        int[] result = new int[k];

        for (int i = 0; i < nums.Length; i++) {
            if (dict.ContainsKey(nums[i])) {
                dict[nums[i]] += 1;
            } else {
                dict.Add(nums[i], 1);
            }
        }

        foreach (var entry in dict) {
            priorityQueue.Enqueue(entry.Key, entry.Value);
        }


        for (int i = 0; i < k; i++) {
          result[i] = priorityQueue.Dequeue();
        }
        
        return result;
    }
}
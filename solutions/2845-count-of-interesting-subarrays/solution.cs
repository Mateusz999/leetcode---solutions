using System;
using System.Collections.Generic;

public class Solution {
    public long CountInterestingSubarrays(IList<int> nums, int modulo, int k) {
        int n = nums.Count;
        int[] arr = new int[n];
        for (int i = 0; i < n; ++i) {
            arr[i] = nums[i] % modulo == k ? 1 : 0;
        }
        Dictionary<int, int> cnt = new Dictionary<int, int>();
        cnt[0] = 1;
        long ans = 0;
        int s = 0;
        foreach (int x in arr) {
            s += x;
            ans += cnt.GetValueOrDefault((s - k + modulo) % modulo, 0);
            if (cnt.ContainsKey(s % modulo)) {
                cnt[s % modulo]++;
            } else {
                cnt[s % modulo] = 1;
            }
        }
        return ans;
    }
}

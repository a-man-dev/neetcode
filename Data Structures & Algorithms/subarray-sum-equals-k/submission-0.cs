public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var res = 0;
        var currentSum = 0;
        var prefixSumCount = new Dictionary<int,int> { {0,1} };

        foreach (var n in nums) {
            currentSum += n;

            var diff = currentSum - k;

            res += prefixSumCount.ContainsKey(diff) ? prefixSumCount[diff] : 0;

            prefixSumCount[currentSum] = prefixSumCount.ContainsKey(currentSum) ? prefixSumCount[currentSum] + 1 : 1;
        }

        return res;
    }
}
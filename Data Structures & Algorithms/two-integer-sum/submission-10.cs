public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var nIndex = new Dictionary<int,int>(); 

        for (var i = 0; i < nums.Length; i++) {
            var diff = target - nums[i];

            if (nIndex.ContainsKey(diff)) {
                return [nIndex[diff], i];
            }
            else {
                nIndex[nums[i]] = i;
            }
        }

        return [-1,-1];


    }
}

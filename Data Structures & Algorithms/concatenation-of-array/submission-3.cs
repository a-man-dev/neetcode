public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var resultNums = new List<int>();

        for (var i = 0; i < 2; i++) 
        {
            foreach (var n in nums) {
                resultNums.Add(n);
            }
        }

        return resultNums.ToArray();
    }
}
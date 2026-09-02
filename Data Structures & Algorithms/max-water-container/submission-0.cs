public class Solution {
    public int MaxArea(int[] heights) {
        var res = 0;

        var l = 0;
        var r = heights.Length - 1;

        while (l < r) {

            var width = r - l;
            var height = heights[l] < heights[r] ? heights[l] : heights[r];

            var area = width * height;
            res = area > res ? area : res;

            if (heights[l] < heights[r]) {
                l++;
            }
            else {
                r--;
            }
        }

        return res;
    }
}

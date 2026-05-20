public class Solution {
    public void SortColors(int[] nums) {
        

        void Swap(int i, int j) {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        var l = 0;
        var r = nums.Length - 1;
        var i = 0;

        while (i <= r) {
            if (nums[i] == 0) {
                Swap(i,l);
                l++;
            }
            else if (nums[i] == 2) {
                Swap(i,r);
                r--;
                i--;
            }
            i++;
        } 
    }

    
}
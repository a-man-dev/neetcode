public class Solution {
    public int NumRescueBoats(int[] people, int limit) {

        Array.Sort(people);
        var count = 0;

        var l  = 0;
        var r = people.Length - 1;

        while (l <= r) {
            var remain = limit - people[r];
            count++;
            r--;

            if (l <= r && people[l] <= remain) {
                l++;
            }
        }

        return count;
    }
}
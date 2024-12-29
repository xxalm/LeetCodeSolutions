public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int left = 0, right = nums.Length - 1;

        while (left < right) {
            int middle = left + (right - left) / 2;
            bool isEven = middle % 2 == 0;

            if ((isEven && nums[middle] == nums[middle + 1]) || (!isEven && nums[middle] == nums[middle - 1])) {
                left = middle + 1;
            } else {
                right = middle;
            }
        }
        return nums[left];
    }
}
public class Solution {
    public int MaximumGap(int[] nums) {
        if (nums.Length < 2)
            return 0;
        int min = int.MaxValue, max = int.MinValue;
        foreach (int num in nums) {
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }
        int n = nums.Length;
        int bucketSize = Math.Max(1, (max - min) / (n - 1));
        int bucketCount = (max - min) / bucketSize + 1;

        int[] bucketMin = new int[bucketCount];
        int[] bucketMax = new int[bucketCount];
        Array.Fill(bucketMin, int.MaxValue);
        Array.Fill(bucketMax, int.MinValue);

        foreach (int num in nums) {
            int bucketIndex = (num - min) / bucketSize;
            bucketMin[bucketIndex] = Math.Min(bucketMin[bucketIndex], num);
            bucketMax[bucketIndex] = Math.Max(bucketMax[bucketIndex], num);
        }

        int maxGap = 0;
        int previousMax = min;

        for (int i = 0; i < bucketCount; i++) {
            if (bucketMin[i] == int.MaxValue && bucketMax[i] == int.MinValue)
                continue;
            
            maxGap = Math.Max(maxGap, bucketMin[i] - previousMax);
            previousMax = bucketMax[i];
        } 
        return maxGap;
    }
}
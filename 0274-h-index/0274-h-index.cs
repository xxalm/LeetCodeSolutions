public class Solution
{
    public int HIndex(int[] citations)
    {
        
        Array.Sort(citations);
        Array.Reverse(citations);

        
        int h = 0;
        for (int i = 0; i < citations.Length; i++)
        {
            if (i + 1 <= citations[i]) 
            {
                h = i + 1;
            }
            else
            {
                break;
            }
        }

        return h;
    }
}
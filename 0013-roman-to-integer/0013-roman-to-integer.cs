public class Solution
{
    public int RomanToInt(string s)
    {
        
        var romanToInt = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int total = 0;

        
        for (int i = 0; i < s.Length; i++)
        {
            
            if (i < s.Length - 1 && romanToInt[s[i]] < romanToInt[s[i + 1]])
            {
                total -= romanToInt[s[i]];
            }
            else
            {
                total += romanToInt[s[i]];
            }
        }

        return total;
    }
}

public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        var sortedS = new string(s.OrderBy(c => c).ToArray());
        var sortedT = new string(t.OrderBy(c => c).ToArray());

        return sortedS == sortedT;
    }


}
public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] tChar = t.ToCharArray();
        char[] sChar = s.ToCharArray();
        
        Array.Sort(tChar);
        Array.Sort(sChar);
        
        string tResult = new string(tChar);
        string sResult = new string(sChar);

        return tResult == sResult;
    }
}
public class Solution {
    public char FindTheDifference(string s, string t) {
        
        List<char> result = new List<char>(t);

        for(int i=0; i<s.Length; i++) result.Remove(s[i]);

        return result[0];        
    }
}
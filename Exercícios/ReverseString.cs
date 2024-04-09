public class Solution {
    public void ReverseString(char[] s) {
        char[] reverse = new char[s.Length];
    
        for(int i=0, j=s.Length-1; i<s.Length; i++, j--){
            reverse[i] = s[j];
        }

        for(int i=0; i<s.Length; i++){
            s[i] = reverse[i];
        }
    }
}
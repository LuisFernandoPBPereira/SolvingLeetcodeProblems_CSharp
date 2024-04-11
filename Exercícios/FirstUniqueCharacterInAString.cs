public class Solution {
    public int FirstUniqChar(string s) {
        int cont=0;
        for(int i=0; i<s.Length; i++){
            for(int j=0; j<s.Length; j++){
                if(s[i] == s[j])
                    cont++;
                if(cont > 1) break;
            }
            if(cont == 1)
                return i;

            cont=0;
        }

        return -1;
    }
}